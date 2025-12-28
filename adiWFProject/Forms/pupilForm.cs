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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace adiWFProject
{
    public partial class pupilForm : Form
    {
        public pupilForm()
        {
            InitializeComponent();
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
                db.Delete(Convert.ToInt32(dr["pupilID"]));

            }
            dataGridView.DataSource = DbMain.GetAllRecord("pupil").Tables[0];

        }

        private void add_Click(object sender, EventArgs e)
        {
            pupil editPupil = new pupil();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || dateTimePicker.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Fill in all the fields");
            }

            else
            {
                editPupil.PupilID = textBox1.Text;
                editPupil.PupilName = textBox2.Text;
                editPupil.TribeName = textBox3.Text;
                editPupil.Address = textBox4.Text;
                editPupil.ParentPhone = textBox5.Text;
                editPupil.CityName = textBox6.Text;
                editPupil.SchoolName = textBox7.Text;
                editPupil.StaffID = textBox8.Text;
                editPupil.BirthDate = Convert.ToDateTime(DateTime.Today);
                DialogResult result = System.Windows.Forms.DialogResult.OK;

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    editPupil.Insert();
                    MessageBox.Show("Pupil Data Updated Successfully");
                        dataGridView.DataSource = DbMain.GetAllRecord("pupil").Tables[0];
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            pupil editPupil = new pupil();
            editPupil.PupilID = textBox1.Text;
            editPupil.PupilName = textBox2.Text;
            editPupil.TribeName = textBox3.Text;
            editPupil.Address = textBox4.Text;
            editPupil.ParentPhone = textBox5.Text;
            editPupil.CityName = textBox6.Text;
            editPupil.SchoolName = textBox7.Text;
            editPupil.StaffID = textBox8.Text;
            editPupil.BirthDate = Convert.ToDateTime(DateTime.Today);
            //  editCustomers.EntryDate = "";

            DialogResult result = System.Windows.Forms.DialogResult.OK;
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                editPupil.Update();
                MessageBox.Show("update Customer");
                dataGridView.DataSource = DbMain.GetAllRecord("pupil").Tables[0];
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            //קולט ת.ז לקוח ומחזיר את נתוניו 
            pupil db = new pupil();
            int id = int.Parse(textBox9.Text);

            if (db.Found(id) != true)
            {
                MessageBox.Show(("לא נמצא לקוח בעל מספר זה") + " " + id);
            }

            else
            {
                DataTable ds = db.GetInfoByIdKey(id).Tables[0];

                textBox1.Text = ds.Rows[0]["pupilID"].ToString();
                textBox2.Text = ds.Rows[0]["pupilName"].ToString();
                textBox3.Text = ds.Rows[0]["tribeNAme"].ToString();
                textBox4.Text = ds.Rows[0]["address"].ToString();
                textBox5.Text = ds.Rows[0]["parentPhone"].ToString();
                textBox6.Text = ds.Rows[0]["cityName"].ToString();
                textBox7.Text = ds.Rows[0]["schoolName"].ToString();
                textBox8.Text = ds.Rows[0]["staffID"].ToString();

            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pupilForm_Load(object sender, EventArgs e)
        {

        }

        private void address_Click(object sender, EventArgs e)
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

namespace adiWFProject
{
    public partial class pupilForm : Form
    {
        public pupilForm()
        {
            InitializeComponent();
        }

        private void pupilForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            try
            {
                // שימוש במחלקה DbMain כדי למשוך את כל הטבלה
                dataGridView.DataSource = DbMain.GetAllRecord("pupil").Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בטעינת הנתונים: " + ex.Message);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("נא להזין ת.ז חניך");
                return;
            }

            pupil p = new pupil();
            p.PupilID = textBox1.Text;             // ת.ז חניך
            p.PupilFullName = textBox2.Text;       // שם מלא
            p.BirthDate = dateTimePicker.Value;    // תאריך לידה
            p.SelfTribeName = textBox3.Text;       // שם שבט
            p.Address = textBox4.Text;             // כתובת
            p.ParentPhoneNumber = textBox5.Text;   // טלפון הורים
            p.CityName = textBox6.Text;            // עיר
            p.SchoolName = textBox7.Text;          // בית ספר
            p.StaffID = textBox8.Text;             // ת.ז מדריך

            p.Insert();
            MessageBox.Show("חניך נוסף בהצלחה");
            RefreshGrid();
        }

        private void update_Click(object sender, EventArgs e)
        {
            pupil p = new pupil();
            p.PupilID = textBox1.Text;
            p.PupilFullName = textBox2.Text;
            p.BirthDate = dateTimePicker.Value;
            p.SelfTribeName = textBox3.Text;
            p.Address = textBox4.Text;
            p.ParentPhoneNumber = textBox5.Text;
            p.CityName = textBox6.Text;
            p.SchoolName = textBox7.Text;
            p.StaffID = textBox8.Text;

            p.Update();
            MessageBox.Show("פרטי חניך עודכנו");
            RefreshGrid();
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) return;

            pupil p = new pupil();
            if (MessageBox.Show("האם למחוק חניך זה?", "אישור מחיקה", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                p.Delete(textBox1.Text);
                RefreshGrid();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox9.Text)) return; // תיבת חיפוש

            pupil p = new pupil();
            if (p.Found(textBox9.Text))
            {
                DataTable dt = p.GetInfoByIdKey(textBox9.Text).Tables[0];
                textBox1.Text = dt.Rows[0]["pupilID"].ToString();
                textBox2.Text = dt.Rows[0]["pupilFullName"].ToString();
                textBox3.Text = dt.Rows[0]["selfTribeName"].ToString();
                textBox4.Text = dt.Rows[0]["address"].ToString();
                textBox5.Text = dt.Rows[0]["parentPhoneNumber"].ToString();
                textBox6.Text = dt.Rows[0]["cityName"].ToString();
                textBox7.Text = dt.Rows[0]["schoolName"].ToString();
                textBox8.Text = dt.Rows[0]["staffID"].ToString();
                dateTimePicker.Value = Convert.ToDateTime(dt.Rows[0]["birthDate"]);
            }
            else
            {
                MessageBox.Show("חניך לא נמצא");
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                // מילוי התיבות מהשורה שנבחרה בגריד
                textBox1.Text = dataGridView.CurrentRow.Cells["pupilID"].Value.ToString();
                textBox2.Text = dataGridView.CurrentRow.Cells["pupilFullName"].Value.ToString();
            }
        }

        // פונקציות ריקות כדי למנוע שגיאות אם הן מקושרות ב-Designer
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }
        private void textBox7_TextChanged(object sender, EventArgs e) { }
        private void textBox8_TextChanged(object sender, EventArgs e) { }
        private void textBox9_TextChanged(object sender, EventArgs e) { }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e) { }
        private void address_Click(object sender, EventArgs e) { }
    }
}