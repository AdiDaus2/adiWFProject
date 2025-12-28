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

namespace adiWFProject
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bookID_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("תמלא כבר!");
            }
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

        private void add_Click(object sender, EventArgs e)
        {
            Customer editCustomers = new Customer();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Fill in all the fields");
            }
            else if (!(emailIsValid(textBox7.Text)))
            {
                MessageBox.Show(" example@gmail.com :אימייל חייב להיות בתבנית ");
            }

            else
            {

                editCustomers.PersonId = Convert.ToInt32(textBox1.Text);
                editCustomers.PersonLastName = textBox2.Text;
                editCustomers.PersonFirstName = textBox3.Text;
                editCustomers.PersonAddress = textBox5.Text;
                editCustomers.PersonPhoneNum = textBox4.Text;
                editCustomers.PersonCity = textBox6.Text;
                editCustomers.PersonEmail = textBox7.Text;
                editCustomers.CustomerDbMonth = Convert.ToInt32(comboBox1.Text);

                DialogResult result = System.Windows.Forms.DialogResult.OK;
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    editCustomers.Insert();
                    MessageBox.Show("Customer Data Updated Successfully");
                    dataGridView1.DataSource = DbMain.GetAllRecord("pupil").Tables[0];
                }
            }
    }

        private void CANCEL_Click(object sender, EventArgs e)
        {
                DataRow dr = GetSelectedRow();
                if (dr == null)
                    return;
                Customer db = new Customer();
                if (MessageBox.Show("למחוק את הרשומה?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    db.Delete(Convert.ToInt32(dr["pupilID"]));

                }
                dataGridView1.DataSource = DbMain.GetAllRecord("customer").Tables[0];
            }

        private void update_Click(object sender, EventArgs e)
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {

        }
    }
    }
