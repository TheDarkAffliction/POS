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
    public partial class frmDebit : Form
    {
        public frmDebit()
        {
            InitializeComponent();
        }

        private void Debit_Load(object sender, EventArgs e)
        {

        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            frmPayNow.frmPayment.tbxBalance.Text = "$" + (frmScanner.gross + (frmScanner.gross / 100 * 13) - frmScanner.gross * (frmDiscount.discount / 100)).ToString("#.00", CultureInfo.InvariantCulture);
            frmPayNow.frmPayment.tbxTotal.Text = frmPayNow.frmPayment.tbxBalance.Text;
            frmPayNow.frmPayment.tbxChange.Text = "$0.00";
            frmPayNow.frmPayment.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
