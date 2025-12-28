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
    public partial class Form3 : Form
    {

        private DataGridView cartDataGridView;
        private Label totalLabel;
        private Button checkoutButton;
        private decimal total = 0;
        private List<string> cartItems = new List<string>();

        public Form3()
        {
            this.Text = "חנות מקוונת";
            this.Size = new Size(600, 400);

            // יצירת עגלת קניות
            cartDataGridView = new DataGridView
            {
                Dock = DockStyle.Top,
                Height = 200,
                AllowUserToAddRows = false,
                ReadOnly = true,
                AutoGenerateColumns = false
            };

            cartDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CartProductName",
                HeaderText = "שם המוצר"
            });

            cartDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CartProductPrice",
                HeaderText = "מחיר"
            });

            // תווית סה"כ לתשלום
            totalLabel = new Label
            {
                Text = "סה\"כ לתשלום: 0 ₪",
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Height = 30
            };

            // כפתור לתשלום
            checkoutButton = new Button
            {
                Text = "סיים הזמנה",
                Dock = DockStyle.Bottom,
                Height = 40
            };

            checkoutButton.Click += CheckoutButton_Click;

            // הוספת רכיבים לטופס
            this.Controls.Add(cartDataGridView);
            this.Controls.Add(totalLabel);
            this.Controls.Add(checkoutButton);

            // הוספת מוצרים לדוגמה
            AddToCart("טלפון חכם", 3500);
            AddToCart("מחשב נייד", 5000);
        }

        private void AddToCart(string productName, decimal price)
        {
            cartDataGridView.Rows.Add(productName, price);
            cartItems.Add($"{productName} - {price} ₪");
            total += price;
            totalLabel.Text = $"סה\"כ לתשלום: {total} ₪";
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            SummaryForm checkoutForm = new SummaryForm(cartDataGridView, total);
            checkoutForm.ShowDialog();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
           
        }
    }
}
