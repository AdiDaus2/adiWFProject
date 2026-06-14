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
    public partial class Duch1 : Form
    {
        public Duch1()
        {
            InitializeComponent();
        }

        // טעינת הטופס - הגדרת נתוני פתיחה
        private void Duch1_Load(object sender, EventArgs e)
        {
            // טעינת רשימת גילאים (מגיל 9 עד 18)
            cmAge.Items.Clear();
            for (int i = 9; i <= 18; i++)
            {
                cmAge.Items.Add(i);
            }

            // הגדרת מאפייני הגריד כדי שייראה נקי
            dgvActivities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActivities.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActivities.ReadOnly = true;
            dgvActivities.AllowUserToAddRows = false;

            // איפוס הלייבלים בשלב הראשוני
            lblCount.Text = "נמצאו: 0 פעולות";
            lblTopAction.Text = "הדירוג הגבוה ביותר: -";
            lblTotalVotes.Text = "סך הכל מדרגים: 0";
        }

        // אירוע בחירת גיל בקומבו-בוקס המותאם לשם שלך!
        private void cmAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmAge.SelectedItem == null) return;

            int selectedAge = Convert.ToInt32(cmAge.SelectedItem);

            // שאילתת ה-SQL המקצועית שחיברנו שמחברת את הטבלאות וממיינת מהממוצע הגבוה לנמוך
            string sql = $@"SELECT a.activityNum AS [מספר פעולה], 
                                   a.activityDescraption AS [תיאור הפעולה], 
                                   ROUND(AVG(r.rating), 2) AS [דירוג ממוצע], 
                                   COUNT(r.rating) AS [כמות מדרגים]
                            FROM activities AS a INNER JOIN activityReport AS r 
                            ON a.activityNum = r.activityNum
                            WHERE a.minAge <= {selectedAge} AND a.maxAge >= {selectedAge}
                            GROUP BY a.activityNum, a.activityDescraption
                            ORDER BY AVG(r.rating) DESC";

            DataTable dt = DbMain.GetTable(sql);

            if (dt != null)
            {
                dgvActivities.DataSource = dt;

                int totalActivities = dt.Rows.Count;
                int totalVotesSum = 0;
                double topRating = 0;
                string topActionNum = "-";

                // מעבר על הרשומות לחישוב הנתונים הסטטיסטיים הצידיים
                foreach (DataRow row in dt.Rows)
                {
                    totalVotesSum += Convert.ToInt32(row["כמות מדרגים"]);

                    double currentRating = Convert.ToDouble(row["דירוג ממוצע"]);
                    if (currentRating > topRating)
                    {
                        topRating = currentRating;
                        topActionNum = row["מספר פעולה"].ToString();
                    }
                }

                // עדכון תוויות הטקסט על המסך בזמן אמת
                lblCount.Text = $"נמצאו {totalActivities} פעולות שמתאימות לגיל {selectedAge}";

                if (totalActivities > 0)
                {
                    lblTopAction.Text = $"הדירוג הגבוה ביותר הוא {topRating} של פעולה {topActionNum}";
                    lblTotalVotes.Text = $"{totalVotesSum} אנשים דירגו את הפעולות לגיל זה";
                }
                else
                {
                    lblTopAction.Text = "הדירוג הגבוה ביותר: -";
                    lblTotalVotes.Text = "0 אנשים דירגו";
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
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
//    public partial class Duch1 : Form
//    {
//        public Duch1()
//        {
//            InitializeComponent();
//        }
//        private void Duch1_Load(object sender, EventArgs e)
//        {
//        }
//    }
//}
