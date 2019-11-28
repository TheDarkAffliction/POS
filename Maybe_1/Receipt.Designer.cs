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
            this.tmrDraw2 = new System.Windows.Forms.Timer(this.components);
            this.lblSetMerchTotal = new System.Windows.Forms.Label();
            this.lblMerchTotal = new System.Windows.Forms.Label();
            this.lblHST = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSetHST = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSetType = new System.Windows.Forms.Label();
            this.lblSetChange = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lblTicket.Size = new System.Drawing.Size(95, 16);
            this.lblTicket.TabIndex = 3;
            this.lblTicket.Text = "Sales Ticket:   ";
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerson.Location = new System.Drawing.Point(12, 237);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(101, 16);
            this.lblPerson.TabIndex = 4;
            this.lblPerson.Text = "Sales Person:   ";
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
            // tmrDraw2
            // 
            this.tmrDraw2.Interval = 1;
            this.tmrDraw2.Tick += new System.EventHandler(this.tmrDraw2_Tick);
            // 
            // lblSetMerchTotal
            // 
            this.lblSetMerchTotal.AutoSize = true;
            this.lblSetMerchTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetMerchTotal.Location = new System.Drawing.Point(12, 370);
            this.lblSetMerchTotal.Name = "lblSetMerchTotal";
            this.lblSetMerchTotal.Size = new System.Drawing.Size(123, 16);
            this.lblSetMerchTotal.TabIndex = 6;
            this.lblSetMerchTotal.Text = "Merchandise Total:";
            this.lblSetMerchTotal.Visible = false;
            // 
            // lblMerchTotal
            // 
            this.lblMerchTotal.AutoSize = true;
            this.lblMerchTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerchTotal.Location = new System.Drawing.Point(257, 370);
            this.lblMerchTotal.Name = "lblMerchTotal";
            this.lblMerchTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMerchTotal.Size = new System.Drawing.Size(15, 16);
            this.lblMerchTotal.TabIndex = 7;
            this.lblMerchTotal.Text = "$";
            this.lblMerchTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMerchTotal.Visible = false;
            // 
            // lblHST
            // 
            this.lblHST.AutoSize = true;
            this.lblHST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHST.Location = new System.Drawing.Point(257, 386);
            this.lblHST.Name = "lblHST";
            this.lblHST.Size = new System.Drawing.Size(15, 16);
            this.lblHST.TabIndex = 8;
            this.lblHST.Text = "$";
            this.lblHST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHST.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "$";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Visible = false;
            // 
            // lblSetHST
            // 
            this.lblSetHST.AutoSize = true;
            this.lblSetHST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetHST.Location = new System.Drawing.Point(12, 386);
            this.lblSetHST.Name = "lblSetHST";
            this.lblSetHST.Size = new System.Drawing.Size(36, 16);
            this.lblSetHST.TabIndex = 10;
            this.lblSetHST.Text = "HST";
            this.lblSetHST.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(12, 402);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 16);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total";
            this.lblTotal.Visible = false;
            // 
            // lblSetType
            // 
            this.lblSetType.AutoSize = true;
            this.lblSetType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetType.Location = new System.Drawing.Point(12, 433);
            this.lblSetType.Name = "lblSetType";
            this.lblSetType.Size = new System.Drawing.Size(40, 16);
            this.lblSetType.TabIndex = 12;
            this.lblSetType.Text = "Type";
            this.lblSetType.Visible = false;
            // 
            // lblSetChange
            // 
            this.lblSetChange.AutoSize = true;
            this.lblSetChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetChange.Location = new System.Drawing.Point(12, 449);
            this.lblSetChange.Name = "lblSetChange";
            this.lblSetChange.Size = new System.Drawing.Size(55, 16);
            this.lblSetChange.TabIndex = 13;
            this.lblSetChange.Text = "Change";
            this.lblSetChange.Visible = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(227, 433);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(45, 16);
            this.lblType.TabIndex = 14;
            this.lblType.Text = "label1";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblType.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Visible = false;
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblSetChange);
            this.Controls.Add(this.lblSetType);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSetHST);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHST);
            this.Controls.Add(this.lblMerchTotal);
            this.Controls.Add(this.lblSetMerchTotal);
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
        private System.Windows.Forms.Timer tmrDraw2;
        private System.Windows.Forms.Label lblSetMerchTotal;
        private System.Windows.Forms.Label lblMerchTotal;
        private System.Windows.Forms.Label lblHST;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSetHST;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSetType;
        private System.Windows.Forms.Label lblSetChange;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label1;
    }
}