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
    public partial class frmReceipt : Form
    {
        public frmReceipt()
        {
            InitializeComponent();
        }

        public struct Data
        {
            public Data(int intValue, string strValue)
            {
                IntegerData = intValue;
                StringData = strValue;
            }

            public int IntegerData { get; private set; }
            public string StringData { get; private set; }
        }


        int y = 282;
        List<Data> data = new List<Data>();
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
                        Console.WriteLine("YEET");
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
            y -= 30;
            tmrDraw2.Enabled = true;
            y += 15;

            /*
            //Set money labels
            lblSetMerchTotal.Location = new Point(lblSetMerchTotal.Left, y);
            lblMerchTotal.Location = new Point(lblMerchTotal.Left, y);
            //lblMerchTotal.Text = frmPayment.gross;
            lblSetMerchTotal.Visible = true;
            lblMerchTotal.Visible = true;
            y += 15;
            a
            lblSetHST.Location = new Point(lblSetHST.Left, y);
            lblHST.Location = new Point(lblSetHST.Left, y);
            lblHST.Text += frmScanner.frmMain.tbxHST.Text;
            y += 15;

            lblSetType.Location = new Point(lblSetType.Left, y);
            lblType.Location = new Point(lblSetType.Left, y);
            if (frmPayNow.type == "DEBIT")
            {
                lblSetType.Text = "Debit";
            }
            else if (frmPayNow.type == "CREDIT")
            {
                lblSetType.Text = "Credit";
            }
            else
            {
                lblSetType.Text = "Cash";
                y += 15;
                
            }
            y += 15;*/
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

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void tmrDraw2_Tick(object sender, EventArgs e)
        {
            Graphics formGraphics;
            Pen pen = new Pen(Color.Black, 4);
            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(pen, 0, y, 300, 1);
            pen.Dispose();
            formGraphics.Dispose();
            tmrDraw2.Enabled = false;
        }
    }
}
