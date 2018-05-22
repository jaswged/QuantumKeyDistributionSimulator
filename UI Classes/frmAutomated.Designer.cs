namespace QuantumGedamkeDistribution
    {
    partial class frmAutomated
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutomated));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuantumGedamkeDistribution.Properties.Resources.small_cc_logo;
            this.pictureBox1.Location = new System.Drawing.Point(669, 509);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblBits
            // 
            this.lblBits.AutoSize = true;
            this.lblBits.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBits.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblBits.Location = new System.Drawing.Point(60, 47);
            this.lblBits.Name = "lblBits";
            this.lblBits.Size = new System.Drawing.Size(471, 55);
            this.lblBits.TabIndex = 6;
            this.lblBits.Text = "Your number of bits is: ";
            // 
            // frmAutomated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblBits);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAutomated";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Automated Simulation";
            this.Load += new System.EventHandler(this.frmAutomated_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBits;
        }
    }