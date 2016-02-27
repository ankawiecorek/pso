namespace PSO
{
    partial class Function
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbAgent = new System.Windows.Forms.Label();
            this.lblIteration = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAgent = new System.Windows.Forms.TextBox();
            this.txtIteration = new System.Windows.Forms.TextBox();
            this.txtOmega = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtFiParticle = new System.Windows.Forms.TextBox();
            this.txtFiSwarm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction.Legends.Add(legend1);
            this.chartFunction.Location = new System.Drawing.Point(12, 12);
            this.chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction.Series.Add(series1);
            this.chartFunction.Size = new System.Drawing.Size(856, 342);
            this.chartFunction.TabIndex = 0;
            this.chartFunction.Text = "chart1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(381, 373);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbAgent
            // 
            this.lbAgent.AutoSize = true;
            this.lbAgent.Location = new System.Drawing.Point(756, 78);
            this.lbAgent.Name = "lbAgent";
            this.lbAgent.Size = new System.Drawing.Size(40, 13);
            this.lbAgent.TabIndex = 2;
            this.lbAgent.Text = "Agenty";
            // 
            // lblIteration
            // 
            this.lblIteration.AutoSize = true;
            this.lblIteration.Location = new System.Drawing.Point(756, 104);
            this.lblIteration.Name = "lblIteration";
            this.lblIteration.Size = new System.Drawing.Size(42, 13);
            this.lblIteration.TabIndex = 3;
            this.lblIteration.Text = "Iteracje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(756, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Omega";
            // 
            // txtAgent
            // 
            this.txtAgent.Location = new System.Drawing.Point(806, 71);
            this.txtAgent.Name = "txtAgent";
            this.txtAgent.Size = new System.Drawing.Size(32, 20);
            this.txtAgent.TabIndex = 5;
            this.txtAgent.Text = "100";
            // 
            // txtIteration
            // 
            this.txtIteration.Location = new System.Drawing.Point(807, 97);
            this.txtIteration.Name = "txtIteration";
            this.txtIteration.Size = new System.Drawing.Size(31, 20);
            this.txtIteration.TabIndex = 6;
            this.txtIteration.Text = "100";
            // 
            // txtOmega
            // 
            this.txtOmega.Location = new System.Drawing.Point(808, 123);
            this.txtOmega.Name = "txtOmega";
            this.txtOmega.Size = new System.Drawing.Size(31, 20);
            this.txtOmega.TabIndex = 7;
            this.txtOmega.Text = "0.9";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(756, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(756, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "max";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(808, 148);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(31, 20);
            this.txtMin.TabIndex = 10;
            this.txtMin.Text = "-8";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(808, 174);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(31, 20);
            this.txtMax.TabIndex = 11;
            this.txtMax.Text = "8";
            // 
            // txtFiParticle
            // 
            this.txtFiParticle.Location = new System.Drawing.Point(806, 226);
            this.txtFiParticle.Name = "txtFiParticle";
            this.txtFiParticle.Size = new System.Drawing.Size(31, 20);
            this.txtFiParticle.TabIndex = 15;
            this.txtFiParticle.Text = "0.01";
            // 
            // txtFiSwarm
            // 
            this.txtFiSwarm.Location = new System.Drawing.Point(806, 200);
            this.txtFiSwarm.Name = "txtFiSwarm";
            this.txtFiSwarm.Size = new System.Drawing.Size(31, 20);
            this.txtFiSwarm.TabIndex = 14;
            this.txtFiSwarm.Text = "0.01";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(737, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "fiCząsteczki";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(754, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "fiRoju";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(737, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "położenie";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(797, 270);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(0, 13);
            this.lblPosition.TabIndex = 17;
            // 
            // Function
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 421);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFiParticle);
            this.Controls.Add(this.txtFiSwarm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOmega);
            this.Controls.Add(this.txtIteration);
            this.Controls.Add(this.txtAgent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIteration);
            this.Controls.Add(this.lbAgent);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chartFunction);
            this.Name = "Function";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbAgent;
        private System.Windows.Forms.Label lblIteration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAgent;
        private System.Windows.Forms.TextBox txtIteration;
        private System.Windows.Forms.TextBox txtOmega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtFiParticle;
        private System.Windows.Forms.TextBox txtFiSwarm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPosition;
    }
}

