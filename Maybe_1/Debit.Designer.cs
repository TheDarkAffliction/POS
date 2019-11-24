namespace Maybe_1
{
    partial class frmDebit
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
<<<<<<< HEAD
            this.SuspendLayout();
            // 
            // Debit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Debit";
            this.Text = "Debit";
            this.Load += new System.EventHandler(this.Debit_Load);
            this.ResumeLayout(false);
=======
            this.btnNext = new System.Windows.Forms.Button();
            this.lblInsert = new System.Windows.Forms.Label();
            this.ptrbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(592, 369);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(196, 69);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblInsert
            // 
            this.lblInsert.AutoSize = true;
            this.lblInsert.BackColor = System.Drawing.Color.Transparent;
            this.lblInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsert.Location = new System.Drawing.Point(146, 152);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(545, 146);
            this.lblInsert.TabIndex = 1;
            this.lblInsert.Text = "Please Insert \r\nCard when Ready";
            this.lblInsert.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ptrbxLogo
            // 
            this.ptrbxLogo.Image = global::Maybe_1.Properties.Resources.Logo_Cropped;
            this.ptrbxLogo.Location = new System.Drawing.Point(25, 12);
            this.ptrbxLogo.Name = "ptrbxLogo";
            this.ptrbxLogo.Size = new System.Drawing.Size(235, 104);
            this.ptrbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrbxLogo.TabIndex = 2;
            this.ptrbxLogo.TabStop = false;
            // 
            // frmDebit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInsert);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.ptrbxLogo);
            this.Name = "frmDebit";
            this.Text = "Debit";
            ((System.ComponentModel.ISupportInitialize)(this.ptrbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
>>>>>>> 607a50f3eb162b91ee197bd4e9bb3b94d47c0dc7

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblInsert;
        private System.Windows.Forms.PictureBox ptrbxLogo;
    }
}