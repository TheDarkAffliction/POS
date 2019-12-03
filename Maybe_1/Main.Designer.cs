namespace Maybe_1
{
    partial class frmMain
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
            this.btnPower = new System.Windows.Forms.Button();
            this.btnPayNow = new System.Windows.Forms.Button();
            this.btnFlags = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.tmrLoad = new System.Windows.Forms.Timer(this.components);
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.tbxBalance = new System.Windows.Forms.TextBox();
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tblpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTableTotal = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.tbxHST = new System.Windows.Forms.TextBox();
            this.tbxGross = new System.Windows.Forms.TextBox();
            this.lblGross = new System.Windows.Forms.Label();
            this.lblHST = new System.Windows.Forms.Label();
            this.tbxDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxTill = new System.Windows.Forms.TextBox();
            this.lblTill = new System.Windows.Forms.Label();
            this.tmrDiscount = new System.Windows.Forms.Timer(this.components);
            this.lblDiscount = new System.Windows.Forms.Label();
            this.tbxDiscount = new System.Windows.Forms.TextBox();
            this.lblSportCo = new System.Windows.Forms.Label();
            this.tbxTime = new System.Windows.Forms.TextBox();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnEditPreset = new System.Windows.Forms.Button();
            this.btnPreset6 = new System.Windows.Forms.Button();
            this.btnPreset5 = new System.Windows.Forms.Button();
            this.btnPreset4 = new System.Windows.Forms.Button();
            this.btnPreset3 = new System.Windows.Forms.Button();
            this.btnPreset2 = new System.Windows.Forms.Button();
            this.btnPreset1 = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPower
            // 
            this.btnPower.BackColor = System.Drawing.Color.DarkRed;
            this.btnPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPower.ForeColor = System.Drawing.Color.White;
            this.btnPower.Location = new System.Drawing.Point(12, 776);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(75, 75);
            this.btnPower.TabIndex = 0;
            this.btnPower.TabStop = false;
            this.btnPower.Text = "Power";
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // btnPayNow
            // 
            this.btnPayNow.BackColor = System.Drawing.Color.Green;
            this.btnPayNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayNow.ForeColor = System.Drawing.Color.White;
            this.btnPayNow.Location = new System.Drawing.Point(1398, 525);
            this.btnPayNow.Name = "btnPayNow";
            this.btnPayNow.Size = new System.Drawing.Size(174, 324);
            this.btnPayNow.TabIndex = 0;
            this.btnPayNow.Text = "Pay Now";
            this.btnPayNow.UseVisualStyleBackColor = false;
            this.btnPayNow.Click += new System.EventHandler(this.btnPayNow_Click);
            // 
            // btnFlags
            // 
            this.btnFlags.BackColor = System.Drawing.Color.Maroon;
            this.btnFlags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlags.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlags.ForeColor = System.Drawing.Color.White;
            this.btnFlags.Location = new System.Drawing.Point(1398, 395);
            this.btnFlags.Name = "btnFlags";
            this.btnFlags.Size = new System.Drawing.Size(174, 124);
            this.btnFlags.TabIndex = 1;
            this.btnFlags.Text = "Flags";
            this.btnFlags.UseVisualStyleBackColor = false;
            this.btnFlags.Click += new System.EventHandler(this.btnFlags_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.Maroon;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.ForeColor = System.Drawing.Color.White;
            this.btnDiscount.Location = new System.Drawing.Point(1398, 262);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(174, 127);
            this.btnDiscount.TabIndex = 2;
            this.btnDiscount.Text = "Discount";
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // tmrLoad
            // 
            this.tmrLoad.Enabled = true;
            this.tmrLoad.Tick += new System.EventHandler(this.tmrLoad_Tick);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(1211, 776);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(120, 31);
            this.lblBalance.TabIndex = 9;
            this.lblBalance.Text = "Balance:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1023, 776);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(90, 31);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total: ";
            // 
            // tbxTotal
            // 
            this.tbxTotal.BackColor = System.Drawing.SystemColors.Window;
            this.tbxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotal.Location = new System.Drawing.Point(1029, 810);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.ReadOnly = true;
            this.tbxTotal.Size = new System.Drawing.Size(160, 38);
            this.tbxTotal.TabIndex = 7;
            this.tbxTotal.TabStop = false;
            this.tbxTotal.Text = "$0.00";
            // 
            // tbxBalance
            // 
            this.tbxBalance.BackColor = System.Drawing.SystemColors.Window;
            this.tbxBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBalance.Location = new System.Drawing.Point(1217, 810);
            this.tbxBalance.Name = "tbxBalance";
            this.tbxBalance.ReadOnly = true;
            this.tbxBalance.Size = new System.Drawing.Size(160, 38);
            this.tbxBalance.TabIndex = 7;
            this.tbxBalance.TabStop = false;
            this.tbxBalance.Text = "$0.00";
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.AutoSize = true;
            this.lblItemNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNumber.Location = new System.Drawing.Point(168, 230);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(152, 25);
            this.lblItemNumber.TabIndex = 0;
            this.lblItemNumber.Text = "Model Number";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(56, 230);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(92, 25);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity";
            // 
            // tblpMain
            // 
            this.tblpMain.AutoScroll = true;
            this.tblpMain.ColumnCount = 5;
            this.tblpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.51771F));
            this.tblpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.48229F));
            this.tblpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 597F));
            this.tblpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tblpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tblpMain.Location = new System.Drawing.Point(61, 272);
            this.tblpMain.Name = "tblpMain";
            this.tblpMain.RowCount = 100;
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblpMain.Size = new System.Drawing.Size(1306, 483);
            this.tblpMain.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(409, 230);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(120, 25);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(1007, 230);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(93, 25);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price ($)";
            // 
            // lblTableTotal
            // 
            this.lblTableTotal.AutoSize = true;
            this.lblTableTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableTotal.Location = new System.Drawing.Point(1187, 230);
            this.lblTableTotal.Name = "lblTableTotal";
            this.lblTableTotal.Size = new System.Drawing.Size(92, 25);
            this.lblTableTotal.TabIndex = 14;
            this.lblTableTotal.Text = "Total ($)";
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.Image = global::Maybe_1.Properties.Resources.Logo_Cropped;
            this.pbxLogo.Location = new System.Drawing.Point(12, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(403, 202);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 15;
            this.pbxLogo.TabStop = false;
            // 
            // tbxHST
            // 
            this.tbxHST.Location = new System.Drawing.Point(817, 810);
            this.tbxHST.Name = "tbxHST";
            this.tbxHST.Size = new System.Drawing.Size(100, 20);
            this.tbxHST.TabIndex = 17;
            this.tbxHST.TabStop = false;
            this.tbxHST.Text = "$0.00";
            // 
            // tbxGross
            // 
            this.tbxGross.Location = new System.Drawing.Point(711, 810);
            this.tbxGross.Name = "tbxGross";
            this.tbxGross.Size = new System.Drawing.Size(100, 20);
            this.tbxGross.TabIndex = 18;
            this.tbxGross.TabStop = false;
            this.tbxGross.Text = "$0.00";
            // 
            // lblGross
            // 
            this.lblGross.AutoSize = true;
            this.lblGross.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGross.Location = new System.Drawing.Point(707, 776);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(59, 24);
            this.lblGross.TabIndex = 19;
            this.lblGross.Text = "Gross";
            // 
            // lblHST
            // 
            this.lblHST.AutoSize = true;
            this.lblHST.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHST.Location = new System.Drawing.Point(813, 776);
            this.lblHST.Name = "lblHST";
            this.lblHST.Size = new System.Drawing.Size(48, 24);
            this.lblHST.TabIndex = 20;
            this.lblHST.Text = "HST";
            // 
            // tbxDate
            // 
            this.tbxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDate.Location = new System.Drawing.Point(448, 122);
            this.tbxDate.Name = "tbxDate";
            this.tbxDate.ReadOnly = true;
            this.tbxDate.Size = new System.Drawing.Size(112, 29);
            this.tbxDate.TabIndex = 21;
            this.tbxDate.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(444, 95);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 24);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "Date";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(444, 36);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(61, 24);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name";
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(448, 63);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(226, 29);
            this.tbxName.TabIndex = 24;
            this.tbxName.TabStop = false;
            // 
            // tbxTill
            // 
            this.tbxTill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTill.Location = new System.Drawing.Point(448, 185);
            this.tbxTill.Name = "tbxTill";
            this.tbxTill.ReadOnly = true;
            this.tbxTill.Size = new System.Drawing.Size(121, 29);
            this.tbxTill.TabIndex = 26;
            this.tbxTill.TabStop = false;
            // 
            // lblTill
            // 
            this.lblTill.AutoSize = true;
            this.lblTill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTill.Location = new System.Drawing.Point(444, 158);
            this.lblTill.Name = "lblTill";
            this.lblTill.Size = new System.Drawing.Size(69, 24);
            this.lblTill.TabIndex = 27;
            this.lblTill.Text = "Till No.";
            // 
            // tmrDiscount
            // 
            this.tmrDiscount.Interval = 1;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(919, 776);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(83, 24);
            this.lblDiscount.TabIndex = 28;
            this.lblDiscount.Text = "Discount";
            // 
            // tbxDiscount
            // 
            this.tbxDiscount.Location = new System.Drawing.Point(923, 810);
            this.tbxDiscount.Name = "tbxDiscount";
            this.tbxDiscount.Size = new System.Drawing.Size(100, 20);
            this.tbxDiscount.TabIndex = 29;
            this.tbxDiscount.TabStop = false;
            this.tbxDiscount.Text = "0%";
            this.tbxDiscount.DoubleClick += new System.EventHandler(this.tbxDiscount_DoubleClick);
            // 
            // lblSportCo
            // 
            this.lblSportCo.AutoSize = true;
            this.lblSportCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic);
            this.lblSportCo.Location = new System.Drawing.Point(144, 36);
            this.lblSportCo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSportCo.Name = "lblSportCo";
            this.lblSportCo.Size = new System.Drawing.Size(153, 37);
            this.lblSportCo.TabIndex = 30;
            this.lblSportCo.Text = "Sport Co.";
            this.lblSportCo.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxTime
            // 
            this.tbxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTime.Location = new System.Drawing.Point(558, 122);
            this.tbxTime.Name = "tbxTime";
            this.tbxTime.ReadOnly = true;
            this.tbxTime.Size = new System.Drawing.Size(116, 29);
            this.tbxTime.TabIndex = 31;
            this.tbxTime.TabStop = false;
            // 
            // tmrTimer
            // 
            this.tmrTimer.Enabled = true;
            this.tmrTimer.Interval = 1000;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(1383, -2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 878);
            this.textBox1.TabIndex = 32;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(711, -14);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(681, 235);
            this.textBox2.TabIndex = 33;
            // 
            // btnEditPreset
            // 
            this.btnEditPreset.Location = new System.Drawing.Point(379, 773);
            this.btnEditPreset.Name = "btnEditPreset";
            this.btnEditPreset.Size = new System.Drawing.Size(190, 75);
            this.btnEditPreset.TabIndex = 34;
            this.btnEditPreset.TabStop = false;
            this.btnEditPreset.Text = "Edit Presets";
            this.btnEditPreset.UseVisualStyleBackColor = true;
            // 
            // btnPreset6
            // 
            this.btnPreset6.Location = new System.Drawing.Point(1302, 122);
            this.btnPreset6.Name = "btnPreset6";
            this.btnPreset6.Size = new System.Drawing.Size(75, 75);
            this.btnPreset6.TabIndex = 35;
            this.btnPreset6.TabStop = false;
            this.btnPreset6.Text = "Preset 6";
            this.btnPreset6.UseVisualStyleBackColor = true;
            // 
            // btnPreset5
            // 
            this.btnPreset5.Location = new System.Drawing.Point(1221, 122);
            this.btnPreset5.Name = "btnPreset5";
            this.btnPreset5.Size = new System.Drawing.Size(75, 75);
            this.btnPreset5.TabIndex = 36;
            this.btnPreset5.TabStop = false;
            this.btnPreset5.Text = "Preset 5";
            this.btnPreset5.UseVisualStyleBackColor = true;
            // 
            // btnPreset4
            // 
            this.btnPreset4.Location = new System.Drawing.Point(1140, 122);
            this.btnPreset4.Name = "btnPreset4";
            this.btnPreset4.Size = new System.Drawing.Size(75, 75);
            this.btnPreset4.TabIndex = 37;
            this.btnPreset4.TabStop = false;
            this.btnPreset4.Text = "Preset 4";
            this.btnPreset4.UseVisualStyleBackColor = true;
            // 
            // btnPreset3
            // 
            this.btnPreset3.Location = new System.Drawing.Point(1059, 122);
            this.btnPreset3.Name = "btnPreset3";
            this.btnPreset3.Size = new System.Drawing.Size(75, 75);
            this.btnPreset3.TabIndex = 38;
            this.btnPreset3.TabStop = false;
            this.btnPreset3.Text = "Preset 3";
            this.btnPreset3.UseVisualStyleBackColor = true;
            // 
            // btnPreset2
            // 
            this.btnPreset2.Location = new System.Drawing.Point(978, 122);
            this.btnPreset2.Name = "btnPreset2";
            this.btnPreset2.Size = new System.Drawing.Size(75, 75);
            this.btnPreset2.TabIndex = 39;
            this.btnPreset2.TabStop = false;
            this.btnPreset2.Text = "Preset 2";
            this.btnPreset2.UseVisualStyleBackColor = true;
            // 
            // btnPreset1
            // 
            this.btnPreset1.Location = new System.Drawing.Point(897, 122);
            this.btnPreset1.Name = "btnPreset1";
            this.btnPreset1.Size = new System.Drawing.Size(75, 75);
            this.btnPreset1.TabIndex = 40;
            this.btnPreset1.TabStop = false;
            this.btnPreset1.Text = "Sharpen Skates";
            this.btnPreset1.UseVisualStyleBackColor = true;
            this.btnPreset1.Click += new System.EventHandler(this.btnPreset1_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(93, 776);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 75);
            this.btnLogOut.TabIndex = 41;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.Text = "Log\r\nOut";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnPreset1);
            this.Controls.Add(this.btnPreset2);
            this.Controls.Add(this.btnPreset3);
            this.Controls.Add(this.btnPreset4);
            this.Controls.Add(this.btnPreset5);
            this.Controls.Add(this.btnPreset6);
            this.Controls.Add(this.btnEditPreset);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbxTime);
            this.Controls.Add(this.lblSportCo);
            this.Controls.Add(this.tbxDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblTill);
            this.Controls.Add(this.tbxTill);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.tbxDate);
            this.Controls.Add(this.lblHST);
            this.Controls.Add(this.lblGross);
            this.Controls.Add(this.tbxGross);
            this.Controls.Add(this.tbxHST);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lblTableTotal);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tblpMain);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblItemNumber);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.tbxBalance);
            this.Controls.Add(this.btnFlags);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.btnPayNow);
            this.Controls.Add(this.textBox1);
            this.Name = "frmMain";
            this.Text = "Source For Sports";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnPayNow;
        private System.Windows.Forms.Button btnFlags;
        private System.Windows.Forms.Button btnDiscount;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Timer tmrLoad;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblItemNumber;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTableTotal;
        public System.Windows.Forms.Label lblQuantity;
        public System.Windows.Forms.TableLayoutPanel tblpMain;
        private System.Windows.Forms.PictureBox pbxLogo;
        public System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label lblHST;
        public System.Windows.Forms.TextBox tbxHST;
        public System.Windows.Forms.TextBox tbxGross;
        public System.Windows.Forms.TextBox tbxBalance;
        private System.Windows.Forms.TextBox tbxDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxTill;
        private System.Windows.Forms.Label lblTill;
        public System.Windows.Forms.Timer tmrDiscount;
        private System.Windows.Forms.Label lblDiscount;
        public System.Windows.Forms.TextBox tbxDiscount;
        private System.Windows.Forms.Label lblSportCo;
        private System.Windows.Forms.TextBox tbxTime;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnEditPreset;
        private System.Windows.Forms.Button btnPreset6;
        private System.Windows.Forms.Button btnPreset5;
        private System.Windows.Forms.Button btnPreset4;
        private System.Windows.Forms.Button btnPreset3;
        private System.Windows.Forms.Button btnPreset2;
        private System.Windows.Forms.Button btnPreset1;
        private System.Windows.Forms.Button btnLogOut;
    }
}

