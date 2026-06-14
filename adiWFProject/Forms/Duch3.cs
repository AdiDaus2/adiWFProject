using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace adiWFProject
{
    public partial class Duch3 : Form
    {
        public Duch3()
        {
            InitializeComponent();
        }

        // טעינת הטופס - שליפת הטיולים ישירות מטבלת journies
        private void Duch3_Load(object sender, EventArgs e)
        {
            cmJourney.Items.Clear();
            lblTotalRegistered.Text = "סך הכל רשומים לטיול: 0";

            try
            {
                string sqlJourneys = "SELECT journeyName FROM journies";
                DataTable dtJourneys = DbMain.GetTable(sqlJourneys);

                if (dtJourneys != null && dtJourneys.Rows.Count > 0)
                {
                    foreach (DataRow row in dtJourneys.Rows)
                    {
                        if (row["journeyName"] != DBNull.Value)
                        {
                            cmJourney.Items.Add(row["journeyName"].ToString());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("לא נמצאו טיולים בטבלת journies באקסס.", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בטעינת הטיולים מהאקסס:\n" + ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            chartTribes.Series.Clear();
            chartTribes.Titles.Clear();
            chartTribes.Titles.Add("כמות נרשמים לטיול לפי שבט");
        }

        // פונקציית השאילתה וטעינת הנתונים לגרף העמודות
        private void LoadChartData()
        {
            if (cmJourney.SelectedItem == null) return;

            string selectedJourney = cmJourney.SelectedItem.ToString();

            chartTribes.Series.Clear();

            Series series = new Series("חניכים");
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.String;
            series.YValueType = ChartValueType.Int32;
            series.IsValueShownAsLabel = true;

            // שאילתת SQL עם סידור סוגריים מדויק עבור ה-INNER JOIN המשולש באקסס
            string sql = $@"SELECT pupil.tribeName, COUNT(pupil.pupilID) AS RegisteredCount
                            FROM journies INNER JOIN (pupil INNER JOIN journiesRegisting ON pupil.pupilID = journiesRegisting.pupilID) 
                            ON journies.journeyCode = journiesRegisting.journeyCode
                            WHERE journies.journeyName = '{selectedJourney}'
                            GROUP BY pupil.tribeName";

            DataTable dt = DbMain.GetTable(sql);

            int totalSum = 0;

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string tribe = row["tribeName"] != DBNull.Value ? row["tribeName"].ToString() : "ללא שבט";
                    int count = Convert.ToInt32(row["RegisteredCount"]);

                    series.Points.AddXY(tribe, count);
                    totalSum += count;
                }

                chartTribes.Series.Add(series);
            }
            else
            {
                series.Points.AddXY("אין נרשמים", 0);
                chartTribes.Series.Add(series);
            }

            lblTotalRegistered.Text = $"סך הכל רשומים לטיול: {totalSum}";
        }

        private void cmJourney_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChartData();
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
//    public partial class Duch3 : Form
//    {
//        public Duch3()
//        {
//            InitializeComponent();
//        }

//    }
//}
