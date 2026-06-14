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
    public partial class Duch2 : Form
    {
        public Duch2()
        {
            InitializeComponent();
        }

        // טעינת הטופס - שליפת השבטים מטבלת [tribes]
        private void Duch2_Load(object sender, EventArgs e)
        {
            cmShevet.Items.Clear();

            try
            {
                string sqlTribes = "SELECT tribeName FROM [tribes]";
                DataTable dtTribes = DbMain.GetTable(sqlTribes);

                if (dtTribes != null && dtTribes.Rows.Count > 0)
                {
                    foreach (DataRow row in dtTribes.Rows)
                    {
                        if (row["tribeName"] != DBNull.Value)
                        {
                            cmShevet.Items.Add(row["tribeName"].ToString());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("הטבלה tribes קיימת באקסס אך היא ריקה.", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בטעינת השבטים מהאקסס:\n" + ex.Message, "שגיאת מבנה נתונים", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cmSort.Items.Count > 0)
            {
                cmSort.SelectedIndex = 0;
            }

            dgvPupils.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPupils.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPupils.ReadOnly = true;
            dgvPupils.AllowUserToAddRows = false;

            lblPupilCount.Text = "חניכים בשבט: 0";
            lblYoungest.Text = "החניך הצעיר ביותר: -";
        }

        // פונקציית סינון וטעינה המותאמת ב-100% לאקסס שלך
        private void LoadPupilData()
        {
            if (cmShevet.SelectedItem == null) return;

            string selectedShevet = cmShevet.SelectedItem.ToString();

            // ברירת מחדל: מיון לפי תאריך לידה (הצעיר ביותר למעלה)
            string orderByField = "birthDate DESC";

            if (cmSort.SelectedItem != null)
            {
                string selectedSort = cmSort.SelectedItem.ToString();

                switch (selectedSort)
                {
                    case "תאריך לידה":
                        orderByField = "birthDate DESC";
                        break;
                    case "שמות פרטיים":
                    case "שמות משפחה": // מכיוון שיש לך רק שדה אחד לשם, שניהם ימיינו לפי pupilName
                        orderByField = "pupilName ASC";
                        break;
                    case "כתובת":
                        orderByField = "address ASC";
                        break;
                    case "בית ספר":
                        orderByField = "schoolName ASC";
                        break;
                }
            }

            // השאילתה המנצחת - רק עם שדות שקיימים אצלך בוודאות!
            string sql = $@"SELECT pupilID AS [תעודת זהות], 
                                   pupilName AS [שם חניך], 
                                   birthDate AS [תאריך לידה], 
                                   address AS [כתובת], 
                                   schoolName AS [בית ספר], 
                                   parentPhone AS [טלפון הורה],
                                   cityName AS [עיר]
                            FROM pupil
                            WHERE tribeName = '{selectedShevet}'
                            ORDER BY {orderByField}";

            DataTable dt = DbMain.GetTable(sql);

            if (dt != null)
            {
                dgvPupils.DataSource = dt;

                int count = dt.Rows.Count;
                lblPupilCount.Text = $"חניכים בשבט: {count}";

                if (count > 0)
                {
                    DateTime maxDate = DateTime.MinValue;
                    string youngestName = "-";

                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["תאריך לידה"] != DBNull.Value)
                        {
                            DateTime currentBirth = Convert.ToDateTime(row["תאריך לידה"]);
                            if (currentBirth > maxDate)
                            {
                                maxDate = currentBirth;
                                youngestName = row["שם חניך"].ToString();
                            }
                        }
                    }

                    lblYoungest.Text = $"החניך הצעיר ביותר: {youngestName}";
                }
                else
                {
                    lblYoungest.Text = "החניך הצעיר ביותר: -";
                }
            }
        }

        private void cmShevet_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPupilData();
        }

        private void cmSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPupilData();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
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

//namespace adiWFProject.Forms
//{
//    public partial class Duch2 : Form
//    {
//        public Duch2()
//        {
//            InitializeComponent();
//        }
//        private void cmShevet_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }
//        private void cmSort_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }
//    }
//}
