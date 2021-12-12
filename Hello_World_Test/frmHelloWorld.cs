using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World_Test
{
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent();
        }

        private void frmHelloWorld_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Enter your first and last name and click submit", "Informational", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You entered " + txtFirstName.Text + " " + txtLastName.Text, "Informational", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
