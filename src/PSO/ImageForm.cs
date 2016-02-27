using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSO
{
    public partial class ImageForm : Form
    {
        #region Fields

        Bitmap bmp;
        private double omega = 0.99; // odpowiada za wygaszanie ruchu, gdy o=1 nie zwalnia z t; gdy o<1 zwalniaja, o>1 przyspieszaja
        private int numberOfParticles = 10000; // liczba agentow
        private System.Windows.Forms.Timer t; //inicjalizuje timer ktory obrazuje kazda iteracje, agenty jak znajduja optium
        private int iteration = 0; // licznik aktualnej iteracji
        private int maxIterations = 1000; // maks liczba iteracji
        private List<ImageParticle> swarm;
        private Point bestSwarmPosition;
        private double fiParticle = 0.9; // indywidualnosc czasteczki
        private double fiSwarm = 0.1; // stadnosc roju 
        #endregion

        #region Constatns

        // private const double fiParticle = 0.9; 
        // private const double fiSwarm = 0.1;     

        #endregion

        #region Properties

        #endregion

        #region Constructors

        public ImageForm()
        {
            InitializeComponent();
            this.slider.SetRange(0, 255);
            this.t = new System.Windows.Forms.Timer();
            t.Interval = 50;
            t.Tick += t_Tick;
            t.Stop();
        }

        #endregion

        #region Events

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.colorPicker.BackColor = Color.FromArgb(this.slider.Value, this.slider.Value, this.slider.Value);
        }

        private void btnLoadimage_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var name = openFileDialog1.FileName;
                this.bmp = new Bitmap(name);
                this.picBox.Image = this.bmp;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
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
            this.lblBestSwarmPositionValue.Text = this.bestSwarmPosition.X + " " + bestSwarmPosition.Y;
            this.DrawSwarm(this.swarm, Color.Red);
            this.iteration++;
            if (iteration > maxIterations)
            {
                this.t.Stop();
            }

        }

        #endregion

        #region Private method

        private void GetCurrentAlgorhitmParameters()
        {
            try
            {
                this.omega = double.Parse(txtOmega.Text);
                this.maxIterations = int.Parse(txtIteration.Text);
                this.numberOfParticles = int.Parse(txtAgents.Text);
                this.fiSwarm = double.Parse(txtFiSwarm.Text);
                this.fiParticle = double.Parse(txtFiParticle.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void MoveSwarm(IEnumerable<ImageParticle> swarm)
        {
            Random rand = new Random();
            foreach (ImageParticle particle in swarm)
            {
                double velocityX = omega * particle.Velocity.X +
                    fiParticle * rand.NextDouble() * (particle.BestPosition.X - particle.Position.X) +
                    fiSwarm * rand.NextDouble() * (bestSwarmPosition.X - particle.Position.X);

                double velocityY = omega * particle.Velocity.Y +
                   fiParticle * rand.NextDouble() * (particle.BestPosition.Y - particle.Position.Y) +
                   fiSwarm * rand.NextDouble() * (bestSwarmPosition.Y - particle.Position.Y);

                particle.Velocity = new Point((int)velocityX, (int)velocityY);

                Point newPositon = new Point(particle.Position.X + particle.Velocity.X, particle.Position.Y + particle.Velocity.Y);
                if (newPositon.X >= this.bmp.Width)
                {
                    newPositon = new Point(this.bmp.Width - 1, newPositon.Y);
                }

                if (newPositon.X < 0)
                {
                    newPositon = new Point(0, newPositon.Y);
                }

                if (newPositon.Y < 0)
                {
                    newPositon = new Point(newPositon.X, 0);
                }

                if (newPositon.Y >= this.bmp.Height)
                {
                    newPositon = new Point(newPositon.X, this.bmp.Height - 1);
                }

                if (this.EvaluateFunction(particle.Position) > this.EvaluateFunction(newPositon))
                {
                    particle.BestPosition = newPositon;
                }

                particle.Position = newPositon;
            }

            double minValue = int.MaxValue;
            Point particlePosition = new Point();
            foreach (ImageParticle particle in this.swarm)
            {
                if (this.EvaluateFunction(particle.Position) < minValue)
                {
                    minValue = this.EvaluateFunction(particle.Position);
                    particlePosition = particle.Position;
                }
            }

            this.bestSwarmPosition = particlePosition;
        }

        private double EvaluateFunction(Point p)
        {


            var pixelColor = this.bmp.GetPixel(p.X, p.Y);
            var pixelColorGray = .11 * pixelColor.B + .59 * pixelColor.G + .30 * pixelColor.R;

            var patternColor = this.colorPicker.BackColor;
            var patternColorGray = .11 * patternColor.B + .59 * patternColor.G + .30 * patternColor.R;
            var result = Math.Abs(pixelColorGray - patternColorGray) * 100.0 / 256.0;
            return result;
        }

        /// <summary>
        /// Rysuje funkcje w okienku.
        /// </summary>
        /// <param name="x"></param>
        private void DrawSwarm(IEnumerable<ImageParticle> swarm, Color color)
        {
            Bitmap newImage = new Bitmap(this.bmp);
            foreach (ImageParticle particle in swarm)
            {
                newImage.SetPixel(particle.Position.X, particle.Position.Y, color);

                //newImage.SetPixel((particle.Position.X == 0 ? 1 : particle.Position.X) - 1, particle.Position.Y, color);
                //newImage.SetPixel((particle.Position.X == this.bmp.Width - 1 ? this.bmp.Width - 2 : particle.Position.X) + 1 , particle.Position.Y, color);
                //newImage.SetPixel(particle.Position.X, (particle.Position.Y == 0 ? 1 : particle.Position.Y) - 1, color);
                //newImage.SetPixel(particle.Position.X, (particle.Position.Y == this.bmp.Height - 1 ? this.bmp.Height - 2 : particle.Position.Y) + 1, color);
            }
            this.picBox.Image = newImage;
        }

        private void InitializeSwarm()
        {
            this.swarm = new List<ImageParticle>();
            Random rand = new Random();
            // z def ustalam pozycje czasteczek

            for (int i = 0; i < numberOfParticles; i++)
            {
                var position = new Point(rand.Next(this.bmp.Width - 1), rand.Next(this.bmp.Height - 1));
                var minVx = -this.bmp.Width;
                var maxVx = this.bmp.Width;
                var minVy = -this.bmp.Height;
                var maxVy = this.bmp.Height;
                var velocityX = rand.NextDouble() * (maxVx - minVx) + minVx;
                var velocityY = rand.NextDouble() * (maxVy - minVy) + minVy;
                this.swarm.Add(new ImageParticle() { Position = position, BestPosition = position, Velocity = new Point((int)velocityX, (int)velocityY) });
            }

            this.bestSwarmPosition = this.swarm.First().Position;
        }

        #endregion


    }
}
