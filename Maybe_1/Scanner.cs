using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

using System.Resources;
using System.Globalization;

namespace Maybe_1
{
    public partial class frmScanner : Form
    {
        public static frmMain frmMain = new frmMain();
        public static frmPayNow frmPayNow = new frmPayNow();
        public static double gross = 0;
        public static double total = 0;
        public static double discount = 0;

        public static void update()
        {
            string output = gross.ToString("#.00", CultureInfo.InvariantCulture);
            frmMain.tbxGross.Text = "$" + output;

            double HST = gross / 100 * 13;
            output = HST.ToString("#.00", CultureInfo.InvariantCulture);
            frmMain.tbxHST.Text = "$" + output;

            total = gross + HST;
            output = total.ToString("#.00", CultureInfo.InvariantCulture);
            frmMain.tbxTotal.Text = "$" + (gross+(gross/100*13)-gross*(frmDiscount.discount/100)).ToString("#.00",CultureInfo.InvariantCulture);

            frmMain.tbxDiscount.Text = frmDiscount.discount.ToString() + "%";

        }


        //Description, Item number, quantity, price
        public static List<double> receiptnumbers = new List<double>();
        public static List<string> receiptstrings = new List<string>();
        public void scan(string itemnumber, string description, double price)
        {
            Label label = new Label();
            for (int i = 0; i <= 4; i++)
            {
                string text = "";
                if (i == 0) //Should be for quantity but dynamic textboxes are hard
                {
                    text = "1";
                    receiptstrings.Add(description);

                }
                else if (i == 1)
                {
                    text = itemnumber;
                    receiptstrings.Add(itemnumber);
                }
                else if (i == 2)
                {
                    text = description;
                }
                else if (i == 3)
                {
                    text = price.ToString();
                    receiptnumbers.Add(1);
                }
                else
                {
                    text = price.ToString();
                    receiptnumbers.Add(price);
                }

                if (i == 0)
                {
                    frmMain.tblpMain.Controls.Add(new TextBox { Text = "1", Width = 60, TextAlign = HorizontalAlignment.Right, Font = new Font(label.Font.FontFamily, 14), TabStop = false});
                }
                else
                {
                    frmMain.tblpMain.Controls.Add(new Label { Text = text, Font = new Font(label.Font.FontFamily, 14), AutoSize = true, TextAlign = ContentAlignment.MiddleRight });
                }
            }
            label.Dispose();

            gross += price;
            update();
            
        }






        public frmScanner()
        {
            InitializeComponent();
        }


        private void frmScanner_Load(object sender, EventArgs e)
        {
            frmMain.Show();
        }

        private void btnSkates_Click(object sender, EventArgs e)
        {
            /*Label label = new Label();
            label.Font = new Font(label.Font.FontFamily, 14);
            frmMain.tblpMain.Controls.Add(new Label { Text = "aaaaaaaaaa", Anchor = AnchorStyles.Left, AutoSize = true}, 0, 0);
            frmMain.tblpMain.Controls.Add(new Label { Text = "1", Anchor = AnchorStyles.Left, AutoSize = true }, 0, 0);
            */
            scan("1053055", "Bauer Nexus 2N Senior Hockey Skates", 699.99);
        }


        public static double new_value = 0;
        private void btnGiftCard_Click(object sender, EventArgs e)
        {
            string current = frmMain.tbxBalance.Text.Replace("$","");
            new_value = Convert.ToDouble(current);
            new_value += 25;
            frmMain.tbxBalance.Text = "$" + new_value + ".00";
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            update();
            tmrUpdate.Enabled = false;
        }

        private void btnWomensShoes_Click(object sender, EventArgs e)
        {
            scan("1012A460","Asics GT-1000 8 Women's Running Shoes", 139.99);
        }

        private void btnHockeyMask_Click(object sender, EventArgs e)
        {
            scan("1037080","BAUER 2100 Senior Hockey Facemask",22.99);
        }

        private void btnHockeyGloves_Click(object sender, EventArgs e)
        {
            scan("1046518", "Bauer Nexus Prodigy Youth Hockey Gloves",29.99);
        }

        private void btnLanyard_Click(object sender, EventArgs e)
        {
            scan("100", "Fox 40 Breakaway Lanyard", 1.99);
        }
    }
}
