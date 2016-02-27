using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PSO
{
    public partial class Function : Form
    {
        #region Constructors

        public Function()
        {
            InitializeComponent();
            this.t = new System.Windows.Forms.Timer();
            t.Interval = 50;
            t.Tick += t_Tick;
            t.Stop();
        }

        #endregion

        #region Constatns

        private const double xStep = 0.01;

        #endregion

        #region Fields
        private double minX = -7; //przedzial po ktorym szukam optimum
        private double maxX = 7;
        private double omega = 0.9; // odpowiada za wygaszanie ruchu, gdy o=1 nie zwalnia z t; gdy o<1 zwalniaja, o>1 przyspieszaja
        private int numberOfParticles = 100; // liczba agentow
        private System.Windows.Forms.Timer t; //inicjalizuje timer ktory obrazuje kazda iteracje, agenty jak znajduja optium
        private int iteration = 0; // licznik aktualnej iteracji
        private int maxIterations = 300; // maks liczba iteracji
        private double fiParticle = 0.01; // indywidualnosc czasteczki
        private double fiSwarm = 0.01; // stadnosc roju   

        private List<Particle> swarm;
        private double[] functionX;

        private double bestSwarmPosition;

        #endregion

        #region Private methods

        private void MoveSwarm(IEnumerable<Particle> swarm)
        {
            Random rand = new Random(0);
            foreach (Particle particle in swarm)
            {
                double velocity = omega * particle.Velocity +
                    fiParticle * rand.NextDouble() * (particle.BestPosition - particle.Position) +
                    fiSwarm * rand.NextDouble() * (bestSwarmPosition - particle.Position);
                particle.Velocity = velocity;

                if (this.EvaluateFunction(particle.Position) < this.EvaluateFunction(particle.Position + velocity))
                {
                    particle.BestPosition = particle.Position + velocity;
                }

                particle.Position += velocity;
                if (particle.Position < minX)
                {
                    particle.Position = minX;
                }

                if (particle.Position > maxX)
                {
                    particle.Position = maxX;
                }
            }

            double maxValue = int.MinValue;
            double particlePosition = int.MinValue;
            foreach (Particle particle in this.swarm)
            {
                if (this.EvaluateFunction(particle.Position) > maxValue)
                {
                    maxValue = this.EvaluateFunction(particle.Position);
                    particlePosition = particle.Position;
                }
            }

            this.bestSwarmPosition = particlePosition;
        }

        private void InitializeFunction()
        {
            this.functionX = new double[int.Parse(((maxX - minX) / xStep).ToString())];
            double value = minX;
            for (int i = 0; i < functionX.Length; i++)
            {
                functionX[i] = value;
                value += 0.01;
            }
        }

        private void InitializeSwarm()
        {
            this.swarm = new List<Particle>();
            Random rand = new Random();
            // z def ustalam pozycje czasteczek

            for (int i = 0; i < numberOfParticles; i++)
            {
                var position = rand.NextDouble() * (maxX - minX) + minX;
                var minV = -(maxX - minX);
                var maxV = maxX - minX;
                var velocity = rand.NextDouble() * (maxV - minV) + minV;
                this.swarm.Add(new Particle() { Position = position, BestPosition = position, Velocity = velocity });
            }

            this.bestSwarmPosition = this.swarm.First().Position;
        }

        /// <summary>
        /// Rysuje funkcje w okienku.
        /// </summary>
        /// <param name="x"></param>
        private void DrawFunction(double[] x, SeriesChartType chartType, string seriesName)
        {
            double[] y = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                y[i] = this.EvaluateFunction(x[i]);
            }

            this.chartFunction.Series.Add(seriesName);
            this.chartFunction.Series.FindByName(seriesName).ChartType = chartType;
            this.chartFunction.Series.FindByName(seriesName).Points.DataBindXY(x, y);
        }

        /// <summary>
        /// Rysuje funkcje w okienku.
        /// </summary>
        /// <param name="x"></param>
        private void DrawFunction(IEnumerable<Particle> swarm, SeriesChartType chartType, string seriesName)
        {
            this.DrawFunction(swarm.Select(x => x.Position).ToArray(), chartType, seriesName);
        }

        /// <summary>
        /// Oblicza wartosc funkcji.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private double EvaluateFunction(double x)
        {
            return Math.Sin(x);
        }

        #endregion

        #region Events

        private void btnStart_Click(object sender, EventArgs e)
        {   
            
            this.iteration = 0;
            this.InitializeFunction();
            this.InitializeSwarm();

            try
            {
                this.GetCurrentAlgorhitmParameters();
            }
            catch
            {
                MessageBox.Show("Invalid input data. Please use ',' or '.' in float numbers, depending on your system settings.");
                return;
            }
            this.t.Start();
        }

        private void GetCurrentAlgorhitmParameters()
        {
            try
            {
                this.minX = double.Parse(txtMin.Text);
                this.maxX = double.Parse(txtMax.Text);
                this.omega = double.Parse(txtOmega.Text);
                this.maxIterations = int.Parse(txtIteration.Text);
                this.numberOfParticles = int.Parse(txtAgent.Text);
                this.fiSwarm = double.Parse(txtFiSwarm.Text);
                this.fiParticle = double.Parse(txtFiParticle.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        void t_Tick(object sender, EventArgs e)
        {
            try
            {
                this.GetCurrentAlgorhitmParameters();
            }
            catch
            {
                this.t.Stop();
                MessageBox.Show("Invalid input data. Please use ',' or '.' in float numbers, depending on your system settings.");
                return;
            }

            this.MoveSwarm(this.swarm);
            this.chartFunction.Series.Clear();
            this.DrawFunction(this.functionX, SeriesChartType.Line, "Funkcja");
            this.DrawFunction(this.swarm, SeriesChartType.Point, "Ptaszki");
            this.lblPosition.Text = this.bestSwarmPosition.ToString("0.00");
            this.iteration++;
            if (iteration > maxIterations)
            {
                this.t.Stop();
            }
        }

        #endregion
    }
}
