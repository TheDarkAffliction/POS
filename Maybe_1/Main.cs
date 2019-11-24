using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing;

namespace Maybe_1
{
    public partial class frmMain : Form
    {

        public static class Globals
        {
            
        }




        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            tbxDate.Text = thisDay.ToString("d");

            if(frmLogin.admin)
            {
                tbxName.Text = frmLogin.Globals.adminFirstNames[frmLogin.location] + " " + frmLogin.Globals.adminLastNames[frmLogin.location];
            }
            else
            {
                tbxName.Text = frmLogin.Globals.firstNames[frmLogin.location] + " " + frmLogin.Globals.lastNames[frmLogin.location];
            }

            tbxTill.Text = frmLogin.Globals.tillNo[0];

        }

        public static frmPayNow frmPayNow = new frmPayNow();
        private void btnPayNow_Click(object sender, EventArgs e)
        {
            frmPayNow.Show();
        }

        private void btnCurrentDeals_Click(object sender, EventArgs e)
        {

        }

        private void tmrLoad_Tick(object sender, EventArgs e)
        {
            Graphics formGraphics;
            Pen pen = new Pen(Color.Black, 4);
            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(pen, 50, 260, 1327, 500);
            formGraphics.DrawRectangle(pen, 50, 225, 1327, 35);
            pen.Dispose();
            formGraphics.Dispose();
            //tmrLoad.Enabled = false;
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            new frmDiscount().Show();
        }
    }
}
