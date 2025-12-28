/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adiWFProject.Forms
{
    public partial class staffForm : Form
    {
        public staffForm()
        {
            InitializeComponent();
        }

        private void staffForm_Load(object sender, EventArgs e)
        {

        }
        private DataRow GetSelectedRow()
        {//-dataGrid מחזירה את השורה הנבחרת ב
            DataTable dt = null;
            if (dataGridView.DataSource is DataTable)
                dt = dataGridView.DataSource as DataTable;
            else if (dataGridView.DataSource is BindingSource)
                dt = ((DataSet)((BindingSource)dataGridView.DataSource).DataSource).Tables[0];
            else
                return null;

            return dt.Rows[this.dataGridView.CurrentRow.Index];
        }
        private void CANCEL_Click(object sender, EventArgs e)
        {
            DataRow dr = GetSelectedRow();
            if (dr == null)
                return;
            pupil db = new pupil();
            if (MessageBox.Show("למחוק את הרשומה?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                db.Delete(Convert.ToInt32(dr["staffID"]));

            }
            dataGridView.DataSource = DbMain.GetAllRecord("staff").Tables[0];

        }

        private void update_Click(object sender, EventArgs e)
        {
            staff editStaff = new staff();
            editStaff.StaffID = textBox1.Text;
            editStaff.StaffFullName = textBox2.Text;
            editStaff.SelfTribeName = textBox3.Text;
            editStaff.Address = textBox4.Text;
            editStaff.PhoneNumber = textBox5.Text;
            editStaff.CityName = textBox6.Text;
            editStaff.SchoolName = textBox7.Text;
            editStaff.BirthDate = Convert.ToDateTime(DateTime.Today);
            //  editCustomers.EntryDate = "";

            DialogResult result = System.Windows.Forms.DialogResult.OK;
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                editStaff.Update();
                MessageBox.Show("update Customer");
                dataGridView.DataSource = DbMain.GetAllRecord("Customer").Tables[0];
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            staff editStaff = new staff();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || dateTimePicker.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Fill in all the fields");
            }

            else
            {
                editStaff.StaffID = textBox1.Text;
                editStaff.StaffFullName = textBox2.Text;
                editStaff.SelfTribeName = textBox3.Text;
                editStaff.Address = textBox4.Text;
                editStaff.PhoneNumber = textBox5.Text;
                editStaff.CityName = textBox6.Text;
                editStaff.SchoolName = textBox7.Text;
                editStaff.BirthDate = Convert.ToDateTime(DateTime.Today);
                DialogResult result = System.Windows.Forms.DialogResult.OK;

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    editStaff.Insert();
                    MessageBox.Show("Pupil Data Updated Successfully");
                    dataGridView.DataSource = DbMain.GetAllRecord("staff").Tables[0];


                }
            }
        }
        private void search_Click(object sender, EventArgs e)
        {
            staff db = new staff();
            int id = int.Parse(textBox9.Text);

            if (db.Found(id) != true)
            {
                MessageBox.Show(("לא נמצא לקוח בעל מספר זה") + " " + id);
            }

            else
            {
                DataTable ds = db.GetInfoByIdKey(id).Tables[0];

                textBox1.Text = ds.Rows[0]["staffID"].ToString();
                textBox2.Text = ds.Rows[0]["staffFullName"].ToString();
                textBox3.Text = ds.Rows[0]["selfTribeName"].ToString();
                textBox4.Text = ds.Rows[0]["address"].ToString();
                textBox5.Text = ds.Rows[0]["phoneNumber"].ToString();
                textBox6.Text = ds.Rows[0]["cityName"].ToString();
                textBox7.Text = ds.Rows[0]["schoolName"].ToString();
            }
        }
       private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adiWFProject.Forms
{
    public partial class staffForm : Form
    {
        public staffForm()
        {
            InitializeComponent();
        }

        private void staffForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            try
            {
                dataGridView.DataSource = DbMain.GetAllRecord("staff").Tables[0];
            }
            catch { }
        }

        private DataRow GetSelectedRow()
        {
            if (dataGridView.CurrentRow == null) return null;

            DataTable dt = null;
            if (dataGridView.DataSource is DataTable)
                dt = dataGridView.DataSource as DataTable;
            else if (dataGridView.DataSource is BindingSource)
                dt = ((DataSet)((BindingSource)dataGridView.DataSource).DataSource).Tables[0];
            else
                return null;

            return dt.Rows[this.dataGridView.CurrentRow.Index];
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            DataRow dr = GetSelectedRow();
            if (dr == null) return;

            staff db = new staff();
            if (MessageBox.Show("האם למחוק את איש הצוות?", "מחיקה", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.Delete(dr["staffID"].ToString());
                RefreshGrid();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            staff editStaff = new staff();
            // מיפוי לפי ה-Designer שלך:
            editStaff.StaffID = textBox1.Text;      // ת.ז (למעלה)
            editStaff.StaffFullName = textBox2.Text; // שם מלא
            editStaff.SelfTribeName = textBox3.Text; // שם שבט
            editStaff.Address = textBox4.Text;       // כתובת
            editStaff.PhoneNumber = textBox5.Text;   // טלפון
            editStaff.CityName = textBox6.Text;      // עיר
            editStaff.SchoolName = textBox7.Text;    // בית ספר
            editStaff.BirthDate = dateTimePicker.Value;

            editStaff.Update();
            MessageBox.Show("עודכן בהצלחה");
            RefreshGrid();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("חובה למלא ת.ז ושם");
                return;
            }

            staff newStaff = new staff();
            newStaff.StaffID = textBox1.Text;
            newStaff.StaffFullName = textBox2.Text;
            newStaff.SelfTribeName = textBox3.Text;
            newStaff.Address = textBox4.Text;
            newStaff.PhoneNumber = textBox5.Text;
            newStaff.CityName = textBox6.Text;
            newStaff.SchoolName = textBox7.Text;
            newStaff.BirthDate = dateTimePicker.Value;

            newStaff.Insert();
            MessageBox.Show("נוסף בהצלחה");
            RefreshGrid();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox9.Text)) return;

            staff db = new staff();
            string id = textBox9.Text; // החיפוש מתבצע ב-textBox9

            if (!db.Found(id))
            {
                MessageBox.Show("לא נמצא");
            }
            else
            {
                DataTable dt = db.GetInfoByIdKey(id).Tables[0];
                textBox1.Text = dt.Rows[0]["staffID"].ToString();
                textBox2.Text = dt.Rows[0]["staffFullName"].ToString();
                textBox3.Text = dt.Rows[0]["selfTribeName"].ToString();
                textBox4.Text = dt.Rows[0]["address"].ToString();
                textBox5.Text = dt.Rows[0]["phoneNumber"].ToString();
                textBox6.Text = dt.Rows[0]["cityName"].ToString();
                textBox7.Text = dt.Rows[0]["schoolName"].ToString();
                dateTimePicker.Value = Convert.ToDateTime(dt.Rows[0]["birthDate"]);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow dr = GetSelectedRow();
            if (dr != null)
            {
                textBox1.Text = dr["staffID"].ToString();
                textBox2.Text = dr["staffFullName"].ToString();
                // השלם במידת הצורך לשאר התיבות
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e) { }
    }
}