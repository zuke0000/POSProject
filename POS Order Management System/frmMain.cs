using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Order_Management_System
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new Checkout();
            newForm.Show();
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            var newForm = new Employees();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newForm = new Sales();
            newForm.Show();
        }
    }
}
