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
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Fill in all the fields");
            }
            else
            {
                DbCustomer Dbcustomers1 = new DbCustomer();
                Customers customers1 = new Customers();
                customers1.CustomerId = int.Parse(textBox1.Text);
                customers1.CustomerName = textBox6.Text;
                customers1.CustomerAddress = textBox2.Text;
                customers1.CustomerPhoneNum = int.Parse(textBox3.Text);
                customers1.CustomerCity = textBox4.Text;
                customers1.CustomerEmail = textBox5.Text;
                customers1.CustomerBDMonth = int.Parse(comboBox1.Text);

                if (Dbcustomers1.Found(customers1.CustomerId) == true)
                    MessageBox.Show("כבר קיים לקוח עם מספר זה");
                else if (!(emailIsValid(textBox5.Text)))
                {
                    MessageBox.Show(" example@something.com :אימייל חייב להיות בתבנית");
                }
                if (int.Parse(comboBox1.Text) > 12)
                {
                    MessageBox.Show("BDMonth does not exist");
                }
                else
                {
                    Dbcustomers1.insertCustomers(customers1);
                    //dataGridView1.DataSource = Dbcustomers1.GetAllCustomer("Customers").Tables[0];
                }
            }
        }


        private void CustomersForm_Load(object sender, EventArgs e)
        {
            DbCustomer Dbcustomer1 = new DbCustomer();
            dataGridView1.DataSource = Dbcustomer1.GetAllRecord("Customers").Tables[0];

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customers c = new Customers();
            c.CustomerId = int.Parse(textBox7.Text);
            DbCustomer db = new DbCustomer();
            if (db.Found(c.CustomerId) == false)
            {


                MessageBox.Show(("לא נמצא לקוח בעל מספר זה") + " " + c.CustomerId);

                //dataGridView1.DataSource = db.Searchclient(t.ClientId).Tables[0];
            }
            else
            {
                DataTable ds = db.GetCustomersinfo(c).Tables[0];

                textBox1.Text = ds.Rows[0]["customerId"].ToString();
                textBox6.Text = ds.Rows[0]["customerName"].ToString();
                textBox2.Text = ds.Rows[0]["customerAddress"].ToString();
                textBox3.Text = ds.Rows[0]["customerPhoneNum"].ToString();
                textBox4.Text = ds.Rows[0]["customerCity"].ToString();
                textBox5.Text = ds.Rows[0]["customerEmail"].ToString();
                comboBox1.Text = ds.Rows[0]["customerBDMonth"].ToString();
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

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
                DbCustomer db = new DbCustomer();
                Customers editCustomers = new Customers();

               
                editCustomers.CustomerId = Convert.ToInt32(textBox1.Text);
                editCustomers.CustomerName = textBox6.Text;
                editCustomers.CustomerAddress = textBox2.Text;
                editCustomers.CustomerPhoneNum = Convert.ToInt32(textBox3.Text);
                editCustomers.CustomerCity = textBox4.Text;
                editCustomers.CustomerEmail = textBox5.Text;
                editCustomers.CustomerBDMonth = Convert.ToInt32(comboBox1.Text);

                DialogResult result = System.Windows.Forms.DialogResult.OK;
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    db.updateCustomers(editCustomers);
                    MessageBox.Show("Customer Data Updated Successfully");
                    dataGridView1.DataSource = db.GetAllRecord("Customers").Tables[0];


                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataRow dr = GetSelectedRow();
            if (dr == null)
                return;
            DbCustomer db = new DbCustomer();
            if (MessageBox.Show(" ? למחוק את הרשומה", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
               // db.deleteCustomers(Convert.ToInt32(dr["customerId"]).ToString());
                dataGridView1.DataSource = db.GetAllRecord("Customers").Tables[0];
            }
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

        
      

    }
}
