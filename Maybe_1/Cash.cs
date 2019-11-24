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
    public partial class frmCash : Form
    {

        public static double total = 0;

        public frmCash()
        {
            InitializeComponent();
        }

        void update()
        {
            if (total.ToString().Length == 1)
            {
                tbxTotal.Text = "$" + "0.0" + total;
            }
            else if (total.ToString().Length == 2)
            {

                tbxTotal.Text = "$" + "0." + total;
            }
            else
            {
                string final = "$";
                char[] temp = total.ToString().ToCharArray();
                int x = 0;
                while(x != temp.Length - 2)
                {
                    final += temp[x];
                    x++;
                }
                final += "." + temp[temp.Length - 2] + temp[temp.Length - 1];
                tbxTotal.Text = final;
            }
        }

        


        private void btnZero_Click(object sender, EventArgs e)
        {
            total *= 10;
            update();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            total *= 10;
            total += 1;
            update();
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            total *= 10;
            total += 2;
            update();
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            total *= 10;
            total += 3;
            update();
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            total *= 10;
            total += 4;
            update();
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            total *= 10;
            total += 5;
            update();
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            total *= 10;
            total += 6;
            update();
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            total *= 10;
            total += 7;
            update();
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            total *= 10;
            total += 8;
            update();
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            total *= 10;
            total += 9;
            update();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(total.ToString().Length > 1)
            {
                total = Math.Floor(total/10);
            }
            else
            {
                total = 0;
            }
            update();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        { 
            frmMain.frmPayNow.update_cash();
            this.Close();
        }

        private void frmCash_Load(object sender, EventArgs e)
        {
            total = 0;
        }

        private void tbxTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
