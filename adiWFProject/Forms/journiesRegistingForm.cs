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

namespace adiWFProject.Forms
{
    public partial class journiesRegistingForm : Form
    {
        public journiesRegistingForm()
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
                db.Delete(Convert.ToInt32(dr["journeyCode"]));

            }
            dataGridView.DataSource = DbMain.GetAllRecord("journiesRegisting").Tables[0];
        }

        private void search_Click(object sender, EventArgs e)
        {
            journiesRegisting db = new journiesRegisting();
            int id = int.Parse(textBox7.Text);

            if (db.Found(id) != true)
            {
                MessageBox.Show(("לא נמצא לקוח בעל מספר זה") + " " + id);
            }

            else
            {
                DataTable ds = db.GetInfoByIdKey(id).Tables[0];
                textBox1.Text = ds.Rows[0][""].ToString();
                textBox2.Text = ds.Rows[0]["pupilName"].ToString();
                textBox3.Text = ds.Rows[0]["tribeNAme"].ToString();
                textBox4.Text = ds.Rows[0]["address"].ToString();
                textBox5.Text = ds.Rows[0]["parentPhone"].ToString();
                textBox6.Text = ds.Rows[0]["cityName"].ToString();
                textBox7.Text = ds.Rows[0]["schoolName"].ToString();
                textBox8.Text = ds.Rows[0]["staffID"].ToString();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            journiesRegisting editJourniesRegisting = new journiesRegisting();
            string missingFields = "";

            if (string.IsNullOrWhiteSpace(textBox1.Text)) missingFields += "שם תלמיד (textBox1)\n";
            if (string.IsNullOrWhiteSpace(textBox2.Text)) missingFields += "טלפון (textBox2)\n";
            if (string.IsNullOrWhiteSpace(JourneyCodeFiled.Text)) missingFields += "קוד מסע (JourneyCodeFiled)\n";
            if (string.IsNullOrWhiteSpace(textBox3.Text)) missingFields += "שם נסיעה (textBox3)\n";
            if (string.IsNullOrWhiteSpace(textBox4.Text)) missingFields += "מקום (textBox4)\n";
            if (string.IsNullOrWhiteSpace(textBox5.Text)) missingFields += "תשלום (textBox5)\n";
            if (string.IsNullOrWhiteSpace(textBox6.Text)) missingFields += "סוג כרטיס (textBox6)\n";
            if (string.IsNullOrWhiteSpace(textBox7.Text)) missingFields += "מספר כרטיס (textBox7)\n";
            if (comboBox2.SelectedIndex == -1) missingFields += "סוג תשלום (comboBox2)\n";

            if (missingFields != "")
            {
                MessageBox.Show("השדות הבאים חסרים:\n" + missingFields);
            }
            else
            {
                editJourniesRegisting.PupilName = textBox1.Text;
                editJourniesRegisting.ParentPhoneNum = int.Parse(textBox2.Text);
                editJourniesRegisting.SelfHealth = checkBox.Checked;
                editJourniesRegisting.JourneyCode = int.Parse(JourneyCodeFiled.Text); ;
                editJourniesRegisting.JourneyName = textBox3.Text;
                editJourniesRegisting.RegisterDate = dateTimePicker.Value;
                editJourniesRegisting.Place = textBox4.Text;
                editJourniesRegisting.TotalPayment = int.Parse(textBox5.Text);
                editJourniesRegisting.PaymentType = comboBox2.Text;
                editJourniesRegisting.CreditCardType = textBox6.Text;
                editJourniesRegisting.CreditCardNumber = int.Parse(textBox7.Text);
                DialogResult result = System.Windows.Forms.DialogResult.OK;

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    editJourniesRegisting.Insert();
                    MessageBox.Show("Pupil Data Updated Successfully");
                    dataGridView.DataSource = DbMain.GetAllRecord("pupil").Tables[0];


                }
            }
        }
        
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
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
    public partial class journiesRegistingForm : Form
    {
        public journiesRegistingForm()
        {
            InitializeComponent();
        }

        private void journiesRegistingForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                // טעינת נתונים לטבלה מהדאטה-בייס
                dataGridView.DataSource = DbMain.GetAllRecord("journiesRegisting").Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בריענון נתונים: " + ex.Message);
            }
        }


        private void search_Click(object sender, EventArgs e)
        {
            // בדיקה ששדות הטקסט אינם ריקים
            if (string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(JourneyCodeFiled.Text))
            {
                MessageBox.Show("נא להזין ת.ז חניך וקוד מסע לחיפוש");
                return;
            }

            try
            {
                journiesRegisting jr = new journiesRegisting();

                // הגדרת המשתנים לפי הסוג שהמחלקה הלוגית מצפה לו:
                // לפי הודעת השגיאה האחרונה:
                // הפרמטר הראשון (pId) כנראה צריך להיות int
                // הפרמטר השני (jCode) חייב להיות string
                int pId = int.Parse(textBox8.Text);
                string jCode = JourneyCodeFiled.Text;

                // קריאה לפונקציה Found עם הסוגים המתאימים
                if (jr.Found(pId, jCode))
                {
                    DataTable ds = jr.GetInfoByIdKey(pId, jCode).Tables[0];
                    if (ds.Rows.Count > 0)
                    {
                        // מילוי הנתונים בטופס
                        textBox1.Text = ds.Rows[0]["pupilID"].ToString();
                        JourneyCodeFiled.Text = ds.Rows[0]["journeyCode"].ToString();

                        if (ds.Columns.Contains("paymentType"))
                            comboBox2.Text = ds.Rows[0]["paymentType"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("לא נמצא רישום תואם");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("נא לוודא שהזנת מספר תקין בשדה תעודת הזהות");
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בחיפוש: " + ex.Message);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                journiesRegisting jr = new journiesRegisting();

                // השמת ערכים לאובייקט הלוגי
                jr.PupilID = textBox1.Text;
                jr.JourneyCode = int.Parse(JourneyCodeFiled.Text);

                // הערה: אם מופיעה שגיאה על IsPaid, וודא שזה השם במחלקה journiesRegisting.cs
                // אם השם הוא SelfHealth, שנה את השורה בהתאם.
                // jr.SelfHealth = checkBox.Checked; 

                jr.Insert();
                MessageBox.Show("הרישום נוסף בהצלחה למערכת");
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בתהליך ההוספה: " + ex.Message);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                journiesRegisting jr = new journiesRegisting();
                jr.PupilID = textBox1.Text;
                jr.JourneyCode = int.Parse(JourneyCodeFiled.Text);

                jr.Update();
                MessageBox.Show("הרישום עודכן בהצלחה");
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בעדכון הנתונים: " + ex.Message);
            }
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("יש לבחור שורה למחיקה מהטבלה");
                return;
            }

            if (MessageBox.Show("האם אתה בטוח שברצונך למחוק את הרישום שנבחר?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    journiesRegisting jr = new journiesRegisting();

                    // שליפת המפתחות מהשורה שנבחרה בגריד
                    string pId = dataGridView.CurrentRow.Cells["pupilID"].Value.ToString();
                    int jCode = Convert.ToInt32(dataGridView.CurrentRow.Cells["journeyCode"].Value);

                    // קריאה לפונקציית המחיקה עם הפרמטרים הנכונים
                    jr.Delete(pId, jCode);

                    MessageBox.Show("הרישום נמחק בהצלחה");
                    RefreshData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("שגיאה בתהליך המחיקה: " + ex.Message);
                }
            }
        }

        // אירועים ריקים הנדרשים על ידי ה-Designer
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox7_TextChanged(object sender, EventArgs e) { }
        private void textBox8_TextChanged(object sender, EventArgs e) { }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}