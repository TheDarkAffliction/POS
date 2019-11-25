using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Maybe_1
{
    public partial class frmAddID : Form
    {
        public frmAddID()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbxFirstName.Text = "";
            tbxLastName.Text = "";
            tbxID.Text = "";
            cbxAdmin.Checked = false;
        }
    }
}
