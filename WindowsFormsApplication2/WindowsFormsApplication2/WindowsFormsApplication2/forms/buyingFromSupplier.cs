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
    public partial class buyingFromSupplier : Form
    {
        public buyingFromSupplier()
        {
            InitializeComponent();
        }

        private void buyingFromSupplier_Load(object sender, EventArgs e)
        {
            Supplier db = new Supplier();
            comboBox1.DataSource = DbMain.GetAllRecord("supplier").Tables[0];
            comboBox1.ValueMember = "supplierID";
        }

       //מספר ההזמנה תתמלא אם מספר הספק שלה שווה למספר הספק הנבחר ושתאריך מסירה ריק
            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {// ושנבחר ערך -comboBox1 is not null
                if (comboBox1.SelectedValue != null && int.TryParse(comboBox1.SelectedValue.ToString(), out int supplierId))
                {
                    string query = "SELECT * FROM buyFromSupplier WHERE ISNULL(receiveDate)=true  AND supplierId ="+ int.Parse(comboBox1.Text.ToString());

                    // שליחת שאילתה מאובטחת עם פרמטרים
                DataTable dt = DbMain.GetQuery(query).Tables[0];

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        comboBox2.DataSource = dt;
                        comboBox2.DisplayMember = "buyId"; // מה יוצג למשתמש
                        comboBox2.ValueMember = "buyId"; // הערך הפנימי
                    }
                    else
                    {
                        comboBox2.DataSource = null;
                    }
                }
                else
                {
                    comboBox2.DataSource = null;
                }
            }

        

        private void comboBox1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedValue != null && int.TryParse(comboBox1.SelectedValue.ToString(), out int supplierId))
            {
                string query = "SELECT * FROM buyFromSupplier WHERE ISNULL(receiveDate)=true  AND supplierId =" +int.Parse(comboBox1.Text.ToString()) ;

                // שליחת שאילתה מאובטחת עם פרמטרים
                DataTable dt = DbMain.GetQuery(query).Tables[0];

                if (dt != null && dt.Rows.Count > 0)
                {
                    comboBox2.DataSource = dt;
                    comboBox2.DisplayMember = "buyId"; // מה יוצג למשתמש
                    comboBox2.ValueMember = "buyId"; // הערך הפנימי
                }
                else
                {
                    comboBox2.DataSource = null;
                }
            }
            else
            {
                comboBox2.DataSource = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buyingFromSuplier db = new buyingFromSuplier();
            dataGridView1.DataSource = DbMain.GetQuery("select * from buyFromSupplier where buyId=" + int.Parse(comboBox2.Text.ToString())).Tables[0];
        }

        //עדכן מלאי ותאריך קבלת סחורה

        Item dbItem = new Item();
        int itemCode = 0;
        int quantity = 0;
       
        int curentQuantity = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                itemCode = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                quantity = int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());

                //שליפה  של הכמות הנוכחית של המוצר מהמלאי 
                string s = "select quantity from item where itemID = " + itemCode;
                DataTable ds = DbMain.GetQuery(s).Tables[0];
                curentQuantity = int.Parse(ds.Rows[0]["quantity"].ToString());
                dbItem.ItemCode = itemCode;
                dbItem.Quantity = curentQuantity + quantity;//חישוב הכמות החדשה 
               // if (MessageBox.Show( "נוספו  למלאי  " +quantity , "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                     dbItem.UpdateQuntity();
            }
        }
    }
}
