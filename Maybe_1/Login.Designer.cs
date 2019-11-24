namespace Maybe_1
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
            this.FIXED_EnterID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxEnterID
            // 
            this.tbxEnterID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxEnterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEnterID.Location = new System.Drawing.Point(412, 252);
            this.tbxEnterID.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEnterID.Name = "tbxEnterID";
            this.tbxEnterID.Size = new System.Drawing.Size(132, 34);
            this.tbxEnterID.TabIndex = 0;
            this.tbxEnterID.TextChanged += new System.EventHandler(this.tbxEnterID_TextChanged);
            // 
            // FIXED_EnterID
            // 
            this.FIXED_EnterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIXED_EnterID.Location = new System.Drawing.Point(423, 207);
            this.FIXED_EnterID.Margin = new System.Windows.Forms.Padding(4);
            this.FIXED_EnterID.Name = "FIXED_EnterID";
            this.FIXED_EnterID.ReadOnly = true;
            this.FIXED_EnterID.Size = new System.Drawing.Size(109, 37);
            this.FIXED_EnterID.TabIndex = 1;
            this.FIXED_EnterID.Text = "Enter ID";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 506);
            this.Controls.Add(this.FIXED_EnterID);
            this.Controls.Add(this.tbxEnterID);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxEnterID;
        private System.Windows.Forms.TextBox FIXED_EnterID;
    }
}