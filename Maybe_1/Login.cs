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

namespace Maybe_1
{
    public partial class frmLogin : Form
    {

        public static frmScanner frmScanner = new frmScanner();
        public static frmAdmin frmAdmin = new frmAdmin();
        public static class Globals
        {
            //Till Number
            private static string tillNoFile = Properties.Resources.tillNo;
            public static List<string> tillNo = tillNoFile.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();


            //Names and ID
            private static string idFile = Properties.Resources.ID;
            private static string adminIDFile = Properties.Resources.AdminID;
            private static string firstNameFile = Properties.Resources.FirstNames;
            private static string adminFirstNameFile = Properties.Resources.AdminFirstNames;
            private static string lastNameFile = Properties.Resources.LastNames;
            private static string adminLastNameFile = Properties.Resources.AdminLastNames;

            public static List<string> ID = idFile.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            public static List<string> adminID = adminIDFile.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();

            public static List<string> firstNames = firstNameFile.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            public static List<string> adminFirstNames = adminFirstNameFile.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();

            public static List<string> lastNames = lastNameFile.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            public static List<string> adminLastNames = adminLastNameFile.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        public static int location = 0;
        public static bool admin = false;


        public frmLogin()
        {
            InitializeComponent();
        }

        private void tbxEnterID_TextChanged(object sender, EventArgs e)
        {
            if (Globals.ID.Contains(tbxEnterID.Text))
            {
                frmScanner.Show();
                location = Globals.ID.FindIndex(x => x == tbxEnterID.Text);
                this.Close();

            }
            else if (Globals.adminID.Contains(tbxEnterID.Text))
            {
                frmAdmin.Show();
                location = Globals.adminID.FindIndex(x => x == tbxEnterID.Text);
                admin = true;
                this.Close();
            }                               
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
