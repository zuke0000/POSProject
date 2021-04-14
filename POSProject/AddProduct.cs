using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeeshopproject
{
    public partial class AddProduct : Form
    {


        public AddProduct()
        {
            InitializeComponent();

            /*cboCategory.DataSource = cse.TblProductType; // Correct table won't show up. Backtrack to part 2 video
            cboCategory.DisplayMember = "Description";
            cboCategory.ValueMember = "ProductType";*/ // Added code via other means, starts at line 33
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.TblProductType' table. You can move, or remove it, as needed.
            this.tblProductTypeTableAdapter.Fill(this.dataSet1.TblProductType);

        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblProductTypeTableAdapter.FillBy(this.dataSet1.TblProductType);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
