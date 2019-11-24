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

        // Render text updates
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

        // This guy adds a number to the total
        private void numPressed(int inc)
        {
            total *= 10;
            total += inc;
            update();
        }

        private void delPressed()
        {
            if (total.ToString().Length > 1)
            {
                total = Math.Floor(total / 10);
            }
            else
            {
                total = 0;
            }
            update();
        }

        private void enterPressed()
        {
            frmMain.frmPayNow.update_cash();
            this.Hide();
        }

        // Button clicks
        private void btnZero_Click(object sender, EventArgs e) { numPressed(0); }
        private void btnOne_Click(object sender, EventArgs e) { numPressed(1); }
        private void btnTwo_Click(object sender, EventArgs e) { numPressed(2); }
        private void btnThree_Click(object sender, EventArgs e) { numPressed(3); }
        private void btnFour_Click(object sender, EventArgs e) { numPressed(4); }
        private void btnFive_Click(object sender, EventArgs e) { numPressed(5); }
        private void btnSix_Click(object sender, EventArgs e) { numPressed(6); }
        private void btnSeven_Click(object sender, EventArgs e) { numPressed(7); }
        private void btnEight_Click(object sender, EventArgs e) { numPressed(8); }
        private void btnNine_Click(object sender, EventArgs e) { numPressed(9); }

        private void btnDel_Click(object sender, EventArgs e)
        {
            delPressed();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            enterPressed();
        }

        private void frmCash_Load(object sender, EventArgs e)
        {
            total = 0;
        }

        private void frmCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void frmCash_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("YEET");
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0) { numPressed(0); }
            else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad2) { numPressed(1); }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad3) { numPressed(2); }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad4) { numPressed(3); }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad5) { numPressed(4); }
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad6) { numPressed(5); }
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad7) { numPressed(6); }
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad8) { numPressed(7); }
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad9) { numPressed(8); }
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad0) { numPressed(9); }

            else if (e.KeyCode == Keys.Enter)
            {
                enterPressed();
            }
            else if (e.KeyCode == Keys.Back)
            {
                delPressed();
            }

            else
            {
                Console.WriteLine("NONE");
            }
        }
    }
}
