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
    public partial class frmReceipt : Form
    {
        public frmReceipt()
        {
            InitializeComponent();
        }


        int y = 282;
        private void Receipt_Load(object sender, EventArgs e)
        {
            //Time
            lblDate.Text = DateTime.Now.ToString();

            //Update sales info
            Random random = new Random();
            for (int i = 0; i < 10; i++) //Randomly generated ticket number
            {
                lblTicket.Text += random.Next(0, 10).ToString();
            }

            if (frmLogin.admin) //Adds cashier's name
            {
                lblPerson.Text += frmLogin.Globals.adminFirstNames[frmLogin.location] + frmLogin.Globals.adminLastNames[frmLogin.location];
            }
            else
            {
                lblPerson.Text += frmLogin.Globals.firstNames[frmLogin.location] + " " + frmLogin.Globals.lastNames[frmLogin.location];
            }

            //Desription, Item number, quantity, price
            //Initial Location = 12, 282
            int x = 12;
            //int y = 282;
            int counter = 0;
            int stringcounter = 0;
            int numbercounter = 0;
            for (int i = 0; i < (frmScanner.receiptnumbers.Count + frmScanner.receiptstrings.Count); i++)
            {
                Label label = new Label();
                label.AutoSize = true;
                if ((counter == 0 || counter == 1) && (stringcounter != frmScanner.receiptstrings.Count))
                {
                    if(counter == 0)
                    {
                        label.Text = frmScanner.receiptstrings[stringcounter];
                    }
                    else
                    {
                        label.Text = "Item ID:   " + frmScanner.receiptstrings[stringcounter];
                    }
                    stringcounter += 1;
                }
                else if ((counter == 2 || counter == 3) && (numbercounter != frmScanner.receiptnumbers.Count))
                {
                    if(counter == 2)
                    {
                        label.Text = "Quantity: " + frmScanner.receiptnumbers[numbercounter].ToString() + "   x   " + frmScanner.receiptnumbers[numbercounter + 1];
                    }
                    numbercounter += 1;
                }
                //Console.WriteLine(counter);
                //Console.WriteLine(stringcounter);
                if(counter == 3)
                {
                    counter = 0;
                    y += 20;
                }
                else
                {
                    label.Location = new Point(x, y);
                    y += 15;
                    label.Font = new Font(Font.FontFamily, 8);
                    Controls.Add(label);
                    counter += 1;
                }
            }
            y -= 15;
            tmrDraw2.Enabled = true;
            //New y variable because drawing with the timer is spooky
            int y2 = y + 10;
            
            //Set money labels
            lblSetMerchTotal.Location = new Point(lblSetMerchTotal.Left, y2);
            lblMerchTotal.Location = new Point(lblMerchTotal.Left, y2);
            lblMerchTotal.Text += frmScanner.gross.ToString();
            y2 += 15;
            lblSetHST.Location = new Point(lblSetHST.Left, y2);
            lblHST.Location = new Point(lblHST.Left, y2);
            lblHST.Text += frmScanner.frmMain.tbxHST.Text;
            y2 += 15;
            lblSetTotal.Location = new Point(lblSetTotal.Left, y2);
            lblTotal.Location = new Point(lblTotal.Left, y2);
            lblTotal.Text += (Convert.ToDouble(lblHST.Text.Replace("$", "")) + Convert.ToDouble(lblMerchTotal.Text.Replace("$", ""))).ToString();
            y2 += 25;
            lblSetType.Location = new Point(lblSetType.Left, y2);
            lblType.Location = new Point(lblType.Left, y2);

            if (frmPayNow.type == "DEBIT")
            {
                lblSetType.Text = "Debit";
                lblType.Text = lblTotal.Text;
            }
            else if (frmPayNow.type == "CREDIT")
            {
                lblSetType.Text = "Credit";
                lblType.Text = lblTotal.Text;
            }
            else
            {
                
                lblSetType.Text = "Cash";
                lblType.Text = frmPayNow.frmPayment.tbxBalance.Text;
                lblSetChange.Visible = true;
                lblChange.Visible = true;
                lblChange.Text = "$" + (Convert.ToDouble(lblType.Text.Replace("$", "")) - Convert.ToDouble(lblTotal.Text.Replace("$", ""))).ToString("#.00", CultureInfo.InvariantCulture);
                lblSetChange.Location = new Point(lblSetChange.Left, y2+15);
                lblChange.Location = new Point(lblChange.Left, y2+15);
            }
            y2 += 80;
            lblEnd.Location = new Point(lblEnd.Left, y2);

            this.Height = y2 + 160;

            //Reset everything
            frmMain.frmPayNow.Hide();
            frmMain.frmDiscount.Hide();
            frmScanner.frmMain.tblpMain.Controls.Clear();
            frmScanner.total = 0;
            frmScanner.discount = 0;
            frmScanner.gross = 0;
            frmDiscount.discount = 0;
            frmScanner.new_value = 0;

            frmPayNow.frmPayment.tbxBalance.Text = "$0.00";
            frmPayNow.frmPayment.tbxTotal.Text = "$0.00";
            frmPayNow.frmPayment.tbxTotal.Text = "$0.00";

            frmScanner.update();

            frmScanner.frmMain.tbxBalance.Text = "$0.00";
            frmScanner.frmMain.tbxGross.Text = "$0.00";
            frmScanner.frmMain.tbxHST.Text = "$0.00";
            frmScanner.frmMain.tbxTotal.Text = "$0.00";

        }

        private void tmrDraw_Tick(object sender, EventArgs e)
        {
            Graphics formGraphics;
            Pen pen = new Pen(Color.Black, 4);
            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(pen, 0, 275, 300, 1);
            pen.Dispose();
            formGraphics.Dispose();
            tmrDraw.Enabled = false;
        }

        private void tmrDraw_Tick_1(object sender, EventArgs e)
        {
            Graphics formGraphics;
            Pen pen = new Pen(Color.Black, 4);
            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(pen, 0, 275, 300, 1);
            pen.Dispose();
            formGraphics.Dispose();
            tmrDraw.Enabled = false;
        }


        private void tmrDraw2_Tick(object sender, EventArgs e)
        {
            Graphics formGraphics;
            Pen pen2 = new Pen(Color.Black, 4);
            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(pen2, 0, y, 300, 1);
            pen2.Dispose();
            formGraphics.Dispose();
            tmrDraw2.Enabled = false;
        }
    }
}
