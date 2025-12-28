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
    public partial class receipt : Form
    {
        int Id;
        public receipt( int saleId)
        {
            InitializeComponent();
            Id = saleId;
        }

        private void receipt_Load(object sender, EventArgs e)
        {
            label10.Text= DateTime.Now.ToString();
            SaleDetails db = new SaleDetails();

            string s = "SELECT * from salesDetailsAndItem where salesDetailsID= " + Id;
            DataTable dt = DbMain.GetQuery(s).Tables[0];

            dataGridView1.ColumnCount = 4;

            dataGridView1.Columns[0].HeaderText = "מספר פריט";
            dataGridView1.Columns[1].HeaderText = "שם פריט";
                        
            dataGridView1.Columns[2].HeaderText = "גודל";
            
            
            dataGridView1.Columns[3].HeaderText = "מחיר";
            int i = 0;
            int sum = 0;
            string[] row=new string[4] ;
            while (i < dt.Rows.Count)
            {
                dataGridView1.Rows.Add(dt.Rows[i]["itemID"].ToString(), dt.Rows[i]["itemName"], dt.Rows[i]["amount"].ToString(), dt.Rows[i]["price"].ToString());
                sum += int.Parse(dt.Rows[i]["price"].ToString());
                i++;
               
            }


            label4.Text = dataGridView1.Rows.Count.ToString();
            label1.Text = sum.ToString();


            for ( i = 1; i <= 31; i++)
            {
                comboBox1.Items.Add(i);
            }

            for ( i = DateTime.Now.Year; i < DateTime.Now.Year+11; i++)
            {
                comboBox2.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }
    }
}
