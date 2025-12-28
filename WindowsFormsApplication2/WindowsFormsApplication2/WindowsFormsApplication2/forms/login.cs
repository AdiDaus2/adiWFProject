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


namespace WindowsFormsApplication2
{
    public partial class login : Form
    {
      //  private OleDbConnection dataConnection;

        // bool isManager;
        public string firstName;

        // private bool OpenDb()                                    //Open data base
        //{
        //    dataConnection = new OleDbConnection();
        //    try
        //    {
        //       // dataConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Projects_2017\\Project_ZZZ\\Access\\dbSchool.accdb";
        //        dataConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\access\\DBExm.accdb";
        //        dataConnection.Open();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Open data base failed" + ex.Message,
        //                         "Errors",
        //                         MessageBoxButtons.OK,
        //                         MessageBoxIcon.Error);
        //        return false;
        //    }
        //    }
        public login()
        {
            InitializeComponent();
        }

        private void buttCheck_Click(object sender, EventArgs e)
        {
            Customer Dbworker = new Customer();
            string sql = "SELECT  * " +
                                          "FROM    worker " +
                                          "WHERE   workerID = " + int.Parse(loginID.Text);// +"  and  "+
                                                                                           //  "pasword = '" + textBox2.Text +"'"  ;

            DataTable ds = DbMain.GetQuery(sql).Tables[0];

            if (ds == null)
            {
                MessageBox.Show("סיסמה או ת.ז לא תקינים");
            }
            else
            {

                //loginMessage.Text = "שלום," + " " + ds.Rows[0]["workerLastName"].ToString() +"  "+ ds.Rows[0]["workerFirstName"].ToString(); 
                firstName = ds.Rows[0]["workerFirstName"].ToString();
                string lastName = ds.Rows[0]["workerLastName"].ToString();
                buttCheck.Visible = false;
                //loginContinue.Visible = true;
                loginMessage.Visible = true;
                //טעינת תמונה
                // pictureBox1.ImageLocation = ds.Rows[0]["workerPicture"].ToString();
                MenuForm mF = new MenuForm(firstName, "lavi");
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

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        //private void login_Load(object sender, EventArgs e)
        //{

        //}

        //private void loginContinue_Click(object sender, EventArgs e)
        //{
        //    MenuForm mF = new MenuForm();
        //    mF.Show();
        //}
    }
}

