namespace Maybe_1
{
    partial class frmScanner
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
            this.btnSkates = new System.Windows.Forms.Button();
            this.btnWomensShoes = new System.Windows.Forms.Button();
            this.btnHockeyMask = new System.Windows.Forms.Button();
            this.btnHockeyGloves = new System.Windows.Forms.Button();
            this.btnLanyard = new System.Windows.Forms.Button();
            this.btnGiftCard = new System.Windows.Forms.Button();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSkates
            // 
            this.btnSkates.Location = new System.Drawing.Point(13, 13);
            this.btnSkates.Name = "btnSkates";
            this.btnSkates.Size = new System.Drawing.Size(100, 100);
            this.btnSkates.TabIndex = 0;
            this.btnSkates.Text = "Bauer Nexus 2N Senior Hockey Skates";
            this.btnSkates.UseVisualStyleBackColor = true;
            this.btnSkates.Click += new System.EventHandler(this.btnSkates_Click);
            // 
            // btnWomensShoes
            // 
            this.btnWomensShoes.Location = new System.Drawing.Point(225, 13);
            this.btnWomensShoes.Name = "btnWomensShoes";
            this.btnWomensShoes.Size = new System.Drawing.Size(100, 100);
            this.btnWomensShoes.TabIndex = 2;
            this.btnWomensShoes.Text = "Asics GT-1000 8 Women\'s Running Shoes";
            this.btnWomensShoes.UseVisualStyleBackColor = true;
            this.btnWomensShoes.Click += new System.EventHandler(this.btnWomensShoes_Click);
            // 
            // btnHockeyMask
            // 
            this.btnHockeyMask.Location = new System.Drawing.Point(331, 13);
            this.btnHockeyMask.Name = "btnHockeyMask";
            this.btnHockeyMask.Size = new System.Drawing.Size(100, 100);
            this.btnHockeyMask.TabIndex = 3;
            this.btnHockeyMask.Text = "BAUER 2100 Senior Hockey Facemask";
            this.btnHockeyMask.UseVisualStyleBackColor = true;
            this.btnHockeyMask.Click += new System.EventHandler(this.btnHockeyMask_Click);
            // 
            // btnHockeyGloves
            // 
            this.btnHockeyGloves.Location = new System.Drawing.Point(437, 13);
            this.btnHockeyGloves.Name = "btnHockeyGloves";
            this.btnHockeyGloves.Size = new System.Drawing.Size(100, 100);
            this.btnHockeyGloves.TabIndex = 4;
            this.btnHockeyGloves.Text = "Bauer Nexus Prodigy Youth Hockey Gloves";
            this.btnHockeyGloves.UseVisualStyleBackColor = true;
            this.btnHockeyGloves.Click += new System.EventHandler(this.btnHockeyGloves_Click);
            // 
            // btnLanyard
            // 
            this.btnLanyard.Location = new System.Drawing.Point(119, 13);
            this.btnLanyard.Name = "btnLanyard";
            this.btnLanyard.Size = new System.Drawing.Size(100, 100);
            this.btnLanyard.TabIndex = 1;
            this.btnLanyard.Text = "Fox 40 Breakaway Lanyard";
            this.btnLanyard.UseVisualStyleBackColor = true;
            this.btnLanyard.Click += new System.EventHandler(this.btnLanyard_Click);
            // 
            // btnGiftCard
            // 
            this.btnGiftCard.Location = new System.Drawing.Point(437, 119);
            this.btnGiftCard.Name = "btnGiftCard";
            this.btnGiftCard.Size = new System.Drawing.Size(100, 100);
            this.btnGiftCard.TabIndex = 24;
            this.btnGiftCard.Text = "Gift Card ($25)";
            this.btnGiftCard.UseVisualStyleBackColor = true;
            this.btnGiftCard.Click += new System.EventHandler(this.btnGiftCard_Click);
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Interval = 1;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // frmScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 230);
            this.ControlBox = false;
            this.Controls.Add(this.btnGiftCard);
            this.Controls.Add(this.btnLanyard);
            this.Controls.Add(this.btnHockeyGloves);
            this.Controls.Add(this.btnHockeyMask);
            this.Controls.Add(this.btnWomensShoes);
            this.Controls.Add(this.btnSkates);
            this.Name = "frmScanner";
            this.Text = "Scanner";
            this.Load += new System.EventHandler(this.frmScanner_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSkates;
        private System.Windows.Forms.Button btnWomensShoes;
        private System.Windows.Forms.Button btnHockeyMask;
        private System.Windows.Forms.Button btnHockeyGloves;
        private System.Windows.Forms.Button btnLanyard;
        private System.Windows.Forms.Button btnGiftCard;
        private System.Windows.Forms.Timer tmrUpdate;
    }
}