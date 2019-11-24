using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

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



        public void scan(string itemnumber, string description, double price)
        {
            Label label = new Label();
            for (int i = 0; i <= 4; i++)
            {
                string text = "";
                if (i == 0)
                {
                    text = "1";
                }
                else if (i == 1)
                {
                    text = itemnumber;
                }
                else if (i == 2)
                {
                    text = description;
                }
                else
                {
                    text = price.ToString();
                }

                if (i == 0)
                {
                    frmMain.tblpMain.Controls.Add(new TextBox { Text = "1", Width = 60, TextAlign = HorizontalAlignment.Right, Font = new Font(label.Font.FontFamily, 14) });
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
            scan("ssssssss", "HS: Nexus 6000 SR Skates (L)", 110.99);
        }

        private void btnSoccerBall_Click(object sender, EventArgs e)
        {
            scan("sbsbsbsb", "Stewarts Soccer Ball", 21.99);
        }

        public static double new_value = 0;
        private void btnGiftCard_Click(object sender, EventArgs e)
        {
            string current = frmMain.tbxBalance.Text.Remove(0,1);
            new_value = Convert.ToDouble(current);
            new_value += 25;
            frmMain.tbxBalance.Text = "$" + new_value;
            
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            update();
            tmrUpdate.Enabled = false;
        }
    }
}
