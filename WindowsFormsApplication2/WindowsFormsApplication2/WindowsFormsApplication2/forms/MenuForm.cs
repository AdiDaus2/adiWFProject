using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class MenuForm : Form
    {
        string lastName1="";
        public MenuForm(string firstName, string lastName)
        {
            InitializeComponent();
            label1.Text = firstName;
            label2.Text = lastName;
            lastName1 = lastName;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void טופסמכירהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saleForm SForm = new saleForm();
            SForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomersForm customerItem = new CustomersForm();
            customerItem.Show();
        }

        private void רשימתמלאיToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductCatalog f = new ProductCatalog();
            f.Show();
        }

        private void MenuItemOrder_Click(object sender, EventArgs e)
        {
            buyingFromSupplier buyF = new buyingFromSupplier();
            buyF.Show();

        }

        private void מכירותבתקופתזמןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salesTimeFrame sTimeForm = new salesTimeFrame();
            sTimeForm.Show();
        }

        private void ספריםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            books b = new books();
            b.Show();
        }

        private void דוחותToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
