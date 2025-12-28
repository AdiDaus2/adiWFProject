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
    public partial class books : Form
    {
        public books()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Item editItem = new Item();
            if (textBox6.Text == "" || textBox3.Text == "" || comboBox3.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("מלא את השדות");
            }
           
            else
            {

                
                editItem.ItemName = textBox3.Text;
                editItem.Quantity = int.Parse(numericUpDown1.Text);
                editItem.ItemPrice =int.Parse(textBox6.Text);
                
                editItem.Ganre = comboBox2.Text;
                editItem.PublisherId = int.Parse(comboBox3.Text);
                editItem.Language = comboBox1.Text;


                DialogResult result = System.Windows.Forms.DialogResult.OK;
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    editItem.Insert();
                    MessageBox.Show("item Data Updated Successfully");
                    dataGridView1.DataSource = DbMain.GetAllRecord("item").Tables[0];


                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataRow dr = GetSelectedRow();
            if (dr == null)
                return;
            Item db = new Item();
            if (MessageBox.Show("למחוק את הרשומה?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                db.Delete(Convert.ToInt32(dr["itemID"]));

            }
            dataGridView1.DataSource = DbMain.GetAllRecord("item").Tables[0];
        }
        private DataRow GetSelectedRow()
        {


            DataTable dt = null;
            if (dataGridView1.DataSource is DataTable)
                dt = dataGridView1.DataSource as DataTable;
            else if (dataGridView1.DataSource is BindingSource)
                dt = ((DataSet)((BindingSource)dataGridView1.DataSource).DataSource).Tables[0];
            else
                return null;

            return dt.Rows[this.dataGridView1.CurrentRow.Index];

        }
        private void books_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DbMain.GetAllRecord("item").Tables[0];
            comboBox3.DataSource = DbMain.GetAllRecord("item").Tables[0];//fill comboplier").Tables[0];//fill combo
            comboBox3.ValueMember = "itemID";//שם הטור שיוצג

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Item db = new Item();
            int id = int.Parse(textBox9.Text);

            if (db.Found(id) != true)
            {


                MessageBox.Show(("לא נמצא פריט בעל מספר זה") + " " + id);

                //dataGridView1.DataSource = db.GetCustomersinfo(t.ClientId).Tables[0];
            }
            else
            {
                DataTable ds = db.GetInfoByIdKey(id).Tables[0];

                
                textBox3.Text = ds.Rows[0]["itemName"].ToString();
                numericUpDown1.Text = ds.Rows[0]["quantity"].ToString();
                
                textBox6.Text = ds.Rows[0]["price"].ToString();
                comboBox2.Text = ds.Rows[0]["lang"].ToString();
                comboBox3.Text = ds.Rows[0]["supplierID"].ToString();
                comboBox1.Text = ds.Rows[0]["ganre"].ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item editItem = new Item();
            editItem.ItemCode =int.Parse(textBox9.Text);
            editItem.ItemName = textBox3.Text;
            editItem.Quantity = int.Parse(numericUpDown1.Text);
            editItem.ItemPrice = int.Parse(textBox6.Text);

            editItem.Ganre = comboBox1.Text;
            editItem.PublisherId = int.Parse(comboBox3.Text);
            editItem.Language = comboBox2.Text; ;


            DialogResult result = System.Windows.Forms.DialogResult.OK;
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                editItem.Update();
                MessageBox.Show("update item");
                dataGridView1.DataSource = DbMain.GetAllRecord("item").Tables[0];

            }
        }
    }
}
