using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class salesTimeFrame : Form
    {
        public salesTimeFrame()
        {
            InitializeComponent();
        }

        private void salesTimeFrame_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortDateString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("הכנס טווח תאריכים   ");
                return;
            }
            DateTime startDate = DateTime.Parse(textBox1.Text);
            DateTime endDate = DateTime.Parse(textBox2.Text);
            

            startDate = startDate.Date;//השארת התאריך בלבד ללא השעה
            endDate = endDate.Date;
            //שינוי פורמט תאריך מתאים ל-access
            string formatstartDate = startDate.ToString("MM/dd/yyyy");
            string formatendDate = endDate.ToString("MM/dd/yyyy");
            //בדיקת תקינות
            if (startDate > endDate)
            {
                MessageBox.Show("תאריך ההתחלה חייב להיות קטן או שווה לתאריך הסיום.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            Item db = new Item();
            //מחרוזת SQL לשליפת הנתונים הרצויים
            string query = "SELECT sales.[salesID], sales.[salesDate], sales.[clientID], sales.[workerID], sales.[total] " +
               "FROM sales " +
               "WHERE sales.[salesDate] BETWEEN #" + formatstartDate + "# AND #"+ formatendDate + '#';
            //האוביקט dt מכיל את נתוני השאילתה 
            DataTable dt = DbMain.ReturnDS(query).Tables[0];

            double sum = 0;
            label2.Text = dt.Rows.Count.ToString();//מספר השורות בדוח
            //שליפת הנתונים לפקד listview
            foreach (DataRow dr in dt.Rows)
            {    //
                ListViewItem item = new ListViewItem((dr["salesID"].ToString()));

                item.SubItems.Add(dr["salesDate"].ToString());
                item.SubItems.Add(dr["clientID"].ToString());
                item.SubItems.Add(dr["total"].ToString());
                sum += int.Parse(dr["total"].ToString());
                listView1.Items.Add(item);
            }
            label5.Text = sum.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           textBox1.Text = dateTimePicker1.Value.Date.ToShortDateString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = dateTimePicker2.Value.Date.ToShortDateString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {//שחרור מספר הזמנה מתוך ה-listview
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string mainText = selectedItem.Text;
                // MessageBox.Show(mainText);
               // שליפת פירוט ההזמנה בשיתוף שליפת שם המוצר   
                string s = "SELECT salesDetails.salesDetailsID,item.itemID, item.itemName, salesDetails.amount ";
                       s+= " FROM item INNER JOIN salesDetails ON item.[itemID] = salesDetails.[itemID]  WHERE salesDetails.salesDetailsID =  " + int.Parse(mainText);
                dataGridView1.DataSource = DbMain.GetQuery(s).Tables[0];
                dataGridView1.Visible = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }
    }
}
