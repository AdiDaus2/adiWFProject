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
    public partial class activityReportForm : Form
    {
        public activityReportForm()
        {
            InitializeComponent();
        }

        private void activityReportForm_Load(object sender, EventArgs e)
        {
            ////מילוי קוד פעולה  לפי קוד
            //activityReport jj = new activityReport();
            //DataTable ds;
            //string sql = "SELECT activityNum FROM activityReport";
            //ds = DbMain.GetQuery(sql).Tables[0];
            //comboBox2.DataSource = ds;
            //comboBox2.ValueMember = "activityNum";
            comboBox1.DataSource = DbMain.GetAllRecord("activityReport").Tables[0];
            comboBox1.ValueMember = "activityNum";
        }
        private void title_Click(object sender, EventArgs e)
        {

        }

       

        private void search_Click(object sender, EventArgs e)
        {
            activityReport c = new activityReport();
            c.ActivityNum = Convert.ToInt32(comboBox1.Text);



            if (c.Found(c.ActivityNum) == false)
            {


                MessageBox.Show(("לא נמצאה חוות דעת על פעולה בעלת קוד זה") + " " + c.ActivityNum);

                //dataGridView1.DataSource = db.GetCustomersinfo(t.ClientId).Tables[0];
            }

            else
            {
                DataTable ds = c.GetInfoByIdKey(c.ActivityNum).Tables[0];
                textBox2.Text = ds.Rows[0]["participantsAmount"].ToString();
                textBox3.Text = ds.Rows[0]["parashatShavua"].ToString();
                textBox1.Text = ds.Rows[0]["StaffID"].ToString();
                dateTimePicker.Text = ds.Rows[0]["activityDate"].ToString();
                textBox4.Text = ds.Rows[0]["opinion"].ToString();
                comboBox2.Text = ds.Rows[0]["rating"].ToString();
                comboBox1.Text = ds.Rows[0]["activityNum"].ToString();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            staff mmm = new staff();
            string m = "select * from staff where staffID= '" + textBox1.Text + "'";
            DataTable ms = DbMain.GetQuery(m).Tables[0];

            if (ms.Rows.Count == 0)
            {
                MessageBox.Show("מדריכה אינה רשומה במערכת, הזיני ת.ז מדריכה תקין");
                return;
            }

            activityReport editActivity = new activityReport();
            editActivity.Rating = Convert.ToInt32(comboBox2.Text);
            editActivity.ParticipantsAmount = Convert.ToInt32(textBox2.Text);
            editActivity.ParashatShavua = textBox3.Text;
            editActivity.ActivityDate = Convert.ToDateTime(dateTimePicker.Text);
            editActivity.ActivityNum = Convert.ToInt32(comboBox1.Text);
            editActivity.StaffID = textBox1.Text;
            editActivity.Opinion = textBox4.Text;

            DialogResult result = System.Windows.Forms.DialogResult.OK;
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                editActivity.Insert();
                MessageBox.Show("משוב נוסף בהצלחה ");
                dataGridView.DataSource = DbMain.GetAllRecord("activityReport").Tables[0];
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
        private void CANCEL_Click(object sender, EventArgs e)
        {
            DataRow dr = GetSelectedRow();
            if (dr == null)
                return;
            activityReport db = new activityReport();
            if (MessageBox.Show("למחוק את הרשומה?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                db.Delete(Convert.ToInt32(dr["ActivityNum"]));

            }
            dataGridView.DataSource = DbMain.GetAllRecord("activities").Tables[0];
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
                MessageBox.Show(" הכנס תחילה מספר פעולה ");
            else
            {

                activityReport editActivities = new activityReport();
                editActivities.ActivityNum = Convert.ToInt32(comboBox1.Text);
                editActivities.ParticipantsAmount = Convert.ToInt32(textBox2.Text);
                editActivities.ParashatShavua = textBox3.Text;
                editActivities.Rating = Convert.ToInt32(comboBox2.Text);
                editActivities.StaffID = textBox1.Text;
                editActivities.ActivityDate = Convert.ToDateTime(DateTime.Today);


                DialogResult result = System.Windows.Forms.DialogResult.OK;
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    editActivities.Update();
                    MessageBox.Show("פעולה עודכנה");
                    dataGridView.DataSource = DbMain.GetAllRecord("activities").Tables[0];
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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
    public partial class activityReportForm : Form
    {
        public activityReportForm()
        {
            InitializeComponent();
        }

        private void activityReportForm_Load(object sender, EventArgs e)
        {
            RefreshData();
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            try
            {
                comboBox1.DataSource = DbMain.GetAllRecord("activities").Tables[0];
                comboBox1.DisplayMember = "ActivityNum";
                comboBox1.ValueMember = "ActivityNum";
                comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בטעינת רשימת פעילויות: " + ex.Message);
            }
        }

        private void RefreshData()
        {
            try
            {
                dataGridView.DataSource = DbMain.GetAllRecord("activityReport").Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בריענון הטבלה: " + ex.Message);
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("נא לבחור או להזין מספר פעולה לחיפוש");
                return;
            }

            try
            {
                activityReport c = new activityReport();
                int activityId = Convert.ToInt32(comboBox1.Text);

                if (c.Found(activityId))
                {
                    DataTable ds = c.GetInfoByIdKey(activityId).Tables[0];
                    textBox2.Text = ds.Rows[0]["participantsAmount"].ToString();
                    textBox3.Text = ds.Rows[0]["parashatShavua"].ToString();
                    textBox1.Text = ds.Rows[0]["StaffID"].ToString();
                    dateTimePicker.Value = Convert.ToDateTime(ds.Rows[0]["activityDate"]);
                    textBox4.Text = ds.Rows[0]["opinion"].ToString();
                    comboBox2.Text = ds.Rows[0]["rating"].ToString();
                }
                else
                {
                    MessageBox.Show("לא נמצא משוב עבור פעולה מספר " + activityId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בחיפוש: " + ex.Message);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("נא להזין ת.ז. מדריכה");
                return;
            }

            string m = "select * from staff where staffID= '" + textBox1.Text + "'";
            DataTable ms = DbMain.GetQuery(m).Tables[0];

            if (ms.Rows.Count == 0)
            {
                MessageBox.Show("מדריכה אינה רשומה במערכת");
                return;
            }

            try
            {
                activityReport editActivity = new activityReport();
                editActivity.ActivityNum = Convert.ToInt32(comboBox1.Text);
                editActivity.ParticipantsAmount = Convert.ToInt32(textBox2.Text);
                editActivity.ParashatShavua = textBox3.Text;
                editActivity.Rating = Convert.ToInt32(comboBox2.Text);
                editActivity.StaffID = textBox1.Text;
                editActivity.ActivityDate = dateTimePicker.Value;
                editActivity.Opinion = textBox4.Text;

                editActivity.Insert();
                MessageBox.Show("משוב נוסף בהצלחה");
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בהוספת המשוב: " + ex.Message);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("הכנס תחילה מספר פעולה לעדכון");
                return;
            }

            try
            {
                activityReport editActivities = new activityReport();
                editActivities.ActivityNum = Convert.ToInt32(comboBox1.Text);
                editActivities.ParticipantsAmount = Convert.ToInt32(textBox2.Text);
                editActivities.ParashatShavua = textBox3.Text;
                editActivities.Rating = Convert.ToInt32(comboBox2.Text);
                editActivities.StaffID = textBox1.Text;
                editActivities.ActivityDate = dateTimePicker.Value;
                editActivities.Opinion = textBox4.Text; // תיקון כאן: שימוש ב-editActivities במקום editActivity

                editActivities.Update();
                MessageBox.Show("המשוב עודכן בהצלחה");
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בעדכון: " + ex.Message);
            }
        }

        private DataRow GetSelectedRow()
        {
            if (dataGridView.CurrentRow == null) return null;
            DataTable dt = (DataTable)dataGridView.DataSource;
            return dt.Rows[this.dataGridView.CurrentRow.Index];
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            DataRow dr = GetSelectedRow();
            if (dr == null) return;

            if (MessageBox.Show("למחוק את המשוב הנבחר?", "אישור מחיקה", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    activityReport db = new activityReport();
                    db.Delete(Convert.ToInt32(dr["ActivityNum"]));
                    RefreshData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("שגיאה במחיקה: " + ex.Message);
                }
            }
        }

        private void title_Click(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}