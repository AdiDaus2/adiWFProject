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
    public partial class workerForm : Form
    {
        public workerForm()
        {
            InitializeComponent();
        }

        private void workerForm_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = DbMain.GetAllRecord("worker").Tables[0];
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
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Worker editCustomers = new Worker();
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
                editCustomers.StartDate = textBox7.Text;


                DialogResult result = System.Windows.Forms.DialogResult.OK;
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    editCustomers.Insert();
                    MessageBox.Show("Worker Data Updated Successfully");
                    dataGridView1.DataSource = DbMain.GetAllRecord("worker").Tables[0];


                }
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        private DataRow GetSelectedRow()
        {//-dataGrid מחזירה את השורה הנבחרת ב


            DataTable dt = null;
            if (dataGridView1.DataSource is DataTable)
                dt = dataGridView1.DataSource as DataTable;
            else if (dataGridView1.DataSource is BindingSource)
                dt = ((DataSet)((BindingSource)dataGridView1.DataSource).DataSource).Tables[0];
            else
                return null;

            return dt.Rows[this.dataGridView1.CurrentRow.Index];

        }

        private void button4_Click(object sender, EventArgs e)
        {//מחיקה
            DataRow dr = GetSelectedRow();
            if (dr == null)
                return;
            Worker db = new Worker();
            if (MessageBox.Show("למחוק את הרשומה?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                db.Delete(Convert.ToInt32(dr["workerID"]));

            }
            dataGridView1.DataSource = DbMain.GetAllRecord("worker").Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //קולט ת.ז לקוח ומחזיר את נתוניו 
            Worker db = new Worker();
            int id = int.Parse(textBox9.Text);

            if (db.Found(id) != true)
            {


                MessageBox.Show(("לא נמצא לקוח בעל מספר זה") + " " + id);

               
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
