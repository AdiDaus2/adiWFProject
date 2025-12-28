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
    public partial class saleByKritaryon : Form
    {
        public saleByKritaryon()
        {
            InitializeComponent();
        }
        string s = "";
        private void button1_Click(object sender, EventArgs e)
        {
            string nameFilter = txtNameFilter.Text.Trim();
            string suplierFilter = txtsuplierFilter.Text.Trim();
            string minPriceFilter = txtminPrice.Text.Trim();
            string maxPriceFilter = txtmaxPrice.Text.Trim();

            List<string> filters = new List<string>(); // רשימה של תנאי הסינון

            if (!string.IsNullOrEmpty(nameFilter))
                filters.Add($"itemName LIKE '%{nameFilter}%'"); //  חיפוש לפי שם מוצר

            if (!string.IsNullOrEmpty(suplierFilter))
                filters.Add($"supplierID = {suplierFilter}"); // חיפוש לפי ספק

            if (int.TryParse(minPriceFilter, out int minPrice))
                filters.Add($"price >= {minPriceFilter}"); // סינון מחיר מינימלי

            if (int.TryParse(maxPriceFilter, out int maxPrice))
                filters.Add($"price <= {maxPrice}"); // סינון מחיר מקסימלי

            string filterExpression = string.Join(" AND ", filters); // חיבור כל התנאים עם AND

            DataView dv = new DataView( DbMain.GetQuery(s).Tables[0]);
            dv.RowFilter = filterExpression; // החלת הסינון

            dataGridView1.DataSource = dv.ToTable(); // הצגת הנתונים המסוננים אם לא קיים סינון יוצגו כל הנתונים
        }

        private void saleByKritaryon_Load(object sender, EventArgs e)
        {
            s = "SELECT item.itemID, item.itemName, item.quantity, item.price, item.discription, item.supplierID, supplier.supplierLastname ";
            s+= "   FROM supplier INNER JOIN item ON supplier.[supplierID] = item.[supplierID] ";
            dataGridView1.DataSource = DbMain.GetQuery(s).Tables[0];//הצגת כל הנתונים על פריטים
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
