using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            frmPayNow.frmPayment.Show();
            frmPayNow.frmPayment.tbxBalance.Text = frmPayNow.frmPayment.tbxTotal.Text;
            frmPayNow.frmPayment.tbxChange.Text = "$0.00";
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
