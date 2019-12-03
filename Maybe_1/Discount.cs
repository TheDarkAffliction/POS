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
    public partial class frmDiscount : Form
    {
        public frmDiscount()
        {
            InitializeComponent();
        }
        public static double discount = 0;


        public void btnEnter_Click(object sender, EventArgs e)
        {
            frmScanner.discount = frmScanner.gross - frmScanner.gross * (discount / 100);
            frmScanner.update();
            discount = 0;
            tbxPercent.Text = "0";
            this.Hide();
        }
        private void tbxPercent_KeyPress(object sender, KeyEventArgs e)
        {

        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            discount *= 10;
            tbxPercent.Text = discount.ToString();
        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            discount *= 10;
            discount += 1;
            tbxPercent.Text = discount.ToString();
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            discount *= 10;
            discount += 2;
            tbxPercent.Text = discount.ToString();
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            discount *= 10;
            discount += 3;
            tbxPercent.Text = discount.ToString();
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            discount *= 10;
            discount += 4;
            tbxPercent.Text = discount.ToString();
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            discount *= 10;
            discount += 5;
            tbxPercent.Text = discount.ToString();
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            discount *= 10;
            discount += 6;
            tbxPercent.Text = discount.ToString();
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            discount *= 10;
            discount += 7;
            tbxPercent.Text = discount.ToString();
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            discount *= 10;
            discount += 8;
            tbxPercent.Text = discount.ToString();
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            discount *= 10;
            discount += 9;
            tbxPercent.Text = discount.ToString();
        }

        private void frmDiscount_Load(object sender, EventArgs e)
        {
            discount = 0;
        }

        private void tbxPercent_TextChanged(object sender, EventArgs e)
        {
            string var = tbxPercent.Text.Replace("%", "");
            discount = Convert.ToDouble(var);
        }

        private void tbxPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                frmScanner.discount = frmScanner.gross - frmScanner.gross * (discount / 100);
                frmScanner.update();
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            discount = 0;
            this.Hide();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            discount /= 10;
            tbxPercent.Text = discount.ToString();
        }
    }
}
