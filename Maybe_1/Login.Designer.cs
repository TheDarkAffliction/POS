﻿namespace Maybe_1
{
    partial class frmLogin
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
            this.tbxEnterID = new System.Windows.Forms.TextBox();
            this.pctrLogo = new System.Windows.Forms.PictureBox();
            this.lblEnterID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctrLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxEnterID
            // 
            this.tbxEnterID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxEnterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEnterID.Location = new System.Drawing.Point(141, 220);
            this.tbxEnterID.Name = "tbxEnterID";
            this.tbxEnterID.PasswordChar = '*';
            this.tbxEnterID.Size = new System.Drawing.Size(100, 29);
            this.tbxEnterID.TabIndex = 0;
            this.tbxEnterID.TextChanged += new System.EventHandler(this.tbxEnterID_TextChanged);
            // 
            // pctrLogo
            // 
            this.pctrLogo.Image = global::Maybe_1.Properties.Resources.Logo_Cropped;
            this.pctrLogo.Location = new System.Drawing.Point(12, 13);
            this.pctrLogo.Name = "pctrLogo";
            this.pctrLogo.Size = new System.Drawing.Size(360, 149);
            this.pctrLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrLogo.TabIndex = 2;
            this.pctrLogo.TabStop = false;
            // 
            // lblEnterID
            // 
            this.lblEnterID.AutoSize = true;
            this.lblEnterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterID.Location = new System.Drawing.Point(147, 192);
            this.lblEnterID.Name = "lblEnterID";
            this.lblEnterID.Size = new System.Drawing.Size(95, 25);
            this.lblEnterID.TabIndex = 3;
            this.lblEnterID.Text = "Enter ID:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lblEnterID);
            this.Controls.Add(this.pctrLogo);
            this.Controls.Add(this.tbxEnterID);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxEnterID;
        private System.Windows.Forms.PictureBox pctrLogo;
        private System.Windows.Forms.Label lblEnterID;
    }
}