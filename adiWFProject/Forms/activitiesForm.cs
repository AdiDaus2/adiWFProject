/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace adiWFProject
{
    public partial class activitiesForm : Form
    {
        public activitiesForm()
        {
            InitializeComponent();
        }

        private void activitiesForm_Load(object sender, EventArgs e)
        {

        }
        private void add_Click(object sender, EventArgs e)
        {
            activities editActivities = new activities();

            if (textBox1.Text == null || textBox2.Text == "" || textBox3.Text == null || textBox4.Text == null || textBox5.Text == "")
            {
                MessageBox.Show("יש להזין נתונים בכל השדות");
                return;
            }

            else
            {
                editActivities.ActivityNum = Convert.ToInt32(textBox2.Text);
                editActivities.ActivtyDescraption = textBox3.Text;
                editActivities.MinAge = Convert.ToInt32(textBox4.Text);
                editActivities.MaxAge = Convert.ToInt32(textBox5.Text);
                editActivities.ActivityWriteId = textBox1.Text;
                editActivities.WriteDate = Convert.ToDateTime(DateTime.Today);
                DialogResult result = System.Windows.Forms.DialogResult.OK;

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    editActivities.Insert();
                    MessageBox.Show("פעולה נוספה בהצלחה ");
                    dataGridView.DataSource =DbMain.GetAllRecord("activities").Tables[0];
                }
            }  
        }

        private DataRow GetSelectedRow()
        {
            DataTable dt = null;
            if (dataGridView.DataSource is DataTable)
                dt = dataGridView.DataSource as DataTable;
            else if (dataGridView.DataSource is BindingSource)
                dt = ((DataSet)((BindingSource)dataGridView.DataSource).DataSource).Tables[0];
            else
                return null;

            return dt.Rows[this.dataGridView.CurrentRow.Index];
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            DataRow dr = GetSelectedRow();
            if (dr == null)
                return;
            activities db = new activities();
            if (MessageBox.Show("למחוק את הרשומה?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                db.Delete(Convert.ToInt32(dr["ActivityNum"]));

            }
            dataGridView.DataSource = DbMain.GetAllRecord("activities").Tables[0];
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
                MessageBox.Show(" הכנס תחילה מספר פעולה ");
            else
            {

                activities editActivities = new activities();
                editActivities.ActivityNum = Convert.ToInt32(textBox2.Text);
                editActivities.ActivtyDescraption = textBox3.Text;
                editActivities.MinAge = Convert.ToInt32(textBox4.Text);
                editActivities.MaxAge = Convert.ToInt32(textBox5.Text);
                editActivities.ActivityWriteId = textBox1.Text;
                editActivities.WriteDate = Convert.ToDateTime(DateTime.Today);


                DialogResult result = System.Windows.Forms.DialogResult.OK;
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    editActivities.Update();
                    MessageBox.Show("פעולה עודכנה");
                    dataGridView.DataSource = DbMain.GetAllRecord("activities").Tables[0];

                }
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            activities c = new activities();
            c.ActivityNum = Convert.ToInt32(textBox6.Text);

            if (c.Found(c.ActivityNum) != true)
            {
                MessageBox.Show(("לא נמצאה פעולה בעלת מספר זה") + " " + c.ActivityNum);
            }

            else
            {
                DataTable ds = c.GetInfoByIdKey(c.ActivityNum).Tables[0];
                textBox2.Text = ds.Rows[0]["ActivityNum"].ToString();
                textBox3.Text = ds.Rows[0]["ActivityDescraption"].ToString();
                textBox4.Text = ds.Rows[0]["MinAge"].ToString();
                textBox5.Text = ds.Rows[0]["MaxAge"].ToString();
                textBox1.Text = ds.Rows[0]["ActivityWriterId"].ToString();
                dateTimePicker1.Text = ds.Rows[0]["WriteDate"].ToString();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void activitiesForm_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    public partial class activitiesForm : Form
    {
        public activitiesForm()
        {
            InitializeComponent();
        }

        private void activitiesForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        // פונקציית עזר לרענון הטבלה במסך
        private void RefreshGrid()
        {
            try
            {
                dataGridView.DataSource = DbMain.GetAllRecord("activities").Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בטעינת הנתונים: " + ex.Message);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            // בדיקה שכל השדות מלאים
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("יש להזין נתונים בכל השדות");
                return;
            }

            try
            {
                activities editActivities = new activities();
                editActivities.ActivityNum = Convert.ToInt32(textBox2.Text);
                editActivities.ActivtyDescraption = textBox3.Text;
                editActivities.MinAge = Convert.ToInt32(textBox4.Text);
                editActivities.MaxAge = Convert.ToInt32(textBox5.Text);
                editActivities.ActivityWriteId = textBox1.Text;
                editActivities.WriteDate = DateTime.Today; // תאריך של היום

                editActivities.Insert();
                MessageBox.Show("פעולה נוספה בהצלחה");
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בהוספה: " + ex.Message);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("נא לבחור או להזין מספר פעולה לעדכון");
                return;
            }

            try
            {
                activities editActivities = new activities();
                editActivities.ActivityNum = Convert.ToInt32(textBox2.Text);
                editActivities.ActivtyDescraption = textBox3.Text;
                editActivities.MinAge = Convert.ToInt32(textBox4.Text);
                editActivities.MaxAge = Convert.ToInt32(textBox5.Text);
                editActivities.ActivityWriteId = textBox1.Text;
                editActivities.WriteDate = DateTime.Today;

                editActivities.Update();
                MessageBox.Show("הפעולה עודכנה בהצלחה");
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בעדכון: " + ex.Message);
            }
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            // מחיקה לפי השורה שנבחרה בגריד או לפי תיבת הטקסט
            int activityNum;
            if (dataGridView.CurrentRow != null && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                activityNum = Convert.ToInt32(textBox2.Text);
            }
            else
            {
                MessageBox.Show("נא לבחור פעולה למחיקה");
                return;
            }

            if (MessageBox.Show("האם למחוק את הפעולה?", "אישור מחיקה", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                activities db = new activities();
                db.Delete(activityNum);
                RefreshGrid();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("נא להזין מספר פעולה לחיפוש");
                return;
            }

            try
            {
                activities c = new activities();
                int searchId = Convert.ToInt32(textBox6.Text);

                if (c.Found(searchId))
                {
                    DataTable ds = c.GetInfoByIdKey(searchId).Tables[0];
                    textBox2.Text = ds.Rows[0]["ActivityNum"].ToString();
                    textBox3.Text = ds.Rows[0]["ActivityDescraption"].ToString();
                    textBox4.Text = ds.Rows[0]["MinAge"].ToString();
                    textBox5.Text = ds.Rows[0]["MaxAge"].ToString();
                    textBox1.Text = ds.Rows[0]["ActivityWriterId"].ToString();

                    // בדיקה אם קיים בקר תאריך, אם לא - נשתמש ב-dateTimePicker1 כפי שהיה בקוד שלך
                    dateTimePicker1.Value = Convert.ToDateTime(ds.Rows[0]["WriteDate"]);
                }
                else
                {
                    MessageBox.Show("לא נמצאה פעולה בעלת מספר: " + searchId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בחיפוש: " + ex.Message);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // העברת נתונים מהגריד לתיבות הטקסט בלחיצה
            if (dataGridView.CurrentRow != null)
            {
                textBox2.Text = dataGridView.CurrentRow.Cells["ActivityNum"].Value.ToString();
                textBox3.Text = dataGridView.CurrentRow.Cells["ActivityDescraption"].Value.ToString();
            }
        }

        // --- פונקציות ריקות למניעת שגיאות קומפילציה מול ה-Designer ---
        private void textBox6_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void title_Click(object sender, EventArgs e) { }
        private void activitiesForm_Load_1(object sender, EventArgs e) { }
    }
}