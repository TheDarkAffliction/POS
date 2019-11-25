using System;
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
        public frmPayNow()
        {
            InitializeComponent();
        }

        public void update_cash()
        {
           double var1 = Convert.ToDouble(frmMain.frmPayNow.tbxBalance.Text.Replace("$", ""));
            Console.WriteLine(var1);
           tbxBalance.Text = "$" + ((frmCash.total / 100) + var1).ToString("#.00", CultureInfo.InvariantCulture);
           if(((frmCash.total / 100) + var1) >= Convert.ToDouble(frmMain.frmPayNow.tbxTotal.Text.Replace("$","")))
            {
                frmPayment.Show();
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
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            frmDebit.Show();
        }
    }
}
