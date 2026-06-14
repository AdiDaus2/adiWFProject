using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

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
            // 1. רענון טבלת החניכים בגריד
            RefreshGrid();

            // 2. טעינת קומבו-בוקס מדריכים (comboBox1)
            try
            {
                DataSet dsStaff = DbMain.GetAllRecord("staff");
                if (dsStaff != null && dsStaff.Tables.Count > 0)
                {
                    comboBox1.DataSource = dsStaff.Tables[0];
                    comboBox1.DisplayMember = "staffID";
                    comboBox1.ValueMember = "staffID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בטעינת רשימת המדריכים: " + ex.Message);
            }

            // 3. טעינת קומבו-בוקס שבטים (comboBox2) מהטבלה 'tribes'
            try
            {
                DataSet dsTribes = DbMain.GetAllRecord("tribes");
                if (dsTribes != null && dsTribes.Tables.Count > 0)
                {
                    comboBox2.DataSource = dsTribes.Tables[0];
                    comboBox2.DisplayMember = "tribeName";
                    comboBox2.ValueMember = "tribeName";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בטעינת רשימת השבטים: " + ex.Message);
            }
        }

        // רענון הגריד על המסך
        private void RefreshGrid()
        {
            try
            {
                DataSet ds = DbMain.GetAllRecord("pupil");
                if (ds != null && ds.Tables.Count > 0)
                {
                    dataGridView.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה ברענון הנתונים: " + ex.Message);
            }
        }

        // פונקציית בדיקת תקינות קלט משופרת ומרוכזת
        private bool CheckInputs()
        {
            // מחרוזת שתרכז את כל הודעות השגיאה
            string errorMessage = "";

            string idInput = textBox1.Text.Trim();
            string nameInput = textBox2.Text.Trim();
            string phoneInput = textBox5.Text.Trim();

            // 1. בדיקת תעודת זהות: שדה חובה, רק מספרים, ובדיוק 9 ספרות
            if (string.IsNullOrEmpty(idInput))
            {
                errorMessage += "* יש להזין תעודת זהות.\n";
            }
            else
            {
                long dummyId;
                if (!long.TryParse(idInput, out dummyId))
                {
                    errorMessage += "* תעודת זהות חייבת להכיל מספרים בלבד.\n";
                }
                else if (idInput.Length != 9)
                {
                    errorMessage += "* תעודת זהות חייבת להיות באורך של 9 ספרות בדיוק.\n";
                }
            }

            // 2. בדיקת שם מלא: שדה חובה, המכיל רק אותיות ורווחים
            if (string.IsNullOrEmpty(nameInput))
            {
                errorMessage += "* יש להזין שם מלא לחניך.\n";
            }
            else
            {
                // לולאה שעוברת תו-תו ובודקת שהוא אות בעברית/אנגלית או רווח
                foreach (char c in nameInput)
                {
                    if (!char.IsLetter(c) && c != ' ')
                    {
                        errorMessage += "* השם המלא חייב להכיל אותיות ורווחים בלבד (ללא מספרים או סימנים).\n";
                        break; // מספיק שמצאנו תו אחד לא תקין כדי להוסיף שגיאה ולצאת מהלולאה
                    }
                }
            }

            // 3. בדיקת מספר טלפון: שדה חובה (או רשות, לבחירתך), רק מספרים ובדיוק 10 ספרות
            if (string.IsNullOrEmpty(phoneInput))
            {
                errorMessage += "* יש להזין מספר טלפון של ההורים.\n";
            }
            else
            {
                long dummyPhone;
                if (!long.TryParse(phoneInput, out dummyPhone))
                {
                    errorMessage += "* מספר טלפון חייב להכיל מספרים בלבד.\n";
                }
                else if (phoneInput.Length != 10)
                {
                    errorMessage += "* מספר טלפון חייב להיות באורך של 10 ספרות בדיוק (למשל: 0525381648).\n";
                }
            }

            // סיכום הבדיקה: אם הצטברו שגיאות, נציג את כולן יחד ונחזיר false
            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show("אנא תקני את השגיאות הבאות לפני המשך הפעולה:\n\n" + errorMessage,
                                "שגיאה בקלט", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // הכל תקין לחלוטין!
        }

        // כפתור הוספה
        private void add_Click(object sender, EventArgs e)
        {
            if (!CheckInputs()) return; // אם הבדיקה נכשלה, היא כבר תציג את כל השגיאות ותעצור כאן

            try
            {
                pupil p = new pupil();
                p.PupilID = textBox1.Text.Trim();
                p.PupilFullName = textBox2.Text.Trim();
                p.BirthDate = dateTimePicker.Value;
                p.SelfTribeName = comboBox2.Text;
                p.Address = textBox4.Text.Trim();
                p.ParentPhoneNumber = textBox5.Text.Trim();
                p.CityName = textBox6.Text.Trim();
                p.SchoolName = textBox7.Text.Trim();
                p.StaffID = comboBox1.Text;

                p.Insert();

                MessageBox.Show("חניך נוסף בהצלחה", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid();
                ClearAllFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בהוספת חניך: " + ex.Message);
            }
        }

        // כפתור עדכון
        private void update_Click(object sender, EventArgs e)
        {
            if (!CheckInputs()) return;

            try
            {
                pupil p = new pupil();
                p.PupilID = textBox1.Text.Trim();
                p.PupilFullName = textBox2.Text.Trim();
                p.BirthDate = dateTimePicker.Value;
                p.SelfTribeName = comboBox2.Text;
                p.Address = textBox4.Text.Trim();
                p.ParentPhoneNumber = textBox5.Text.Trim();
                p.CityName = textBox6.Text.Trim();
                p.SchoolName = textBox7.Text.Trim();
                p.StaffID = comboBox1.Text;

                p.Update();

                MessageBox.Show("פרטי חניך עודכנו בהצלחה", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid();
                ClearAllFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בעדכון חניך: " + ex.Message);
            }
        }

        // כפתור מחיקה
        private void CANCEL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("אנא בחרי חניך למחיקה מתוך הטבלה");
                return;
            }

            try
            {
                pupil p = new pupil();
                if (MessageBox.Show("האם למחוק חניך זה?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (p.Delete(textBox1.Text))
                    {
                        MessageBox.Show("החניך נמחק בהצלחה", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                        ClearAllFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה במחיקת חניך: " + ex.Message);
            }
        }

        // כפתור חיפוש
        private void search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox8.Text)) return;

            pupil p = new pupil();
            if (p.Found(textBox8.Text))
            {
                DataTable dt = p.GetInfoByIdKey(textBox8.Text).Tables[0];
                textBox1.Text = dt.Rows[0]["pupilID"].ToString();
                textBox2.Text = dt.Rows[0]["pupilName"].ToString();
                comboBox2.Text = dt.Rows[0]["tribeName"].ToString();
                textBox4.Text = dt.Rows[0]["address"].ToString();
                textBox5.Text = dt.Rows[0]["parentPhone"].ToString();
                textBox6.Text = dt.Rows[0]["cityName"].ToString();
                textBox7.Text = dt.Rows[0]["schoolName"].ToString();
                comboBox1.Text = dt.Rows[0]["staffID"].ToString();
                dateTimePicker.Value = Convert.ToDateTime(dt.Rows[0]["birthDate"]);
            }
            else
            {
                MessageBox.Show("חניך לא נמצא");
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FillFieldsFromGrid();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            FillFieldsFromGrid();
        }

        private void FillFieldsFromGrid()
        {
            if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Index >= 0)
            {
                DataGridViewRow row = dataGridView.CurrentRow;

                textBox1.Text = row.Cells["pupilID"].Value?.ToString() ?? "";
                textBox2.Text = row.Cells["pupilName"].Value?.ToString() ?? "";
                comboBox2.Text = row.Cells["tribeName"].Value?.ToString() ?? "";
                textBox4.Text = row.Cells["address"].Value?.ToString() ?? "";
                textBox5.Text = row.Cells["parentPhone"].Value?.ToString() ?? "";
                textBox6.Text = row.Cells["cityName"].Value?.ToString() ?? "";
                textBox7.Text = row.Cells["schoolName"].Value?.ToString() ?? "";
                comboBox1.Text = row.Cells["staffID"].Value?.ToString() ?? "";

                if (row.Cells["birthDate"].Value != null && row.Cells["birthDate"].Value != DBNull.Value)
                {
                    dateTimePicker.Value = Convert.ToDateTime(row.Cells["birthDate"].Value);
                }
            }
        }

        private void ClearAllFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
            if (comboBox2.Items.Count > 0) comboBox2.SelectedIndex = 0;
            dateTimePicker.Value = DateTime.Now;
        }

        // פונקציות ריקות תואמות לדיזיינר
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}

//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Data.OleDb;

//namespace adiWFProject
//{
//    public partial class pupilForm : Form
//    {
//        public pupilForm()
//        {
//            InitializeComponent();
//        }

//        private void pupilForm_Load(object sender, EventArgs e)
//        {
//            // 1. רענון טבלת החניכים בגריד
//            RefreshGrid();

//            // 2. טעינת קומבו-בוקס מדריכים (comboBox1)
//            try
//            {
//                DataSet dsStaff = DbMain.GetAllRecord("staff");
//                if (dsStaff != null && dsStaff.Tables.Count > 0)
//                {
//                    comboBox1.DataSource = dsStaff.Tables[0];
//                    comboBox1.DisplayMember = "staffID";
//                    comboBox1.ValueMember = "staffID";
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("שגיאה בטעינת רשימת המדריכים: " + ex.Message);
//            }

//            // 3. טעינת קומבו-בוקס שבטים (comboBox2) מהטבלה 'tribes'
//            try
//            {
//                DataSet dsTribes = DbMain.GetAllRecord("tribes");
//                if (dsTribes != null && dsTribes.Tables.Count > 0)
//                {
//                    comboBox2.DataSource = dsTribes.Tables[0];
//                    comboBox2.DisplayMember = "tribeName";
//                    comboBox2.ValueMember = "tribeName";
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("שגיאה בטעינת רשימת השבטים: " + ex.Message);
//            }
//        }

//        // רענון הגריד על המסך
//        private void RefreshGrid()
//        {
//            try
//            {
//                DataSet ds = DbMain.GetAllRecord("pupil");
//                if (ds != null && ds.Tables.Count > 0)
//                {
//                    dataGridView.DataSource = ds.Tables[0];
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("שגיאה ברענון הנתונים: " + ex.Message);
//            }
//        }

//        // פונקציה חדשה וחשובה: בדיקת תקינות הקלט של המשתמש
//        private bool CheckInputs()
//        {
//            // 1. בדיקה ששדות חובה אינם ריקים
//            if (string.IsNullOrEmpty(textBox1.Text.Trim()) || string.IsNullOrEmpty(textBox2.Text.Trim()))
//            {
//                MessageBox.Show("נא למלא שדות חובה: ת.ז ושם מלא של החניך.", "קלט חסר", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return false;
//            }

//            // 2. בדיקה שתעודת הזהות מכילה רק מספרים
//            long dummyId;
//            if (!long.TryParse(textBox1.Text.Trim(), out dummyId))
//            {
//                MessageBox.Show("תעודת זהות חייבת להכיל מספרים בלבד!", "טעות בקלט", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return false;
//            }

//            // 3. בדיקה אופציונלית לאורך תעודת זהות (9 ספרות ליתר ביטחון, אלא אם יש אצלך קצרות יותר באקסס)
//            if (textBox1.Text.Trim().Length > 9)
//            {
//                MessageBox.Show("תעודת זהות לא יכולה להיות ארוכה מ-9 ספרות.", "טעות בקלט", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return false;
//            }

//            // 4. בדיקה שמספר הטלפון של ההורים מכיל רק מספרים (אם הוכנס טלפון)
//            if (!string.IsNullOrEmpty(textBox5.Text.Trim()))
//            {
//                long dummyPhone;
//                if (!long.TryParse(textBox5.Text.Trim(), out dummyPhone))
//                {
//                    MessageBox.Show("מספר טלפון חייב להכיל מספרים בלבד!", "טעות בקלט", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                    return false;
//                }
//            }

//            return true; // הכל תקין!
//        }

//        // כפתור הוספה
//        private void add_Click(object sender, EventArgs e)
//        {
//            // קריאה לבדיקת התקינות - אם היא מחזירה false, עוצרים מיד ולא פונים לאקסס!
//            if (!CheckInputs()) return;

//            try
//            {
//                pupil p = new pupil();
//                p.PupilID = textBox1.Text.Trim();
//                p.PupilFullName = textBox2.Text.Trim();
//                p.BirthDate = dateTimePicker.Value;
//                p.SelfTribeName = comboBox2.Text;
//                p.Address = textBox4.Text.Trim();
//                p.ParentPhoneNumber = textBox5.Text.Trim();
//                p.CityName = textBox6.Text.Trim();
//                p.SchoolName = textBox7.Text.Trim();
//                p.StaffID = comboBox1.Text;

//                p.Insert();

//                MessageBox.Show("חניך נוסף בהצלחה", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                RefreshGrid();
//                ClearAllFields();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("שגיאה בהוספת חניך: " + ex.Message);
//            }
//        }

//        // כפתור עדכון
//        private void update_Click(object sender, EventArgs e)
//        {
//            // גם בעדכון מוודאים שהנתונים החדשים הגיוניים ותקינים
//            if (!CheckInputs()) return;

//            try
//            {
//                pupil p = new pupil();
//                p.PupilID = textBox1.Text.Trim();
//                p.PupilFullName = textBox2.Text.Trim();
//                p.BirthDate = dateTimePicker.Value;
//                p.SelfTribeName = comboBox2.Text;
//                p.Address = textBox4.Text.Trim();
//                p.ParentPhoneNumber = textBox5.Text.Trim();
//                p.CityName = textBox6.Text.Trim();
//                p.SchoolName = textBox7.Text.Trim();
//                p.StaffID = comboBox1.Text;

//                p.Update();

//                MessageBox.Show("פרטי חניך עודכנו בהצלחה", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                RefreshGrid();
//                ClearAllFields();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("שגיאה בעדכון חניך: " + ex.Message);
//            }
//        }

//        // כפתור מחיקה
//        private void CANCEL_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrEmpty(textBox1.Text))
//            {
//                MessageBox.Show("אנא בחרי חניך למחיקה מתוך הטבלה");
//                return;
//            }

//            try
//            {
//                pupil p = new pupil();
//                if (MessageBox.Show("האם למחוק חניך זה?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
//                {
//                    if (p.Delete(textBox1.Text))
//                    {
//                        MessageBox.Show("החניך נמחק בהצלחה", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                        RefreshGrid();
//                        ClearAllFields();
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("שגיאה במחיקת חניך: " + ex.Message);
//            }
//        }

//        // כפתור חיפוש
//        private void search_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrEmpty(textBox8.Text)) return;

//            pupil p = new pupil();
//            if (p.Found(textBox8.Text))
//            {
//                DataTable dt = p.GetInfoByIdKey(textBox8.Text).Tables[0];
//                textBox1.Text = dt.Rows[0]["pupilID"].ToString();
//                textBox2.Text = dt.Rows[0]["pupilName"].ToString();
//                comboBox2.Text = dt.Rows[0]["tribeName"].ToString();
//                textBox4.Text = dt.Rows[0]["address"].ToString();
//                textBox5.Text = dt.Rows[0]["parentPhone"].ToString();
//                textBox6.Text = dt.Rows[0]["cityName"].ToString();
//                textBox7.Text = dt.Rows[0]["schoolName"].ToString();
//                comboBox1.Text = dt.Rows[0]["staffID"].ToString();
//                dateTimePicker.Value = Convert.ToDateTime(dt.Rows[0]["birthDate"]);
//            }
//            else
//            {
//                MessageBox.Show("חניך לא נמצא");
//            }
//        }

//        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {
//            FillFieldsFromGrid();
//        }

//        private void dataGridView_SelectionChanged(object sender, EventArgs e)
//        {
//            FillFieldsFromGrid();
//        }

//        private void FillFieldsFromGrid()
//        {
//            if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Index >= 0)
//            {
//                DataGridViewRow row = dataGridView.CurrentRow;

//                textBox1.Text = row.Cells["pupilID"].Value?.ToString() ?? "";
//                textBox2.Text = row.Cells["pupilName"].Value?.ToString() ?? "";
//                comboBox2.Text = row.Cells["tribeName"].Value?.ToString() ?? "";
//                textBox4.Text = row.Cells["address"].Value?.ToString() ?? "";
//                textBox5.Text = row.Cells["parentPhone"].Value?.ToString() ?? "";
//                textBox6.Text = row.Cells["cityName"].Value?.ToString() ?? "";
//                textBox7.Text = row.Cells["schoolName"].Value?.ToString() ?? "";
//                comboBox1.Text = row.Cells["staffID"].Value?.ToString() ?? "";

//                if (row.Cells["birthDate"].Value != null && row.Cells["birthDate"].Value != DBNull.Value)
//                {
//                    dateTimePicker.Value = Convert.ToDateTime(row.Cells["birthDate"].Value);
//                }
//            }
//        }

//        private void ClearAllFields()
//        {
//            textBox1.Clear();
//            textBox2.Clear();
//            textBox4.Clear();
//            textBox5.Clear();
//            textBox6.Clear();
//            textBox7.Clear();
//            textBox8.Clear();
//            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
//            if (comboBox2.Items.Count > 0) comboBox2.SelectedIndex = 0;
//            dateTimePicker.Value = DateTime.Now;
//        }

//        // פונקציות ריקות תואמות לדיזיינר
//        private void textBox1_TextChanged(object sender, EventArgs e) { }
//        private void textBox2_TextChanged(object sender, EventArgs e) { }
//        private void textBox3_TextChanged(object sender, EventArgs e) { }
//        private void textBox4_TextChanged(object sender, EventArgs e) { }
//        private void textBox5_TextChanged(object sender, EventArgs e) { }
//        private void textBox6_TextChanged(object sender, EventArgs e) { }
//        private void textBox7_TextChanged(object sender, EventArgs e) { }
//        private void textBox8_TextChanged(object sender, EventArgs e) { }
//        private void textBox9_TextChanged(object sender, EventArgs e) { }
//        private void dateTimePicker_ValueChanged(object sender, EventArgs e) { }
//        private void address_Click(object sender, EventArgs e) { }
//        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Data.OleDb;

//namespace adiWFProject
//{
//    public partial class pupilForm : Form
//    {
//        public pupilForm()
//        {
//            InitializeComponent();
//        }

//        private void pupilForm_Load(object sender, EventArgs e)
//        {
//            // 1. רענון טבלת החניכים בגריד
//            RefreshGrid();

//            // 2. טעינת קומבו-בוקס מדריכים (comboBox1)
//            try
//            {
//                DataSet dsStaff = DbMain.GetAllRecord("staff");
//                if (dsStaff != null && dsStaff.Tables.Count > 0)
//                {
//                    comboBox1.DataSource = dsStaff.Tables[0];
//                    comboBox1.DisplayMember = "staffID";
//                    comboBox1.ValueMember = "staffID";
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("שגיאה בטעינת רשימת המדריכים: " + ex.Message);
//            }

//            // 3. טעינת קומבו-בוקס שבטים (comboBox2) מהטבלה 'tribes'
//            try
//            {
//                DataSet dsTribes = DbMain.GetAllRecord("tribes");
//                if (dsTribes != null && dsTribes.Tables.Count > 0)
//                {
//                    comboBox2.DataSource = dsTribes.Tables[0];
//                    comboBox2.DisplayMember = "tribeName";
//                    comboBox2.ValueMember = "tribeName";
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("שגיאה בטעינת רשימת השבטים: " + ex.Message);
//            }
//        }

//        // רענון הגריד על המסך
//        private void RefreshGrid()
//        {
//            try
//            {
//                DataSet ds = DbMain.GetAllRecord("pupil");
//                if (ds != null && ds.Tables.Count > 0)
//                {
//                    dataGridView.DataSource = ds.Tables[0];
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("שגיאה ברענון הנתונים: " + ex.Message);
//            }
//        }

//        // כפתור הוספה
//        private void add_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrEmpty(textBox1.Text))
//            {
//                MessageBox.Show("נא להזין ת.ז חניך");
//                return;
//            }

//            try
//            {
//                pupil p = new pupil();
//                p.PupilID = textBox1.Text;
//                p.PupilFullName = textBox2.Text;
//                p.BirthDate = dateTimePicker.Value;
//                p.SelfTribeName = comboBox2.Text;      // מתוך הקומבו-בוקס של השבטים
//                p.Address = textBox4.Text;
//                p.ParentPhoneNumber = textBox5.Text;
//                p.CityName = textBox6.Text;
//                p.SchoolName = textBox7.Text;
//                p.StaffID = comboBox1.Text;

//                p.Insert();

//                MessageBox.Show("חניך נוסף בהצלחה", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                RefreshGrid();
//                ClearAllFields();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("שגיאה בהוספת חניך: " + ex.Message);
//            }
//        }

//        // כפתור עדכון
//        private void update_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrEmpty(textBox1.Text))
//            {
//                MessageBox.Show("אנא בחרי חניך לעדכון");
//                return;
//            }

//            try
//            {
//                pupil p = new pupil();
//                p.PupilID = textBox1.Text;
//                p.PupilFullName = textBox2.Text;
//                p.BirthDate = dateTimePicker.Value;
//                p.SelfTribeName = comboBox2.Text;
//                p.Address = textBox4.Text;
//                p.ParentPhoneNumber = textBox5.Text;
//                p.CityName = textBox6.Text;
//                p.SchoolName = textBox7.Text;
//                p.StaffID = comboBox1.Text;

//                p.Update();

//                MessageBox.Show("פרטי חניך עודכנו בהצלחה", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                RefreshGrid();
//                ClearAllFields();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("שגיאה בעדכון חניך: " + ex.Message);
//            }
//        }

//        // כפתור מחיקה
//        private void CANCEL_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrEmpty(textBox1.Text))
//            {
//                MessageBox.Show("אנא בחרי חניך למחיקה מתוך הטבלה");
//                return;
//            }

//            try
//            {
//                pupil p = new pupil();
//                if (MessageBox.Show("האם למחוק חניך זה?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
//                {
//                    if (p.Delete(textBox1.Text))
//                    {
//                        MessageBox.Show("החניך נמחק בהצלחה", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                        RefreshGrid();
//                        ClearAllFields();
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("שגיאה במחיקת חניך: " + ex.Message);
//            }
//        }

//        // כפתור חיפוש
//        private void search_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrEmpty(textBox8.Text)) return;

//            pupil p = new pupil();
//            if (p.Found(textBox8.Text))
//            {
//                DataTable dt = p.GetInfoByIdKey(textBox8.Text).Tables[0];
//                textBox1.Text = dt.Rows[0]["pupilID"].ToString();
//                textBox2.Text = dt.Rows[0]["pupilName"].ToString();
//                comboBox2.Text = dt.Rows[0]["tribeName"].ToString();
//                textBox4.Text = dt.Rows[0]["address"].ToString();
//                textBox5.Text = dt.Rows[0]["parentPhone"].ToString();
//                textBox6.Text = dt.Rows[0]["cityName"].ToString();
//                textBox7.Text = dt.Rows[0]["schoolName"].ToString();
//                comboBox1.Text = dt.Rows[0]["staffID"].ToString();
//                dateTimePicker.Value = Convert.ToDateTime(dt.Rows[0]["birthDate"]);
//            }
//            else
//            {
//                MessageBox.Show("חניך לא נמצא");
//            }
//        }

//        // לחיצה על שורה בגריד - מילוי לפי שמות העמודות המדויקים באקסס למניעת קריסות
//        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {
//            FillFieldsFromGrid();
//        }

//        private void dataGridView_SelectionChanged(object sender, EventArgs e)
//        {
//            FillFieldsFromGrid();
//        }

//        // פונקציית העזר המתוקנת שמסנכרנת את השדות מהגריד בלי לקרוס
//        private void FillFieldsFromGrid()
//        {
//            if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Index >= 0)
//            {
//                DataGridViewRow row = dataGridView.CurrentRow;

//                textBox1.Text = row.Cells["pupilID"].Value?.ToString() ?? "";
//                textBox2.Text = row.Cells["pupilName"].Value?.ToString() ?? "";
//                comboBox2.Text = row.Cells["tribeName"].Value?.ToString() ?? "";
//                textBox4.Text = row.Cells["address"].Value?.ToString() ?? "";
//                textBox5.Text = row.Cells["parentPhone"].Value?.ToString() ?? "";
//                textBox6.Text = row.Cells["cityName"].Value?.ToString() ?? "";
//                textBox7.Text = row.Cells["schoolName"].Value?.ToString() ?? "";
//                comboBox1.Text = row.Cells["staffID"].Value?.ToString() ?? "";

//                if (row.Cells["birthDate"].Value != null && row.Cells["birthDate"].Value != DBNull.Value)
//                {
//                    dateTimePicker.Value = Convert.ToDateTime(row.Cells["birthDate"].Value);
//                }
//            }
//        }

//        // ניקוי שדות
//        private void ClearAllFields()
//        {
//            textBox1.Clear();
//            textBox2.Clear();
//            textBox4.Clear();
//            textBox5.Clear();
//            textBox6.Clear();
//            textBox7.Clear();
//            textBox8.Clear();
//            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
//            if (comboBox2.Items.Count > 0) comboBox2.SelectedIndex = 0;
//            dateTimePicker.Value = DateTime.Now;
//        }

//        // פונקציות ריקות תואמות לדיזיינר
//        private void textBox1_TextChanged(object sender, EventArgs e) { }
//        private void textBox2_TextChanged(object sender, EventArgs e) { }
//        private void textBox3_TextChanged(object sender, EventArgs e) { }
//        private void textBox4_TextChanged(object sender, EventArgs e) { }
//        private void textBox5_TextChanged(object sender, EventArgs e) { }
//        private void textBox6_TextChanged(object sender, EventArgs e) { }
//        private void textBox7_TextChanged(object sender, EventArgs e) { }
//        private void textBox8_TextChanged(object sender, EventArgs e) { }
//        private void textBox9_TextChanged(object sender, EventArgs e) { }
//        private void dateTimePicker_ValueChanged(object sender, EventArgs e) { }
//        private void address_Click(object sender, EventArgs e) { }
//        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
//    }
//}
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Data.OleDb;

//namespace adiWFProject
//{
//    public partial class pupilForm : Form
//    {
//        public pupilForm()
//        {
//            InitializeComponent();
//        }

//        private void pupilForm_Load(object sender, EventArgs e)
//        {
//            // 1. טעינת הנתונים לתוך ה-DataGridView
//            RefreshGrid();

//            try
//            {
//                // 2. שליפת רשימת המדריכים באמצעות מחלקת התשתית המרכזית שלך
//                DataSet dsStaff = DbMain.GetAllRecord("staff");

//                if (dsStaff != null && dsStaff.Tables.Count > 0)
//                {
//                    // 3. קישור הנתונים ל-ComboBox של ת.ז המדריך
//                    comboBox1.DataSource = dsStaff.Tables[0];

//                    // הגדרת הערכים להצגה ולשמירה
//                    comboBox1.DisplayMember = "staffID";
//                    comboBox1.ValueMember = "staffID";
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("שגיאה בטעינת רשימת המדריכים לתיבה הנפתחת: " + ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        // פונקציה לרענון ה-DataGridView על המסך
//        private void RefreshGrid()
//        {
//            try
//            {
//                // שימוש במחלקה DbMain כדי למשוך את כל הטבלה המעודכנת
//                DataSet ds = DbMain.GetAllRecord("pupil");
//                if (ds != null && ds.Tables.Count > 0)
//                {
//                    dataGridView.DataSource = ds.Tables[0];
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("שגיאה ברענון הנתונים בגריד: " + ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        // כפתור הוספת חניך
//        private void add_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrEmpty(textBox1.Text))
//            {
//                MessageBox.Show("נא להזין ת.ז חניך", "קלט חסר", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            try
//            {
//                pupil p = new pupil();
//                p.PupilID = textBox1.Text;             // ת.ז חניך
//                p.PupilFullName = textBox2.Text;       // שם מלא
//                p.BirthDate = dateTimePicker.Value;    // תאריך לידה
//                p.SelfTribeName = textBox3.Text;       // שם שבט
//                p.Address = textBox4.Text;             // כתובת
//                p.ParentPhoneNumber = textBox5.Text;   // טלפון הורים
//                p.CityName = textBox6.Text;            // עיר
//                p.SchoolName = textBox7.Text;          // בית ספר
//                p.StaffID = comboBox1.Text;            // ת.ז מדריך

//                p.Insert();

//                MessageBox.Show("החניך נוסף בהצלחה!", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                RefreshGrid();
//                ClearAllFields();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("הוספת החניך נכשלה. ודאי שכל הנתונים תקינים: " + ex.Message, "שגיאת מערכת", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        // כפתור עדכון חניך
//        private void update_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrEmpty(textBox1.Text))
//            {
//                MessageBox.Show("אנא בחרי חניך מתוך הטבלה או הזיני ת.ז לעדכון", "קלט חסר", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            try
//            {
//                pupil p = new pupil();
//                p.PupilID = textBox1.Text;
//                p.PupilFullName = textBox2.Text;
//                p.BirthDate = dateTimePicker.Value;
//                p.SelfTribeName = textBox3.Text;
//                p.Address = textBox4.Text;
//                p.ParentPhoneNumber = textBox5.Text;
//                p.CityName = textBox6.Text;
//                p.SchoolName = textBox7.Text;
//                p.StaffID = comboBox1.Text;

//                p.Update();

//                MessageBox.Show("פרטי החניך עודכנו בהצלחה!", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                RefreshGrid();
//                ClearAllFields();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("עדכון פרטי החניך נכשל: " + ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        // כפתור מחיקת חניך
//        private void CANCEL_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrEmpty(textBox1.Text))
//            {
//                MessageBox.Show("אנא בחרי חניך למחיקה", "קלט חסר", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            if (MessageBox.Show("האם את בטוחה שברצונך למחוק חניך זה מהמערכת?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
//            {
//                try
//                {
//                    pupil p = new pupil();
//                    p.Delete(Convert.ToInt32(textBox1.Text));

//                    MessageBox.Show("החניך נמחק מהמערכת בהצלחה!", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    RefreshGrid();
//                    ClearAllFields();
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show("מחיקת החניך נכשלה: " + ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//            }
//        }

//        // כפתור חיפוש חניך לפי ת.ז
//        private void search_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrEmpty(textBox8.Text))
//            {
//                MessageBox.Show("אנא הכניסי ת.ז בתיבת החיפוש", "קלט חסר", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            pupil p = new pupil();
//            if (p.Found(textBox8.Text))
//            {
//                DataTable dt = p.GetInfoByIdKey(textBox8.Text).Tables[0];
//                textBox1.Text = dt.Rows[0]["pupilID"].ToString();
//                textBox2.Text = dt.Rows[0]["pupilFullName"].ToString();
//                textBox3.Text = dt.Rows[0]["selfTribeName"].ToString();
//                textBox4.Text = dt.Rows[0]["address"].ToString();
//                textBox5.Text = dt.Rows[0]["parentPhoneNumber"].ToString();
//                textBox6.Text = dt.Rows[0]["cityName"].ToString();
//                textBox7.Text = dt.Rows[0]["schoolName"].ToString();
//                comboBox1.Text = dt.Rows[0]["staffID"].ToString();

//                if (dt.Rows[0]["birthDate"] != DBNull.Value)
//                {
//                    dateTimePicker.Value = Convert.ToDateTime(dt.Rows[0]["birthDate"]);
//                }
//            }
//            else
//            {
//                MessageBox.Show("החניך המבוקש לא נמצא במערכת", "לא נמצא", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            }
//        }

//        // לחיצה על שורה בגריד - מעדכנת את שדות הטקסט בטופס
//        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {
//            FillFieldsFromGrid();
//        }

//        private void dataGridView_SelectionChanged(object sender, EventArgs e)
//        {
//            FillFieldsFromGrid();
//        }

//        // פונקציית עזר למילוי השדות מתוך השורה הנבחרת בגריד
//        private void FillFieldsFromGrid()
//        {
//            if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Index >= 0)
//            {
//                DataGridViewRow row = dataGridView.CurrentRow;

//                textBox1.Text = row.Cells["pupilID"].Value?.ToString() ?? "";
//                textBox2.Text = row.Cells["pupilFullName"].Value?.ToString() ?? "";
//                textBox3.Text = row.Cells["selfTribeName"].Value?.ToString() ?? "";
//                textBox4.Text = row.Cells["address"].Value?.ToString() ?? "";
//                textBox5.Text = row.Cells["parentPhoneNumber"].Value?.ToString() ?? "";
//                textBox6.Text = row.Cells["cityName"].Value?.ToString() ?? "";
//                textBox7.Text = row.Cells["schoolName"].Value?.ToString() ?? "";
//                comboBox1.Text = row.Cells["staffID"].Value?.ToString() ?? "";

//                if (row.Cells["birthDate"].Value != null && row.Cells["birthDate"].Value != DBNull.Value)
//                {
//                    dateTimePicker.Value = Convert.ToDateTime(row.Cells["birthDate"].Value);
//                }
//            }
//        }

//        // פונקציית עזר לניקוי השדות לאחר פעולה מוצלחת
//        private void ClearAllFields()
//        {
//            textBox1.Clear();
//            textBox2.Clear();
//            textBox3.Clear();
//            textBox4.Clear();
//            textBox5.Clear();
//            textBox6.Clear();
//            textBox7.Clear();
//            textBox8.Clear();
//            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
//            dateTimePicker.Value = DateTime.Now;
//        }

//        // פונקציות ריקות למניעת שגיאות קישור במעצב
//        private void textBox1_TextChanged(object sender, EventArgs e) { }
//        private void textBox2_TextChanged(object sender, EventArgs e) { }
//        private void textBox3_TextChanged(object sender, EventArgs e) { }
//        private void textBox4_TextChanged(object sender, EventArgs e) { }
//        private void textBox5_TextChanged(object sender, EventArgs e) { }
//        private void textBox6_TextChanged(object sender, EventArgs e) { }
//        private void textBox7_TextChanged(object sender, EventArgs e) { }
//        private void textBox8_TextChanged(object sender, EventArgs e) { }
//        private void textBox9_TextChanged(object sender, EventArgs e) { }
//        private void dateTimePicker_ValueChanged(object sender, EventArgs e) { }
//        private void address_Click(object sender, EventArgs e) { }
//        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
//    }
//}

///*
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//namespace adiWFProject
//{
//    public partial class pupilForm : Form
//    {
//        public pupilForm()
//        {
//            InitializeComponent();
//        }
//        private DataRow GetSelectedRow()
//        {//-dataGrid מחזירה את השורה הנבחרת ב
//            DataTable dt = null;
//            if (dataGridView.DataSource is DataTable)
//                dt = dataGridView.DataSource as DataTable;
//            else if (dataGridView.DataSource is BindingSource)
//                dt = ((DataSet)((BindingSource)dataGridView.DataSource).DataSource).Tables[0];
//            else
//                return null;

//            return dt.Rows[this.dataGridView.CurrentRow.Index];
//        }

//        private void CANCEL_Click(object sender, EventArgs e)
//        {
//            DataRow dr = GetSelectedRow();
//            if (dr == null)
//                return;
//            pupil db = new pupil();
//            if (MessageBox.Show("למחוק את הרשומה?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
//            {
//                db.Delete(Convert.ToInt32(dr["pupilID"]));

//            }
//            dataGridView.DataSource = DbMain.GetAllRecord("pupil").Tables[0];

//        }

//        private void add_Click(object sender, EventArgs e)
//        {
//            pupil editPupil = new pupil();
//            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || dateTimePicker.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
//            {
//                MessageBox.Show("Fill in all the fields");
//            }

//            else
//            {
//                editPupil.PupilID = textBox1.Text;
//                editPupil.PupilName = textBox2.Text;
//                editPupil.TribeName = textBox3.Text;
//                editPupil.Address = textBox4.Text;
//                editPupil.ParentPhone = textBox5.Text;
//                editPupil.CityName = textBox6.Text;
//                editPupil.SchoolName = textBox7.Text;
//                editPupil.StaffID = textBox8.Text;
//                editPupil.BirthDate = Convert.ToDateTime(DateTime.Today);
//                DialogResult result = System.Windows.Forms.DialogResult.OK;

//                if (result == System.Windows.Forms.DialogResult.OK)
//                {
//                    editPupil.Insert();
//                    MessageBox.Show("Pupil Data Updated Successfully");
//                        dataGridView.DataSource = DbMain.GetAllRecord("pupil").Tables[0];
//                }
//            }
//        }

//        private void update_Click(object sender, EventArgs e)
//        {
//            pupil editPupil = new pupil();
//            editPupil.PupilID = textBox1.Text;
//            editPupil.PupilName = textBox2.Text;
//            editPupil.TribeName = textBox3.Text;
//            editPupil.Address = textBox4.Text;
//            editPupil.ParentPhone = textBox5.Text;
//            editPupil.CityName = textBox6.Text;
//            editPupil.SchoolName = textBox7.Text;
//            editPupil.StaffID = textBox8.Text;
//            editPupil.BirthDate = Convert.ToDateTime(DateTime.Today);
//            //  editCustomers.EntryDate = "";

//            DialogResult result = System.Windows.Forms.DialogResult.OK;
//            if (result == System.Windows.Forms.DialogResult.OK)
//            {
//                editPupil.Update();
//                MessageBox.Show("update Customer");
//                dataGridView.DataSource = DbMain.GetAllRecord("pupil").Tables[0];
//            }
//        }

//        private void search_Click(object sender, EventArgs e)
//        {
//            //קולט ת.ז לקוח ומחזיר את נתוניו 
//            pupil db = new pupil();
//            int id = int.Parse(textBox9.Text);

//            if (db.Found(id) != true)
//            {
//                MessageBox.Show(("לא נמצא לקוח בעל מספר זה") + " " + id);
//            }

//            else
//            {
//                DataTable ds = db.GetInfoByIdKey(id).Tables[0];

//                textBox1.Text = ds.Rows[0]["pupilID"].ToString();
//                textBox2.Text = ds.Rows[0]["pupilName"].ToString();
//                textBox3.Text = ds.Rows[0]["tribeNAme"].ToString();
//                textBox4.Text = ds.Rows[0]["address"].ToString();
//                textBox5.Text = ds.Rows[0]["parentPhone"].ToString();
//                textBox6.Text = ds.Rows[0]["cityName"].ToString();
//                textBox7.Text = ds.Rows[0]["schoolName"].ToString();
//                textBox8.Text = ds.Rows[0]["staffID"].ToString();

//            }
//        }

//        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
//        {

//        }
//        private void textBox1_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void textBox3_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void textBox4_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void textBox6_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void textBox5_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void textBox8_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void textBox2_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void textBox7_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void textBox9_TextChanged(object sender, EventArgs e)
//        {

//        }
//        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {

//        }

//        private void pupilForm_Load(object sender, EventArgs e)
//        {

//        }

//        private void address_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}

//*/










////using System;
////using System.Collections.Generic;
////using System.ComponentModel;
////using System.Data;
////using System.Drawing;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;
////using System.Windows.Forms;
////using System.Data.OleDb;

////namespace adiWFProject
////{
////    public partial class pupilForm : Form
////    {
////        public pupilForm()
////        {
////            InitializeComponent();
////        }

////        private void pupilForm_Load(object sender, EventArgs e)
////        {
////            RefreshGrid();

////            // מחפש את הקובץ בתיקייה שבה רצה התוכנה (bin/Debug)
////            string dbPath = Application.StartupPath + "\\Database1.accdb";
////            string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";

////            using (OleDbConnection conn = new OleDbConnection(connectionString))
////            {
////                try
////                {
////                    // 2. שאילתת ה-SQL לשליפת הנתונים
////                    string query = "SELECT staffID FROM staff";
////                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);

////                    // 3. יצירת טבלה בזיכרון (DataTable) ומילויה
////                    DataTable dt = new DataTable();
////                    adapter.Fill(dt);

////                    // 4. קישור הנתונים ל-ComboBox
////                    comboBox1.DataSource = dt;

////                    // מה המשתמש יראה בעיניים
////                    comboBox1.DisplayMember = "staffID";

////                    // מה הערך שיישמר "מאחורי הקלעים" (למשל ה-ID)
////                    comboBox1.ValueMember = "staffID";
////                }
////                catch (Exception ex)
////                {
////                    MessageBox.Show("שגיאה בחיבור למסד הנתונים: " + ex.Message);
////                }
////            }
////        }

////        private void RefreshGrid()
////        {
////            try
////            {
////                // שימוש במחלקה DbMain כדי למשוך את כל הטבלה
////                dataGridView.DataSource = DbMain.GetAllRecord("pupil").Tables[0];
////            }
////            catch (Exception ex)
////            {
////                MessageBox.Show("שגיאה בטעינת הנתונים: " + ex.Message);
////            }
////        }

////        private void add_Click(object sender, EventArgs e)
////        {
////            if (string.IsNullOrEmpty(textBox1.Text))
////            {
////                MessageBox.Show("נא להזין ת.ז חניך");
////                return;
////            }

////            pupil p = new pupil();
////            p.PupilID = textBox1.Text;             // ת.ז חניך
////            p.PupilFullName = textBox2.Text;       // שם מלא
////            p.BirthDate = dateTimePicker.Value;    // תאריך לידה
////            p.SelfTribeName = textBox3.Text;       // שם שבט
////            p.Address = textBox4.Text;             // כתובת
////            p.ParentPhoneNumber = textBox5.Text;   // טלפון הורים
////            p.CityName = textBox6.Text;            // עיר
////            p.SchoolName = textBox7.Text;          // בית ספר
////            p.StaffID = comboBox1.Text;             // ת.ז מדריך

////            p.Insert();
////            MessageBox.Show("חניך נוסף בהצלחה");
////            RefreshGrid();
////        }

////        private void update_Click(object sender, EventArgs e)
////        {
////            pupil p = new pupil();
////            p.PupilID = textBox1.Text;
////            p.PupilFullName = textBox2.Text;
////            p.BirthDate = dateTimePicker.Value;
////            p.SelfTribeName = textBox3.Text;
////            p.Address = textBox4.Text;
////            p.ParentPhoneNumber = textBox5.Text;
////            p.CityName = textBox6.Text;
////            p.SchoolName = textBox7.Text;
////            p.StaffID = comboBox1.Text;

////            p.Update();
////            MessageBox.Show("פרטי חניך עודכנו");
////            RefreshGrid();
////        }

////        private void CANCEL_Click(object sender, EventArgs e)
////        {
////            if (string.IsNullOrEmpty(textBox1.Text)) return;

////            pupil p = new pupil();
////            if (MessageBox.Show("האם למחוק חניך זה?", "אישור מחיקה", MessageBoxButtons.YesNo) == DialogResult.Yes)
////            {
////                p.Delete(textBox1.Text);
////                RefreshGrid();
////            }
////        }

////        private void search_Click(object sender, EventArgs e)
////        {
////            if (string.IsNullOrEmpty(textBox8.Text)) return; // תיבת חיפוש

////            pupil p = new pupil();
////            if (p.Found(textBox8.Text))
////            {
////                DataTable dt = p.GetInfoByIdKey(textBox8.Text).Tables[0];
////                textBox1.Text = dt.Rows[0]["pupilID"].ToString();
////                textBox2.Text = dt.Rows[0]["pupilFullName"].ToString();
////                textBox3.Text = dt.Rows[0]["selfTribeName"].ToString();
////                textBox4.Text = dt.Rows[0]["address"].ToString();
////                textBox5.Text = dt.Rows[0]["parentPhoneNumber"].ToString();
////                textBox6.Text = dt.Rows[0]["cityName"].ToString();
////                textBox7.Text = dt.Rows[0]["schoolName"].ToString();
////                comboBox1.Text = dt.Rows[0]["staffID"].ToString();
////                dateTimePicker.Value = Convert.ToDateTime(dt.Rows[0]["birthDate"]);
////            }
////            else
////            {
////                MessageBox.Show("חניך לא נמצא");
////            }
////        }

////        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
////        {
////            if (dataGridView.CurrentRow != null)
////            {
////                // מילוי התיבות מהשורה שנבחרה בגריד
////                textBox1.Text = dataGridView.CurrentRow.Cells["pupilID"].Value.ToString();
////                textBox2.Text = dataGridView.CurrentRow.Cells["pupilFullName"].Value.ToString();
////            }
////        }

////        // פונקציות ריקות כדי למנוע שגיאות אם הן מקושרות ב-Designer
////        private void textBox1_TextChanged(object sender, EventArgs e) { }
////        private void textBox2_TextChanged(object sender, EventArgs e) { }
////        private void textBox3_TextChanged(object sender, EventArgs e) { }
////        private void textBox4_TextChanged(object sender, EventArgs e) { }
////        private void textBox5_TextChanged(object sender, EventArgs e) { }
////        private void textBox6_TextChanged(object sender, EventArgs e) { }
////        private void textBox7_TextChanged(object sender, EventArgs e) { }
////        private void textBox8_TextChanged(object sender, EventArgs e) { }
////        private void textBox9_TextChanged(object sender, EventArgs e) { }
////        private void dateTimePicker_ValueChanged(object sender, EventArgs e) { }
////        private void address_Click(object sender, EventArgs e) { }
////        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
////        {
////        }
////    }
////}