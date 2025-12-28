using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication2
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        
              

       
        public static bool emailIsValid(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        


        private void CustomersForm_Load(object sender, EventArgs e)
        {
            Item Db1 = new Item();
             
           // מילוי data grid
            dataGridView1.DataSource = DbMain.GetAllRecord("customer").Tables[0];
            //מילוי תיבת רשימה
            
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            //קולט ת.ז לקוח ומחזיר את נתוניו 
            Customer db = new Customer();
            int id = int.Parse(textBox9.Text);
          
            if (db.Found(id) != true)
            {


                MessageBox.Show(("לא נמצא לקוח בעל מספר זה") + " " + id);

               //dataGridView1.DataSource = db.GetCustomersinfo(t.ClientId).Tables[0];
            }
            else
            {
                DataTable ds = db.GetInfoByIdKey(id).Tables[0];

                textBox1.Text = ds.Rows[0]["customerId"].ToString();
                textBox6.Text = ds.Rows[0]["customerLastName"].ToString();
                textBox8.Text = ds.Rows[0]["customerFirstName"].ToString();
                textBox2.Text = ds.Rows[0]["customerAddress"].ToString();
                textBox3.Text = ds.Rows[0]["customerPhoneNum"].ToString();
                textBox4.Text = ds.Rows[0]["customerCity"].ToString();
                textBox5.Text = ds.Rows[0]["customerEmail"].ToString();
                comboBox1.Text = ds.Rows[0]["customerDbMonth"].ToString();
               
            }
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Customer editCustomers = new Customer();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Fill in all the fields");
            }
            else if (!(emailIsValid(textBox5.Text)))
            {
                MessageBox.Show(" example@something.com :אימייל חייב להיות בתבנית ");
            }

            else
            {

                editCustomers.PersonId = Convert.ToInt32(textBox1.Text);
                editCustomers.PersonLastName = textBox6.Text;
                editCustomers.PersonFirstName = textBox8.Text;
                editCustomers.PersonAddress = textBox2.Text;
                editCustomers.PersonPhoneNum = textBox3.Text;
                editCustomers.PersonCity = textBox4.Text;
                editCustomers.PersonEmail = textBox5.Text;
                editCustomers.CustomerDbMonth = Convert.ToInt32(comboBox1.Text);
                           
                
                DialogResult result = System.Windows.Forms.DialogResult.OK;
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    editCustomers.Insert();
                    MessageBox.Show("Customer Data Updated Successfully");
                    dataGridView1.DataSource = DbMain.GetAllRecord("customer").Tables[0];


                }
            }

        }

        

        private void buttonDelet_Click_1(object sender, EventArgs e)
        {
            DataRow dr = GetSelectedRow();
            if (dr == null)
                return;
            Customer db = new Customer();
            if (MessageBox.Show("למחוק את הרשומה?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                db.Delete(Convert.ToInt32(dr["customerID"]));

            }
            dataGridView1.DataSource = DbMain.GetAllRecord("customer").Tables[0];
        }

       

        private void updateButton_Click(object sender, EventArgs e)
        {
            Customer editCustomers = new Customer();
            editCustomers.PersonId = Convert.ToInt32(textBox1.Text);

            editCustomers.PersonLastName = textBox6.Text;
            editCustomers.PersonFirstName = textBox8.Text;

            editCustomers.PersonAddress = textBox2.Text;


            editCustomers.PersonPhoneNum = textBox3.Text;
            editCustomers.PersonCity = textBox4.Text;
            editCustomers.PersonEmail = textBox5.Text;
            editCustomers.CustomerDbMonth = Convert.ToInt32(comboBox1.Text);
          //  editCustomers.EntryDate = "";


            DialogResult result = System.Windows.Forms.DialogResult.OK;
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                editCustomers.Update();
                MessageBox.Show("update Customer");
                dataGridView1.DataSource = DbMain.GetAllRecord("Customer").Tables[0];

            }
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

        
      

    }

