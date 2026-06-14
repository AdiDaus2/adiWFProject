


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
    public partial class journiesForm : Form
    {
        public journiesForm()
        {
            InitializeComponent();
        }

        private void journiesForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        // פונקציה לרענון התצוגה בטבלה
        private void RefreshGrid()
        {
            try
            {
                dataGridView.DataSource = DbMain.GetAllRecord("journies").Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בטעינת נתונים: " + ex.Message);
            }
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

        private void add_Click(object sender, EventArgs e)
        {
            // בדיקת תקינות - האם כל השדות מלאים
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("יש להזין נתונים בכל השדות");
                return;
            }

            try
            {
                journies editJournies = new journies();
                editJournies.JourneyName = textBox1.Text;
                editJournies.JourneyDate = dateTimePicker.Value;
                editJournies.StaffID = textBox2.Text;
                editJournies.DaysNum = Convert.ToInt32(textBox3.Text);
                editJournies.Place = textBox4.Text;
                editJournies.SecurityInsure = checkBox.Checked;
                editJournies.Price = Convert.ToInt32(textBox6.Text);

                editJournies.Insert();
                MessageBox.Show("מסע נוסף בהצלחה");
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בהוספה: " + ex.Message);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("נא לבחור קוד מסע לעדכון (בצע חיפוש או בחר מהטבלה)");
                return;
            }

            try
            {
                journies editJournies = new journies();
                editJournies.JourneyCode = Convert.ToInt32(textBox7.Text); // מפתח ראשי לעדכון
                editJournies.JourneyName = textBox1.Text;
                editJournies.JourneyDate = dateTimePicker.Value;
                editJournies.StaffID = textBox2.Text;
                editJournies.DaysNum = Convert.ToInt32(textBox3.Text);
                editJournies.Place = textBox4.Text;
                editJournies.SecurityInsure = checkBox.Checked;
                editJournies.Price = Convert.ToInt32(textBox6.Text);

                editJournies.Update();
                MessageBox.Show("המסע עודכן בהצלחה");
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בעדכון: " + ex.Message);
            }
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            DataRow dr = GetSelectedRow();
            if (dr == null)
            {
                MessageBox.Show("נא לבחור שורה למחיקה מהטבלה");
                return;
            }

            if (MessageBox.Show("האם למחוק את המסע הנבחר?", "אישור מחיקה", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    journies db = new journies();
                    db.Delete(Convert.ToInt32(dr["JourneyCode"])); // וודא שזה השם המדויק ב-DB
                    RefreshGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("שגיאה במחיקה: " + ex.Message);
                }
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("נא להזין קוד מסע לחיפוש");
                return;
            }

            try
            {
                journies c = new journies();
                int searchCode = Convert.ToInt32(textBox7.Text);

                if (c.Found(searchCode))
                {
                    DataTable ds = c.GetInfoByIdKey(searchCode).Tables[0];
                    textBox1.Text = ds.Rows[0]["journeyName"].ToString();
                    dateTimePicker.Value = Convert.ToDateTime(ds.Rows[0]["journeyDate"]);
                    textBox2.Text = ds.Rows[0]["StaffID"].ToString();
                    textBox3.Text = ds.Rows[0]["daysNum"].ToString();
                    textBox4.Text = ds.Rows[0]["place"].ToString();
                    checkBox.Checked = Convert.ToBoolean(ds.Rows[0]["securityInsure"]);
                    textBox6.Text = ds.Rows[0]["price"].ToString();
                }
                else
                {
                    MessageBox.Show("לא נמצא מסע בעל קוד: " + searchCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בחיפוש: " + ex.Message);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow dr = GetSelectedRow();
            if (dr != null)
            {
                textBox7.Text = dr["JourneyCode"].ToString();
                textBox1.Text = dr["journeyName"].ToString();
                // מילוי שאר השדות במידת הצורך בלחיצה
            }
        }

        // פונקציות ריקות למניעת שגיאות Designer
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
    }
}