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
using System.Data.OleDb;
using adiWFProject.Forms;

namespace adiWFProject
{
    public partial class login : Form
    {
        public string firstName;

        public login()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            pupil Dbpupil = new pupil();
            string sql = "SELECT  * " + "FROM pupil " + "WHERE   pupilID = '" + loginID.Text + "'  and " + "parentPhone ='" + textBox2.Text +"'"  ;

            DataTable ds = DbMain.GetQuery(sql).Tables[0];
           

            if (ds == null)
            {
                MessageBox.Show("מספר טלפון או ת.ז לא תקינים");
            }
            else
            {
                loginMessage.Text = "שלום," + " " + ds.Rows[0]["pupilName"].ToString(); 
                firstName = ds.Rows[0]["pupilNAme"].ToString();
                enter.Visible = false;
                //loginContinue.Visible = true;
                loginMessage.Visible = true;
                //טעינת תמונה
                // pictureBox1.ImageLocation = ds.Rows[0]["workerPicture"].ToString();
                menuForm mF = new menuForm(firstName, "lavi");
                mF.Show();

            }
            //    pictureLocation = dataReader.GetString(5);
            //    if (password == loginPassword.Text)
            //    {
            //        loginMessage.Text = "שלום," + " " + firstName + " " + lastName;
            //        loginEnter.Visible = false;
            //        loginContinue.Visible = true;
            //        pictureBox1.ImageLocation = pictureLocation;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid password: ", "Error");
            //    }
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show("Select tblUsers failed \n" + err.Message, "Error",
            //    MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}             
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void loginMessage_Click(object sender, EventArgs e)
        {

        }

        private void loginID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
using System.Data.OleDb;
using adiWFProject.Forms;

namespace adiWFProject
{
    public partial class login : Form
    {
        public string firstName;

        public login()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            try
            {
                string id = loginID.Text;
                string password = textBox2.Text;
                string userType = ""; // ישמור אם זה חניך או מדריך
                string firstName = "";

                // בדיקה ראשונה: האם זה מדריך (Staff)?
                string sqlStaff = string.Format("SELECT staffFullName FROM staff WHERE staffID = '{0}' AND phoneNumber = '{1}'", id, password);
                DataSet dsStaff = DbMain.GetQuery(sqlStaff);

                if (dsStaff != null && dsStaff.Tables[0].Rows.Count > 0)
                {
                    userType = "staff";
                    firstName = dsStaff.Tables[0].Rows[0]["staffFullName"].ToString();
                }
                else
                {
                    // בדיקה שנייה: האם זה חניך (Pupil)?
                    string sqlPupil = string.Format("SELECT pupilName FROM pupil WHERE pupilID = '{0}' AND parentPhone = '{1}'", id, password);
                    DataSet dsPupil = DbMain.GetQuery(sqlPupil);

                    if (dsPupil != null && dsPupil.Tables[0].Rows.Count > 0)
                    {
                        userType = "pupil";
                        firstName = dsPupil.Tables[0].Rows[0]["pupilName"].ToString();
                    }
                }

                if (userType != "")
                {
                    MessageBox.Show("שלום " + firstName + ", התחברת כ" + (userType == "staff" ? "מדריך" : "חניך"));

                    // פתיחת התפריט והעברת סוג המשתמש
                    menuForm mF = new menuForm(firstName, userType);
                    mF.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("פרטי התחברות שגויים");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה: " + ex.Message);
            }
        }
        private void login_Load(object sender, EventArgs e)
        {
            // כאן אפשר להגדיר שתיבת הטקסט של הטלפון תסתיר תווים אם רוצים (כמו סיסמה)
            // textBox2.PasswordChar = '*';
        }

        // שאר האירועים הריקים נשמרים כדי שלא ימחקו מה-Designer
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void loginMessage_Click(object sender, EventArgs e) { }
        private void loginID_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
    }
}