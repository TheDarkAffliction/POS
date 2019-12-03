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
            this.lblHST = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSetHST = new System.Windows.Forms.Label();
            this.lblSetTotal = new System.Windows.Forms.Label();
            this.lblSetType = new System.Windows.Forms.Label();
            this.lblSetChange = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblMerchTotal = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblSetDiscount = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
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
            // 
            // lblHST
            // 
            this.lblHST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHST.Location = new System.Drawing.Point(185, 386);
            this.lblHST.Name = "lblHST";
            this.lblHST.Size = new System.Drawing.Size(90, 16);
            this.lblHST.TabIndex = 8;
            this.lblHST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(185, 402);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(90, 16);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "$";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSetHST
            // 
            this.lblSetHST.AutoSize = true;
            this.lblSetHST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetHST.Location = new System.Drawing.Point(12, 386);
            this.lblSetHST.Name = "lblSetHST";
            this.lblSetHST.Size = new System.Drawing.Size(39, 16);
            this.lblSetHST.TabIndex = 10;
            this.lblSetHST.Text = "HST:";
            // 
            // lblSetTotal
            // 
            this.lblSetTotal.AutoSize = true;
            this.lblSetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetTotal.Location = new System.Drawing.Point(12, 402);
            this.lblSetTotal.Name = "lblSetTotal";
            this.lblSetTotal.Size = new System.Drawing.Size(42, 16);
            this.lblSetTotal.TabIndex = 11;
            this.lblSetTotal.Text = "Total:";
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
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(153, 433);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(122, 16);
            this.lblType.TabIndex = 14;
            this.lblType.Text = "label1";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChange
            // 
            this.lblChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(153, 449);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(122, 16);
            this.lblChange.TabIndex = 15;
            this.lblChange.Text = "label1";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblChange.Visible = false;
            // 
            // lblMerchTotal
            // 
            this.lblMerchTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMerchTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerchTotal.Location = new System.Drawing.Point(185, 370);
            this.lblMerchTotal.Name = "lblMerchTotal";
            this.lblMerchTotal.Size = new System.Drawing.Size(90, 16);
            this.lblMerchTotal.TabIndex = 16;
            this.lblMerchTotal.Text = "$";
            this.lblMerchTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(12, 493);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(191, 80);
            this.lblEnd.TabIndex = 17;
            this.lblEnd.Text = "Returns and Exchanges only \r\nvalid witin 10 days of purchase.\r\n\r\nThank you for sh" +
    "opping at \r\nSportCo Source for Sports";
            // 
            // lblSetDiscount
            // 
            this.lblSetDiscount.AutoSize = true;
            this.lblSetDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetDiscount.Location = new System.Drawing.Point(11, 418);
            this.lblSetDiscount.Name = "lblSetDiscount";
            this.lblSetDiscount.Size = new System.Drawing.Size(60, 16);
            this.lblSetDiscount.TabIndex = 18;
            this.lblSetDiscount.Text = "Discount";
            this.lblSetDiscount.Visible = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(185, 417);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(90, 16);
            this.lblDiscount.TabIndex = 19;
            this.lblDiscount.Text = "$";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDiscount.Visible = false;
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 661);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblSetDiscount);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblMerchTotal);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblSetChange);
            this.Controls.Add(this.lblSetType);
            this.Controls.Add(this.lblSetTotal);
            this.Controls.Add(this.lblSetHST);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblHST);
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
        private System.Windows.Forms.Label lblHST;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSetHST;
        private System.Windows.Forms.Label lblSetTotal;
        private System.Windows.Forms.Label lblSetType;
        private System.Windows.Forms.Label lblSetChange;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblMerchTotal;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblSetDiscount;
        private System.Windows.Forms.Label lblDiscount;
    }
}