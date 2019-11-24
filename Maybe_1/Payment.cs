﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;

namespace Maybe_1
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain.frmPayNow.Hide();
            frmMain.frmDiscount.Hide();
            frmScanner.frmMain.tblpMain.Controls.Clear();
            frmScanner.total = 0;
            frmScanner.discount = 0;
            frmScanner.gross = 0;
            frmDiscount.discount = 0;
            frmScanner.new_value = 0;

            tbxBalance.Text = "$0.00";
            tbxTotal.Text = "$0.00";
            tbxTotal.Text = "$0.00";

            frmScanner.update();

            frmScanner.frmMain.tbxBalance.Text = "$0.00";
            frmScanner.frmMain.tbxGross.Text = "$0.00";
            frmScanner.frmMain.tbxHST.Text = "$0.00";
            frmScanner.frmMain.tbxTotal.Text = "$0.00";

        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            /*
            tbxBalance.Text = frmMain.frmPayNow.tbxBalance.Text ;
            tbxTotal.Text = "$" + (frmScanner.gross + (frmScanner.gross / 100 * 13) - frmScanner.gross * (frmDiscount.discount / 100)).ToString("#.00", CultureInfo.InvariantCulture);
            tbxChange.Text = "$" + (Convert.ToDouble(tbxBalance.Text.Replace("$", "")) - Convert.ToDouble(tbxTotal.Text.Replace("$", ""))).ToString();*/
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
