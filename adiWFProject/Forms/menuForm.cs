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

namespace adiWFProject.Forms
{
    public partial class menuForm : Form
    {
        string lastName1 = "";

        public menuForm(string firstName, string lastName)
        {
            InitializeComponent();
            label1.Text = firstName;
            label2.Text = lastName;
            lastName1 = lastName;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
        }

        private void menuForm_Load(object sender, EventArgs e)
        {

        }

        private void חניכיםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pupilForm ap = new pupilForm();
            ap.Show();
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
// מוודא שיש גישה לקבצים בתיקייה הראשית
using adiWFProject;

namespace adiWFProject.Forms
{
    public partial class menuForm : Form
    {
        private string _userType;
        public menuForm(string name, string userType)
        {
            InitializeComponent();

            label1.Text = name;
            label2.Text = (userType == "staff") ? "סטטוס: מדריך" : "סטטוס: חניך";

            label1.Visible = true;
            label2.Visible = true;

            _userType = userType;

            // הגדרת טקסטים
            //toolStripMenuItem1.Text = "רישום חניך חדש";

            // --- שורות הקישור הקריטיות ---
            // קישור לכפתור הרישום
            //this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);

            // קישור לכפתור ההתנתקות (חובה כדי שזה יעבוד!)
            this.התנתקותToolStripMenuItem.Click += new System.EventHandler(this.התנתקותToolStripMenuItem_Click);
        }

        private void menuForm_Load(object sender, EventArgs e)
        {
            if (_userType == "pupil")
            {
                SetPupilPermissions();
            }
        }

        private void SetPupilPermissions()
        {
            חניכיםToolStripMenuItem.Visible = true;
            חניכיםToolStripMenuItem.Text = "תפריט חניך";
            //toolStripMenuItem1.Visible = true;
        }

        // --- כפתור התנתקות ---
        // וודא שב-Designer לחצת פעמיים על כפתור ההתנתקות ושזה השם של הפונקציה שנוצרה
        private void התנתקותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // הפקודה הזו סוגרת את הכל ומפעילה את ה-Program.cs מחדש (כלומר את ה-Login)
            Application.Restart();
        }

        // פתיחת טופס רישום למסעות
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        // כפתור חניכים (למדריך בלבד)
        private void חניכיםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                pupilForm pp = new pupilForm();
                pp.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בפתיחת הטופס: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        { // כאשר אני לוחצת על הכפתור של חניכים זה מוביל FORM שנכתוב כאן
            if (_userType == "staff")
            {
                //pupilForm ap = new pupilForm();
                //activitiesForm activities = new activitiesForm();
                //activityReportForm activityReport = new activityReportForm();

                //activityReport.Show();
                //activities.Show();
                //ap.Show();
            }
        }

        private void רישוםלמסעToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                journiesRegistingForm jrf = new journiesRegistingForm();
                jrf.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בפתיחת הטופס: " + ex.Message);
            }
        }

        private void מסעחדשToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                journiesForm jf = new journiesForm();
                jf.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בפתיחת הטופס: " + ex.Message);
            }
        }

        private void דווחעלפעולהToolStripMenuItem_Click(object sender, EventArgs e)
        {
           try
            {
                activitiesForm af = new activitiesForm();
                af.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בפתיחת הטופס: " + ex.Message);
            }
        }

        private void חוותדעתעלהפעולהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                activityReportForm arf = new activityReportForm();
                arf.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בפתיחת הטופס: " + ex.Message);
            }
        }
    }
}