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
    public partial class frmPayNow : Form
    {
        public static frmPayment frmPayment = new frmPayment();
        public static frmCash frmCash = new frmCash();
        public static frmDebit frmDebit = new frmDebit();

        public static string type = "";

        public frmPayNow()
        {
            InitializeComponent();
        }

        public void update_cash()
        {
           double var1 = Convert.ToDouble(frmMain.frmPayNow.tbxBalance.Text.Replace("$", ""));
           tbxBalance.Text = "$" + ((frmCash.total / 100) + var1).ToString("#.00", CultureInfo.InvariantCulture);
           if(((frmCash.total / 100) + var1) >= Convert.ToDouble(frmMain.frmPayNow.tbxTotal.Text.Replace("$","")))
            {
                frmPayment.Show();
                frmPayment.tbxTotal.Text = frmMain.frmPayNow.tbxTotal.Text;
                frmPayment.tbxBalance.Text = frmMain.frmPayNow.tbxBalance.Text;
                frmPayment.tbxChange.Text = "$" + (Convert.ToDouble(frmMain.frmPayNow.tbxBalance.Text.Replace("$", "")) - Convert.ToDouble(frmMain.frmPayNow.tbxTotal.Text.Replace("$", ""))).ToString("#.00", CultureInfo.InvariantCulture);
                if(frmPayment.tbxChange.Text[1] == '.')
                {
                    frmPayment.tbxChange.Text = frmPayment.tbxChange.Text.Insert(1, "0");
                }
                type = "CASH";
            }
           if(tbxBalance.Text == "$0" || tbxBalance.Text == "$.00") { tbxBalance.Text = "$0.00";  }
           if (tbxTotal.Text == "$.00") { tbxTotal.Text = "$0.00"; }
        }

        public void update_debit()
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmPayNow_Load(object sender, EventArgs e)
        {
            tbxTotal.Text = "$" + (frmScanner.gross + (frmScanner.gross / 100 * 13) - frmScanner.gross * (frmDiscount.discount / 100)).ToString("#.00", CultureInfo.InvariantCulture);
            tbxBalance.Text = "$" + frmScanner.new_value;
            if (tbxBalance.Text == "$0") { tbxBalance.Text = "$0.00"; }
            if (tbxTotal.Text == "$.00") { tbxTotal.Text = "$0.00"; }

        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            frmCash.total = 0;
            frmCash.tbxTotal.Text = "$0.00";
            frmCash.Show();
        }

        private void btnDebit_Click(object sender, EventArgs e)
        {
            frmDebit.Show();
            type = "DEBIT";
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            frmDebit.Show();
            frmDebit.Text = "Credit";
            type = "CREDIT";
        }
    }
}
