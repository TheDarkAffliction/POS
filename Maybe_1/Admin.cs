﻿using System;
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
    public partial class frmAdmin : Form
    {
        public static frmAddID frmAddID = new frmAddID();
        public static frmAdminSettings frmAdminSettings = new frmAdminSettings();
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnAddID_Click(object sender, EventArgs e)
        {
            frmAddID.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }
        private void btnSettings_Click(object sender, EventArgs e)
        { 
            frmAdminSettings.Show();
            this.Hide();
        }
    }
}
