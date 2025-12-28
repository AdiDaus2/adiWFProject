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
    public partial class datagridTest : Form
    {
        public datagridTest()
        {
            InitializeComponent();
        }

        private void datagridTest_Load(object sender, EventArgs e)
        {
           
            // מילוי data grid
            dataGridView1.DataSource = DbMain.GetAllRecord("customers").Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // dataGridView1.Rows.Clear();
            MessageBox.Show(dataGridView1.CurrentCell.Value.ToString());//return value of current cell 
           // dataGridView1.Rows.GetRowCount();
        }
    }
}
