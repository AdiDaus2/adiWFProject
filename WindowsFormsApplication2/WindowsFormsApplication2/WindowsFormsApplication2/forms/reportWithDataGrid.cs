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
    public partial class reportWithDataGrid : Form
    {
        public reportWithDataGrid()
        {
            InitializeComponent();
        }
        string  s="";
        private void reportWithDataGrid_Load(object sender, EventArgs e)
        {
            s = "select * from worker";
            dataGridView1.DataSource = DbMain.GetQuery(s).Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filterValue = txtFilter.Text.Trim();

            if (string.IsNullOrEmpty(filterValue))
            {
                // אם אין ערך סינון, נטען את כל הנתונים
                dataGridView1.DataSource = DbMain.GetQuery(s).Tables[0];
            }
            else
            {
                // יצירת מסנן
                string filterExpression = $"JobTitle LIKE '%{filterValue}%'"; // סינון לפי עיר
                DataView dv = new DataView(DbMain.GetQuery(s).Tables[0]);
                dv.RowFilter = filterExpression;

                dataGridView1.DataSource = dv.ToTable(); // הצגת נתונים מסוננים
            }
        }
    }
}
