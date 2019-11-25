namespace Maybe_1
{
    partial class frmAdmin
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
            this.btnAddID = new System.Windows.Forms.Button();
            this.btnGoToRegister = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddID
            // 
            this.btnAddID.Location = new System.Drawing.Point(12, 12);
            this.btnAddID.Name = "btnAddID";
            this.btnAddID.Size = new System.Drawing.Size(159, 58);
            this.btnAddID.TabIndex = 0;
            this.btnAddID.Text = "Add ID";
            this.btnAddID.UseVisualStyleBackColor = true;
            this.btnAddID.Click += new System.EventHandler(this.btnAddID_Click);
            // 
            // btnGoToRegister
            // 
            this.btnGoToRegister.Location = new System.Drawing.Point(342, 12);
            this.btnGoToRegister.Name = "btnGoToRegister";
            this.btnGoToRegister.Size = new System.Drawing.Size(159, 58);
            this.btnGoToRegister.TabIndex = 1;
            this.btnGoToRegister.Text = "Register";
            this.btnGoToRegister.UseVisualStyleBackColor = true;
            this.btnGoToRegister.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(177, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(159, 58);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 78);
            this.ControlBox = false;
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnGoToRegister);
            this.Controls.Add(this.btnAddID);
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddID;
        private System.Windows.Forms.Button btnGoToRegister;
        private System.Windows.Forms.Button btnSettings;
    }
}