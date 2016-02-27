namespace PSO
{
    partial class ImageForm
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
            this.picBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadimage = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.slider = new System.Windows.Forms.TrackBar();
            this.colorPicker = new System.Windows.Forms.Panel();
            this.txtOmega = new System.Windows.Forms.TextBox();
            this.txtAgents = new System.Windows.Forms.TextBox();
            this.txtIteration = new System.Windows.Forms.TextBox();
            this.lblOmega = new System.Windows.Forms.Label();
            this.lblAgents = new System.Windows.Forms.Label();
            this.lblIteration = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiParticle = new System.Windows.Forms.TextBox();
            this.txtFiSwarm = new System.Windows.Forms.TextBox();
            this.lblBestSwarmPosition = new System.Windows.Forms.Label();
            this.lblBestSwarmPositionValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(12, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(500, 500);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnLoadimage
            // 
            this.btnLoadimage.Location = new System.Drawing.Point(12, 636);
            this.btnLoadimage.Name = "btnLoadimage";
            this.btnLoadimage.Size = new System.Drawing.Size(75, 23);
            this.btnLoadimage.TabIndex = 1;
            this.btnLoadimage.Text = "Browse";
            this.btnLoadimage.UseVisualStyleBackColor = true;
            this.btnLoadimage.Click += new System.EventHandler(this.btnLoadimage_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(93, 636);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // slider
            // 
            this.slider.Location = new System.Drawing.Point(198, 636);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(263, 45);
            this.slider.TabIndex = 3;
            this.slider.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // colorPicker
            // 
            this.colorPicker.BackColor = System.Drawing.Color.Black;
            this.colorPicker.Location = new System.Drawing.Point(501, 636);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(60, 45);
            this.colorPicker.TabIndex = 4;
            // 
            // txtOmega
            // 
            this.txtOmega.Location = new System.Drawing.Point(629, 5);
            this.txtOmega.Name = "txtOmega";
            this.txtOmega.Size = new System.Drawing.Size(88, 20);
            this.txtOmega.TabIndex = 5;
            this.txtOmega.Text = "0.9";
            // 
            // txtAgents
            // 
            this.txtAgents.Location = new System.Drawing.Point(629, 41);
            this.txtAgents.Name = "txtAgents";
            this.txtAgents.Size = new System.Drawing.Size(88, 20);
            this.txtAgents.TabIndex = 6;
            this.txtAgents.Text = "10000";
            // 
            // txtIteration
            // 
            this.txtIteration.Location = new System.Drawing.Point(629, 77);
            this.txtIteration.Name = "txtIteration";
            this.txtIteration.Size = new System.Drawing.Size(88, 20);
            this.txtIteration.TabIndex = 7;
            this.txtIteration.Text = "1000";
            // 
            // lblOmega
            // 
            this.lblOmega.AutoSize = true;
            this.lblOmega.Location = new System.Drawing.Point(589, 12);
            this.lblOmega.Name = "lblOmega";
            this.lblOmega.Size = new System.Drawing.Size(41, 13);
            this.lblOmega.TabIndex = 9;
            this.lblOmega.Text = "Omega";
            // 
            // lblAgents
            // 
            this.lblAgents.AutoSize = true;
            this.lblAgents.Location = new System.Drawing.Point(588, 48);
            this.lblAgents.Name = "lblAgents";
            this.lblAgents.Size = new System.Drawing.Size(40, 13);
            this.lblAgents.TabIndex = 10;
            this.lblAgents.Text = "Agenty";
            // 
            // lblIteration
            // 
            this.lblIteration.AutoSize = true;
            this.lblIteration.Location = new System.Drawing.Point(588, 84);
            this.lblIteration.Name = "lblIteration";
            this.lblIteration.Size = new System.Drawing.Size(42, 13);
            this.lblIteration.TabIndex = 11;
            this.lblIteration.Text = "Iteracje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "fiCząsteczki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "fiRoju";
            // 
            // txtFiParticle
            // 
            this.txtFiParticle.Location = new System.Drawing.Point(629, 148);
            this.txtFiParticle.Name = "txtFiParticle";
            this.txtFiParticle.Size = new System.Drawing.Size(88, 20);
            this.txtFiParticle.TabIndex = 13;
            this.txtFiParticle.Text = "0.9";
            // 
            // txtFiSwarm
            // 
            this.txtFiSwarm.Location = new System.Drawing.Point(629, 112);
            this.txtFiSwarm.Name = "txtFiSwarm";
            this.txtFiSwarm.Size = new System.Drawing.Size(88, 20);
            this.txtFiSwarm.TabIndex = 12;
            this.txtFiSwarm.Text = "0.1";
            // 
            // lblBestSwarmPosition
            // 
            this.lblBestSwarmPosition.AutoSize = true;
            this.lblBestSwarmPosition.Location = new System.Drawing.Point(529, 196);
            this.lblBestSwarmPosition.Name = "lblBestSwarmPosition";
            this.lblBestSwarmPosition.Size = new System.Drawing.Size(101, 13);
            this.lblBestSwarmPosition.TabIndex = 16;
            this.lblBestSwarmPosition.Text = "najlepsze położenie";
            // 
            // lblBestSwarmPositionValue
            // 
            this.lblBestSwarmPositionValue.AutoSize = true;
            this.lblBestSwarmPositionValue.Location = new System.Drawing.Point(626, 196);
            this.lblBestSwarmPositionValue.Name = "lblBestSwarmPositionValue";
            this.lblBestSwarmPositionValue.Size = new System.Drawing.Size(0, 13);
            this.lblBestSwarmPositionValue.TabIndex = 17;
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 712);
            this.Controls.Add(this.lblBestSwarmPositionValue);
            this.Controls.Add(this.lblBestSwarmPosition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiParticle);
            this.Controls.Add(this.txtFiSwarm);
            this.Controls.Add(this.lblIteration);
            this.Controls.Add(this.lblAgents);
            this.Controls.Add(this.lblOmega);
            this.Controls.Add(this.txtIteration);
            this.Controls.Add(this.txtAgents);
            this.Controls.Add(this.txtOmega);
            this.Controls.Add(this.colorPicker);
            this.Controls.Add(this.slider);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnLoadimage);
            this.Controls.Add(this.picBox);
            this.Name = "ImageForm";
            this.Text = "ImageForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnLoadimage;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar slider;
        private System.Windows.Forms.Panel colorPicker;
        private System.Windows.Forms.TextBox txtOmega;
        private System.Windows.Forms.TextBox txtAgents;
        private System.Windows.Forms.TextBox txtIteration;
        private System.Windows.Forms.Label lblOmega;
        private System.Windows.Forms.Label lblAgents;
        private System.Windows.Forms.Label lblIteration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiParticle;
        private System.Windows.Forms.TextBox txtFiSwarm;
        private System.Windows.Forms.Label lblBestSwarmPosition;
        private System.Windows.Forms.Label lblBestSwarmPositionValue;
    }
}