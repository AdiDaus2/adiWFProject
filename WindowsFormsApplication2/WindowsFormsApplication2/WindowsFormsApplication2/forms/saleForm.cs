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
    public partial class saleForm : Form
    {
        double cost = 0;// צבירת הסכום לתשלום
        public saleForm()
        {
            InitializeComponent();
           

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label15.Text = DateTime.Now.ToString();
            // ,מחשב מספר  של ההזמנה  חדשה  , בהוספת  1 למספר הזמנה אחרונה
            label12.Text = DbMain.GetQuery("SELECT Count(sales.salesID) AS [Count] FROM sales ").Tables[0].Rows[0][0].ToString();
            label12.Text = (int.Parse(label12.Text) + 1).ToString();
            


            Customer Dbcustomers1 = new Customer();
            Item Dbitem1 = new Item();



            comboBox1.DataSource = DbMain.GetAllRecord("customer").Tables[0];//fill combo
            comboBox1.ValueMember = "customerId";//שם הטור שיוצג
            comboBox2.DataSource = DbMain.GetAllRecord("item").Tables[0];//fill comboplier").Tables[0];//fill combo
            comboBox2.ValueMember = "itemID";//שם הטור שיוצג
            // בנית הטורים של הסל 
            dataGridView1.ColumnCount = 5;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns[0].Name = "מספר מוצר";
            dataGridView1.Columns[1].Name = "שם מוצר";
            dataGridView1.Columns[2].Name = "מחיר ";
            dataGridView1.Columns[3].Name = "כמות ";
            dataGridView1.Columns[4].Name = "סך למוצר ";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {//השלמת פרטי לקוח עם בחירת מספר לקוח
            string s = "select customerLastname, customerFirstname from customer where customerID=" + int.Parse(comboBox1.Text.ToString());
            DataTable ds = DbMain.GetQuery(s).Tables[0];

            if (ds == null)
            {
                MessageBox.Show("בחר מספר לקוח");
            }


            else
            {
                label10.Text = ds.Rows[0]["customerLastname"].ToString();
                label10.Text += "   " + ds.Rows[0]["customerFirstname"].ToString();
            }

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {//השלמת פרטי לקוח עם בחירת מספר לקוח
            string s = "select customerLastname,customerFirstname  from customer where customerID=" + int.Parse(comboBox1.Text.ToString());
            DataTable ds = DbMain.GetQuery(s).Tables[0];

            if (ds == null)
            {
                MessageBox.Show("בחר מספר לקוח");
            }


            else
            {
                label10.Text = ds.Rows[0]["customerLastname"].ToString();
                label10.Text += "   " + ds.Rows[0]["customerFirstname"].ToString();
            }
        }






        private void button1_Click(object sender, EventArgs e)
        {// הוספת שורה לסל

            if (int.Parse(numericUpDown1.Text) <= 0)
            {
                MessageBox.Show("Wanted Quantity Has To Be Bigger Than 0");
                return;
            }

            int n = int.Parse(numericUpDown1.Text);
            double orderCost = 0;

            //בדיקה אם מספר פריט קיים כבר בסל
            int id = -1;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (int.Parse(comboBox2.Text) == int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()))
                {
                    
                        id = i;

                }
            }
            if (id != -1)// מספר פריט קיים כבר בסל 
            {
                n = int.Parse(dataGridView1.Rows[id].Cells[3].Value.ToString());
                n+= (int)numericUpDown1.Value;
                dataGridView1.Rows[id].Cells[3].Value = n;
                orderCost = int.Parse(label4.Text) * (((int)numericUpDown1.Value));
                dataGridView1.Rows[id].Cells[4].Value = n* int.Parse(dataGridView1.Rows[id].Cells[2].Value.ToString());
                cost += orderCost;
            }
            else   //נקלט מספר פריט חדש
            {
                 orderCost = int.Parse(label4.Text) * (((int)numericUpDown1.Value));
                string[] row = new string[] { comboBox2.Text, label7.Text, label4.Text, numericUpDown1.Value.ToString(), orderCost.ToString() };
                dataGridView1.Rows.Add(row);
                
                cost += orderCost;
                
            }
            label13.Text = cost.ToString();
        }

        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "select itemName,quantity,price from item where itemID=" + int.Parse(comboBox2.Text.ToString());
            DataTable ds = DbMain.GetQuery(s).Tables[0];

            if (ds == null)
            {
                MessageBox.Show("בחר מספר לקוח");
            }


            else
            {
                label7.Text = ds.Rows[0]["itemName"].ToString();
                label4.Text =  ds.Rows[0]["price"].ToString();
                label11.Text = ds.Rows[0]["quantity"].ToString();
            }
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            string s = "select itemName,quantity,price from item where itemID=" + int.Parse(comboBox2.Text.ToString());
            DataTable ds = DbMain.GetQuery(s).Tables[0];

            if (ds == null)
            {
                MessageBox.Show("בחר מספר פריט");
            }


            else
            {
                label7.Text = ds.Rows[0]["itemName"].ToString();
                label4.Text =  ds.Rows[0]["price"].ToString();
                label11.Text =  ds.Rows[0]["quantity"].ToString();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  מחיקה שורות מסומנות מהסל
           
            //מספר השורות שסומנו
            int selectedCount = dataGridView1.SelectedRows.Count;
            //והאם השורה שסומנה אינה ריקה, סומנה שורה?
            if (selectedCount > 0 && dataGridView1.Rows.Count>1)           
                {
                int total = int.Parse(label13.Text);
                

           
                if (MessageBox.Show("? האם אתה בטוח כי ברצונך להוציא פריט זה מסל הקניות", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {

                }
                else
                {
                    while (selectedCount > 0)// נשתמש בלולאה ולא במשפט תנאי כדי לאפשר למחוק גם אם סומנו יותר שורה אחת
                    {

                        if (!dataGridView1.SelectedRows[0].IsNewRow)
                        {
                            total -= int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());// עידכון שדה סה"כ
                            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);//מחיקה מהסל 
                            selectedCount--;

                        }



                        label13.Text = total.ToString();
                        cost = total;


                    }
                }
            }
            //  או סומנה שורה ריקה לא סומנה שורה
            else
                MessageBox.Show("לא נמצאו פריטים להסרה");
        }

        private void button3_Click(object sender, EventArgs e)
        {//מחיקת הסל
            dataGridView1.Rows.Clear();
            cost = 0;
            label13.Text =int.Parse("0").ToString() ;
        }

        private void button4_Click(object sender, EventArgs e)
        {//הוספת הזמנה חדשה
            if (MessageBox.Show("? לשמור הזמנה", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            { }
            else
            {
                //    הוספת כותרת הזמנה   
                Sales db = new Sales();

                db.SaleDate = DateTime.Parse(label15.Text);
                db.CustomerId = int.Parse(comboBox1.Text);
                db.SaleTotal = double.Parse(label13.Text);
                db.Insert();


                //הוספת פרטי הזמנה
                SaleDetails db1 = null;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    db1 = new SaleDetails();
                    db1.SaleCode = int.Parse(label12.Text);
                    if (dataGridView1.Rows[i].Cells[0].Value != null)
                    {
                        db1.ItemCode = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    }
                    if (dataGridView1.Rows[i].Cells[3].Value != null)
                    {

                        db1.WantedQuantity = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());

                    }

                    db1.Insert();
                }

                    //עידכון המלאי
                    Item dbItem = new Item();
                    int itemCode=0;
                    int quantity = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        itemCode= int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        quantity=int.Parse(label11.Text) - int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                        dbItem.ItemCode = itemCode;
                        dbItem.Quantity = quantity;
                        dbItem.UpdateQuntity();
                    }




                MessageBox.Show("ההזמנה נקלטה");
                recButton.Visible = true;
            }
        }

        private void recButton_Click(object sender, EventArgs e)
        {
            receipt frm = new receipt(int.Parse(label12.Text));//קריאה לטופס קבלה עם מספר הזמנה
            frm.Show();
        }
    }
    }
   

