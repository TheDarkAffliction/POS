namespace Maybe_1
{
    partial class frmPayNow
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
            this.lblPayNow = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.btnOther = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnDebit = new System.Windows.Forms.Button();
            this.btnCredit = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.tbxBalance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 57);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPayNow
            // 
            this.lblPayNow.AutoSize = true;
            this.lblPayNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayNow.Location = new System.Drawing.Point(266, 13);
            this.lblPayNow.Name = "lblPayNow";
            this.lblPayNow.Size = new System.Drawing.Size(288, 73);
            this.lblPayNow.TabIndex = 1;
            this.lblPayNow.Text = "Pay Now";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(7, 382);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(74, 29);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total:";
            // 
            // tbxTotal
            // 
            this.tbxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotal.Location = new System.Drawing.Point(12, 414);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.ReadOnly = true;
            this.tbxTotal.Size = new System.Drawing.Size(138, 35);
            this.tbxTotal.TabIndex = 3;
            // 
            // btnOther
            // 
            this.btnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOther.Location = new System.Drawing.Point(590, 160);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(150, 150);
            this.btnOther.TabIndex = 7;
            this.btnOther.Text = "Other";
            this.btnOther.UseVisualStyleBackColor = true;
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.Location = new System.Drawing.Point(50, 160);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(150, 150);
            this.btnCash.TabIndex = 8;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnDebit
            // 
            this.btnDebit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebit.Location = new System.Drawing.Point(230, 160);
            this.btnDebit.Name = "btnDebit";
            this.btnDebit.Size = new System.Drawing.Size(150, 150);
            this.btnDebit.TabIndex = 9;
            this.btnDebit.Text = "Debit";
            this.btnDebit.UseVisualStyleBackColor = false;
            this.btnDebit.Click += new System.EventHandler(this.btnDebit_Click);
            // 
            // btnCredit
            // 
            this.btnCredit.BackColor = System.Drawing.Color.Red;
            this.btnCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredit.Location = new System.Drawing.Point(410, 160);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(150, 150);
            this.btnCredit.TabIndex = 10;
            this.btnCredit.Text = "Credit";
            this.btnCredit.UseVisualStyleBackColor = false;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(160, 382);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(106, 29);
            this.lblBalance.TabIndex = 12;
            this.lblBalance.Text = "Balance:";
            // 
            // tbxBalance
            // 
            this.tbxBalance.BackColor = System.Drawing.SystemColors.Window;
            this.tbxBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBalance.Location = new System.Drawing.Point(165, 414);
            this.tbxBalance.Name = "tbxBalance";
            this.tbxBalance.ReadOnly = true;
            this.tbxBalance.Size = new System.Drawing.Size(160, 35);
            this.tbxBalance.TabIndex = 11;
            this.tbxBalance.Text = "$0.00";
            // 
            // frmPayNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.ControlBox = false;
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.tbxBalance);
            this.Controls.Add(this.btnCredit);
            this.Controls.Add(this.btnDebit);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnOther);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPayNow);
            this.Controls.Add(this.btnBack);
            this.Name = "frmPayNow";
            this.Text = "Pay Now";
            this.Load += new System.EventHandler(this.frmPayNow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPayNow;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnDebit;
        private System.Windows.Forms.Button btnCredit;
        public System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.Label lblBalance;
        public System.Windows.Forms.TextBox tbxBalance;
    }
}