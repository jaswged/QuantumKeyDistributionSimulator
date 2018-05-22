namespace QuantumGedamkeDistribution
    {
    partial class frmEncryption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEncryption));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtEncrypted = new System.Windows.Forms.TextBox();
            this.lblToEncrypt = new System.Windows.Forms.Label();
            this.lblEncrypted = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblBits = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.Info;
            this.txtInput.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(31, 168);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(300, 361);
            this.txtInput.TabIndex = 0;
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.BackColor = System.Drawing.SystemColors.Info;
            this.txtEncrypted.Enabled = false;
            this.txtEncrypted.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncrypted.Location = new System.Drawing.Point(448, 168);
            this.txtEncrypted.Multiline = true;
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.Size = new System.Drawing.Size(300, 361);
            this.txtEncrypted.TabIndex = 1;
            // 
            // lblToEncrypt
            // 
            this.lblToEncrypt.AutoSize = true;
            this.lblToEncrypt.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToEncrypt.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblToEncrypt.Location = new System.Drawing.Point(88, 123);
            this.lblToEncrypt.Name = "lblToEncrypt";
            this.lblToEncrypt.Size = new System.Drawing.Size(192, 33);
            this.lblToEncrypt.TabIndex = 2;
            this.lblToEncrypt.Text = "Data to Encrypt";
            // 
            // lblEncrypted
            // 
            this.lblEncrypted.AutoSize = true;
            this.lblEncrypted.Enabled = false;
            this.lblEncrypted.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncrypted.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblEncrypted.Location = new System.Drawing.Point(499, 123);
            this.lblEncrypted.Name = "lblEncrypted";
            this.lblEncrypted.Size = new System.Drawing.Size(190, 33);
            this.lblEncrypted.TabIndex = 3;
            this.lblEncrypted.Text = "Encrypted Data";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEncrypt.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(357, 246);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 118);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = ">";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(145, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Use your Cipher to Encrypt";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblKey.Location = new System.Drawing.Point(163, 90);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(117, 33);
            this.lblKey.TabIndex = 6;
            this.lblKey.Text = "Your key";
            // 
            // lblBits
            // 
            this.lblBits.AutoSize = true;
            this.lblBits.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBits.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblBits.Location = new System.Drawing.Point(376, 90);
            this.lblBits.Name = "lblBits";
            this.lblBits.Size = new System.Drawing.Size(0, 40);
            this.lblBits.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuantumGedamkeDistribution.Properties.Resources.small_cc_logo;
            this.pictureBox1.Location = new System.Drawing.Point(346, 498);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(346, 451);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 41);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmEncryption
            // 
            this.AcceptButton = this.btnEncrypt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBits);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lblEncrypted);
            this.Controls.Add(this.lblToEncrypt);
            this.Controls.Add(this.txtEncrypted);
            this.Controls.Add(this.txtInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEncryption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEncryption";
            this.Load += new System.EventHandler(this.frmEncryption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtEncrypted;
        private System.Windows.Forms.Label lblToEncrypt;
        private System.Windows.Forms.Label lblEncrypted;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblBits;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancel;
        }
    }