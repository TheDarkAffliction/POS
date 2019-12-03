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
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        //public static string gross = frmScanner.frmMain.tbxGross.Text;
        //public static string hst = frmScanner.frmMain.tbxHST.Text;
        //public static string total = frmScanner.frmMain.tbxTotal.Text;
        private void btnNext_Click(object sender, EventArgs e)
        {
            //gross = frmScanner.frmMain.tbxGross.Text;
            //hst = frmScanner.frmMain.tbxHST.Text;
            //total = frmScanner.frmMain.tbxTotal.Text;

            this.Hide();

            tbxEmail.Text = "";

            if(ckbxPrint.Checked)
            {
                frmReceipt frmReceipt = new frmReceipt();
                frmReceipt.Show();
            }


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
