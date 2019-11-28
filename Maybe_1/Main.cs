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
    public partial class frmMain : Form
    {

        public static class Globals
        {
            
        }

        public static frmPayNow frmPayNow = new frmPayNow();
        public static frmDiscount frmDiscount = new frmDiscount();
        public static frmFlags frmFlags = new frmFlags();
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

            if (frmLogin.admin)
            {
                tbxName.Text = frmLogin.Globals.adminFirstNames[frmLogin.location] + " " + frmLogin.Globals.adminLastNames[frmLogin.location];
            }
            else
            {
                tbxName.Text = frmLogin.Globals.firstNames[frmLogin.location] + " " + frmLogin.Globals.lastNames[frmLogin.location];
            }

            tbxTill.Text = frmLogin.Globals.tillNo[0];
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            frmPayNow.tbxTotal.Text = "$" + (frmScanner.gross + (frmScanner.gross / 100 * 13) - frmScanner.gross * (frmDiscount.discount / 100)).ToString("#.00", CultureInfo.InvariantCulture);
            frmPayNow.tbxBalance.Text = "$" + frmScanner.new_value;
            frmPayNow.Show();
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
            frmDiscount.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tblpMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFlags_Click(object sender, EventArgs e)
        {
            frmFlags.Show();
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            tbxTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void tbxDiscount_DoubleClick(object sender, EventArgs e)
        {
            frmDiscount.Show();
        }

        private void btnPreset1_Click(object sender, EventArgs e)
        {
            frmScanner.scan(" ", "Skate Sharpening", 5.99);
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            frmScanner.frmMain.btnPayNow.Focus();
        }
    }
}
