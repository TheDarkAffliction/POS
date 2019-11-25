namespace Maybe_1
{
    partial class frmReceipt
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
            this.components = new System.ComponentModel.Container();
            this.pctrLogo = new System.Windows.Forms.PictureBox();
            this.Info = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblTicket = new System.Windows.Forms.Label();
            this.lblPerson = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tmrDraw = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctrLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrLogo
            // 
            this.pctrLogo.Image = global::Maybe_1.Properties.Resources.Logo_Cropped;
            this.pctrLogo.Location = new System.Drawing.Point(-1, -7);
            this.pctrLogo.Name = "pctrLogo";
            this.pctrLogo.Size = new System.Drawing.Size(283, 119);
            this.pctrLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrLogo.TabIndex = 0;
            this.pctrLogo.TabStop = false;
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Location = new System.Drawing.Point(50, 115);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(168, 48);
            this.Info.TabIndex = 1;
            this.Info.Text = "SportCo Source For Sports\r\n880 King Street East\r\nKitchener ON, N2G-2M6\r\n";
            this.Info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.Location = new System.Drawing.Point(12, 173);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(202, 48);
            this.lblInfo2.TabIndex = 2;
            this.lblInfo2.Text = "E-Mail:     sales@sportco-int.com\r\nWebsite:  www.sportco-int.com\r\nPhone:     519-" +
    "744-6831";
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket.Location = new System.Drawing.Point(12, 221);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(86, 16);
            this.lblTicket.TabIndex = 3;
            this.lblTicket.Text = "Sales Ticket:";
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerson.Location = new System.Drawing.Point(12, 237);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(92, 16);
            this.lblPerson.TabIndex = 4;
            this.lblPerson.Text = "Sales Person:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 253);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(87, 16);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Place Holder";
            // 
            // tmrDraw
            // 
            this.tmrDraw.Enabled = true;
            this.tmrDraw.Interval = 1;
            this.tmrDraw.Tick += new System.EventHandler(this.tmrDraw_Tick_1);
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 661);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.lblTicket);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.pctrLogo);
            this.Name = "frmReceipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrLogo;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer tmrDraw;
    }
}