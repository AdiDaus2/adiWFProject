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

        // 🌟 פונקציית הלחיצה המתוקנת שממלאת את הדשבורד לפי מיקומי עמודות (בלי לקרוס על שמות)
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView.Rows[e.RowIndex].Cells[0].Value != null)
            {
                try
                {
                    DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                    // מילוי התיבות לפי סדר העמודות בגריד (0, 1, 2...) בשביל בטיחות מוחלטת
                    textBox1.Text = row.Cells[0].Value.ToString(); // ת.ז
                    textBox2.Text = row.Cells[1].Value.ToString(); // שם מלא
                    textBox3.Text = row.Cells[2].Value.ToString(); // שם שבט
                    textBox4.Text = row.Cells[3].Value.ToString(); // כתובת
                    textBox5.Text = row.Cells[4].Value.ToString(); // מספר טלפון
                    textBox6.Text = row.Cells[5].Value.ToString(); // עיר מגורים
                    textBox7.Text = row.Cells[6].Value.ToString(); // בית ספר

                    // מילוי תעודת הזהות התחתונה (עמודה 0)
                    textBox8.Text = row.Cells[0].Value.ToString();

                    // המרה בטוחה של תאריך הלידה
                    if (row.Cells[7].Value != DBNull.Value)
                    {
                        dateTimePicker.Value = Convert.ToDateTime(row.Cells[7].Value);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("שגיאה בהעברת הנתונים לעריכה: " + ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            DataRow dr = GetSelectedRow();
            if (dr == null) return;

            staff db = new staff();
            if (MessageBox.Show("האם למחוק את איש הצוות?", "מחיקה", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.Delete(dr[0].ToString());
                RefreshGrid();
            }
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
            string id = textBox9.Text;

            if (!db.Found(id))
            {
                MessageBox.Show("לא נמצא");
            }
            else
            {
                DataTable dt = db.GetInfoByIdKey(id).Tables[0];
                textBox1.Text = dt.Rows[0][0].ToString();
                textBox2.Text = dt.Rows[0][1].ToString();
                textBox3.Text = dt.Rows[0][2].ToString();
                textBox4.Text = dt.Rows[0][3].ToString();
                textBox5.Text = dt.Rows[0][4].ToString();
                textBox6.Text = dt.Rows[0][5].ToString();
                textBox7.Text = dt.Rows[0][6].ToString();
                if (dt.Rows[0][7] != DBNull.Value)
                {
                    dateTimePicker.Value = Convert.ToDateTime(dt.Rows[0][7]);
                }
            }
        }

        // קישור האירוע הקיים ב-Designer לפונקציה החדשה שלנו
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_CellClick(sender, e);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }
    }
}