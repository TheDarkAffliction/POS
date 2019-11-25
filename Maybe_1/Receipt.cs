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

        List<Data> data = new List<Data>();
        private void Receipt_Load(object sender, EventArgs e)
        {
            //Time
            lblDate.Text = DateTime.Now.ToString();


            //Desription, Item number, quantity, price
            //Initial Location = 12, 282
            int x = 12;
            int y = 282;
            int counter = 0;
            int stringcounter = 0;
            int numbercounter = 0;
            for (int i = 0; i < (frmScanner.receiptnumbers.Count + frmScanner.receiptstrings.Count); i++)
            {
                Label label = new Label();
                if ((counter == 0 || counter == 1) && (stringcounter != frmScanner.receiptstrings.Count))
                {
                    label.Text = frmScanner.receiptstrings[stringcounter];
                    stringcounter += 1;
                }
                else if ((counter == 2 || counter == 3) && (numbercounter != frmScanner.receiptnumbers.Count))
                {
                    label.Text = frmScanner.receiptnumbers[numbercounter].ToString();
                    numbercounter += 1;
                }
                if(counter == 3)
                {
                    counter = 0;
                }
                counter += 1;
                Console.WriteLine(label.Text);
                label.Location = new Point(x,y);
                y += 14;
                label.Font = new Font(Font.FontFamily, 10);
                Controls.Add(label);
                label.Dispose();
            }
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
    }
}
