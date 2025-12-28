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
    public partial class ProductCatalog : Form
    {
        public ProductCatalog()
        {
            InitializeComponent();
        }

        private void ProductCatalog_Load(object sender, EventArgs e)
        {

            label7.Text = DateTime.Now.ToShortDateString();
            Item db = new Item();
            //מחרוזת SQL לשליפת הנתונים הרצויים
            string s = "SELECT item.[itemID], item.[itemName], item.[quantity], item.[price], item.[ganre], item.[supplierID], item.[lang]FROM item ORDER BY item.[itemName]"; 
            //האוביקט dt מכיל את נתוני השאילתה 
            DataTable dt = DbMain.ReturnDS(s).Tables[0];

            label1.Text = dt.Rows.Count.ToString();//מספר השורות בדוח
            //שליפת הנתונים לפקד listview
            foreach (DataRow dr in dt.Rows)
            {    //
                ListViewItem item = new ListViewItem((dr["itemID"].ToString()));

                item.SubItems.Add(dr["itemName"].ToString());
                item.SubItems.Add(dr["quantity"].ToString());
                item.SubItems.Add(dr["price"].ToString());
                item.SubItems.Add(dr["ganre"].ToString());
                item.SubItems.Add(dr["supplierID"].ToString());
                item.SubItems.Add(dr["lang"].ToString());
                listView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            int stratPrice = int.Parse(textBox1.Text);
            int endPrice = int.Parse(textBox2.Text);
            //מחרוזת SQL לשליפת הנתונים הרצויים
            string s = "select  Item.[itemID], Item.[itemName], Item.[quantity], Item.[price] from Item  ";
            s += " where Item.[price] BETWEEN " + stratPrice + " and  " + endPrice ;
            //האוביקט dt מכיל את נתוני השאילתה 
            DataTable dt = DbMain.ReturnDS(s).Tables[0];

            label1.Text = dt.Rows.Count.ToString();//מספר השורות בדוח
            //שליפת הנתונים לפקד listview
            foreach (DataRow dr in dt.Rows)
            {    //
                ListViewItem item = new ListViewItem((dr["itemID"].ToString()));

                item.SubItems.Add(dr["itemName"].ToString());
                item.SubItems.Add(dr["quantity"].ToString());
                item.SubItems.Add(dr["price"].ToString());

                listView1.Items.Add(item);
            }
        }
    }
}
