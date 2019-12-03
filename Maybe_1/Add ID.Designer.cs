namespace Maybe_1
{
    partial class frmAddID
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.cbxAdmin = new System.Windows.Forms.CheckBox();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(15, 13);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(122, 25);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(15, 75);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(121, 25);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(15, 137);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(86, 25);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "New ID:";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.Location = new System.Drawing.Point(20, 41);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(142, 31);
            this.tbxFirstName.TabIndex = 0;
            this.tbxFirstName.TextChanged += new System.EventHandler(this.tbxFirstName_TextChanged);
            // 
            // cbxAdmin
            // 
            this.cbxAdmin.AutoSize = true;
            this.cbxAdmin.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAdmin.Location = new System.Drawing.Point(20, 202);
            this.cbxAdmin.Name = "cbxAdmin";
            this.cbxAdmin.Size = new System.Drawing.Size(142, 43);
            this.cbxAdmin.TabIndex = 6;
            this.cbxAdmin.TabStop = false;
            this.cbxAdmin.Text = "Administrator";
            this.cbxAdmin.UseVisualStyleBackColor = true;
            // 
            // tbxID
            // 
            this.tbxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxID.Location = new System.Drawing.Point(20, 165);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(142, 31);
            this.tbxID.TabIndex = 2;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.Location = new System.Drawing.Point(20, 103);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(142, 31);
            this.tbxLastName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(181, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 154);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(181, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 60);
            this.btnBack.TabIndex = 8;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAddID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 252);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.cbxAdmin);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "frmAddID";
            this.Text = "Add ID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.CheckBox cbxAdmin;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
    }
}