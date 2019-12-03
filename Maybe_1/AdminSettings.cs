using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Resources;
using System.IO;

namespace Maybe_1
{
    public partial class frmAdminSettings : Form
    {
        public static class Globals
        {
            public static string tillNoFile = Properties.Resources.tillNo;
            public static List<string> tillNo = tillNoFile.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        public frmAdminSettings()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin.frmAdmin.Show();
            this.Hide();
        }

        private void frmAdminSettings_Load(object sender, EventArgs e)
        {
            tbxTillNo.Text = Globals.tillNo[0];
        }

        private void tbxTillNo_TextChanged(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter(Properties.Resources.tillNo);
            txt.Write(tbxTillNo.Text);
            txt.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
