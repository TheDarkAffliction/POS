namespace Maybe_1
{
    partial class frmAdminSettings
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTillNo = new System.Windows.Forms.Label();
            this.tbxTillNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 395);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 43);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTillNo
            // 
            this.lblTillNo.AutoSize = true;
            this.lblTillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTillNo.Location = new System.Drawing.Point(12, 13);
            this.lblTillNo.Name = "lblTillNo";
            this.lblTillNo.Size = new System.Drawing.Size(69, 24);
            this.lblTillNo.TabIndex = 1;
            this.lblTillNo.Text = "Till No.";
            // 
            // tbxTillNo
            // 
            this.tbxTillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTillNo.Location = new System.Drawing.Point(12, 40);
            this.tbxTillNo.Name = "tbxTillNo";
            this.tbxTillNo.Size = new System.Drawing.Size(100, 29);
            this.tbxTillNo.TabIndex = 2;
            this.tbxTillNo.TextChanged += new System.EventHandler(this.tbxTillNo_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmAdminSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxTillNo);
            this.Controls.Add(this.lblTillNo);
            this.Controls.Add(this.btnBack);
            this.Name = "frmAdminSettings";
            this.Text = "AdminSettings";
            this.Load += new System.EventHandler(this.frmAdminSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTillNo;
        public System.Windows.Forms.TextBox tbxTillNo;
        private System.Windows.Forms.Button button1;
    }
}