using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class saleWithPic : Form
    {
        private DataGridView productsDataGridView;
        private DataGridView cartDataGridView;
        private Label totalLabel;
        private Button removeButton; // כפתור להסרת מוצר מהסל
        private Dictionary<string, decimal> productPrices;
        private Dictionary<string, string> productImages;
        private decimal total = 0;
        private Image defaultImage;  // תמונת ברירת מחדל
        private string imagePathFolder = "picture"; // *תיקיית התמונות
        private List<string> cartItems = new List<string>();
        private Button checkoutButton; // כפתור מעבר לקופה

        public saleWithPic()
        {
            InitializeComponent();



            this.Text = "חנות מקוונת";
            this.Size = new Size(800, 500);

            //* יצירת רשימת מוצרים עם מחירים
            productPrices = new Dictionary<string, decimal>
        {
            { "אייפון", 3500 },
            { "מילקשייק", 5000 },
            { "טלוויזיה", 2500 }
        };

            //*חייב להיות תואם לרשימת המוצרים- יצירת מילון לתמונות המוצרים
            productImages = new Dictionary<string, string>
        {
            { "אייפון", "frozen.jpg" },
            { "מילקשייק", "milkshake.jpg" },
            { "טלוויזיה", "tv.jpg" }
        };


            // *הגדרת תמונת ברירת מחדל
            string defaultImagePath = Path.Combine(Application.StartupPath, "picture", "ice.jpg");
            defaultImage = Image.FromFile(defaultImagePath);

            // הגדרת DataGridView למוצרים
            productsDataGridView = new DataGridView
            {
                Dock = DockStyle.Left,
                Width = 500,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AutoGenerateColumns = false
            };

            // הוספת עמודת תמונה עם הגדרת ImageLayout
            var imageColumn = new DataGridViewImageColumn
            {
                Name = "ProductImage",
                HeaderText = "תמונה",
                ImageLayout = DataGridViewImageCellLayout.Zoom // שינוי גודל התמונה בהתאמה לתא
            };
            productsDataGridView.Columns.Add(imageColumn);

            // הוספת עמודות לשם המוצר והמחיר
            productsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductName",
                HeaderText = "שם המוצר"
            });
            productsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductPrice",
                HeaderText = "מחיר"
            });

            // הוספת אירוע ללחיצה על שורה במוצר כדי להוסיף לעגלה
            productsDataGridView.CellContentClick += (sender, e) =>
            {
                if (e.ColumnIndex == 1)  // כאשר לוחצים על שם המוצר
                {
                    string productName = productsDataGridView.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                    decimal price = productPrices[productName];
                    AddToCart(productName, price);
                }
            };

            // הגדרת DataGridView לעגלת קניות
            cartDataGridView = new DataGridView
            {
                Dock = DockStyle.Right,
                Width = 300,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AutoGenerateColumns = false
            };

            // הוספת עמודות לעגלת הקניות
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

            // הוספת תגית לסה"כ
            totalLabel = new Label
            {
                Text = "סה\"כ: 0 ₪",
                Dock = DockStyle.Bottom,
                TextAlign = ContentAlignment.MiddleCenter,
                Height = 30
            };

            // הוספת כפתור להסרת מוצר מהסל
            removeButton = new Button
            {
                Text = "הסר מהסל",
                Dock = DockStyle.Bottom,
                Height = 30
            };

            removeButton.Click += RemoveButton_Click; // חיבור לאירוע לחיצה

            // הוספת הפקדים לטופס
            this.Controls.Add(productsDataGridView);
            this.Controls.Add(cartDataGridView);
            this.Controls.Add(totalLabel);
            this.Controls.Add(removeButton);

            LoadProducts(); // טוען את המוצרים
                            // יצירת כפתור מעבר לסיכום תשלום
            checkoutButton = new Button
            {
                Text = "סיכום תשלום",
                Dock = DockStyle.Bottom,
                Height = 30
            };

            checkoutButton.Click += CheckoutButton_Click; // חיבור לאירוע לחיצה

            // הוספת הכפתור לטופס
            this.Controls.Add(checkoutButton);

        }

        private void LoadProducts()
        {
            foreach (var product in productPrices)
            {
                // בודקים אם התמונה קיימת
                string imagePath = Path.Combine(imagePathFolder, productImages[product.Key]);

                // אם התמונה לא קיימת, נטען את תמונת ברירת המחדל
                Image productImage = File.Exists(imagePath) ? Image.FromFile(imagePath) : defaultImage;

                // שינוי גודל התמונה: לדוגמה, 100x100
                productImage = ResizeImage(productImage, 100, 100); // שינוי גודל התמונה

                // הוספת המוצר ל- DataGridView
                productsDataGridView.Rows.Add(productImage, product.Key, product.Value);
            }
        }

        private void AddToCart(string productName, decimal price)
        {
            // הוספת המוצר לעגלת הקניות
            cartDataGridView.Rows.Add(productName, price);
            total += price;
            totalLabel.Text = $"סה\"כ: {total} ₪";
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // אם יש שורה נבחרת בעגלת קניות
            if (cartDataGridView.SelectedRows.Count > 0)
            {
                // מקבלים את המוצר שנבחר
                int rowIndex = cartDataGridView.SelectedRows[0].Index;
                decimal price = (decimal)cartDataGridView.Rows[rowIndex].Cells["CartProductPrice"].Value;

                // מסירים את המוצר מהסל
                cartDataGridView.Rows.RemoveAt(rowIndex);

                // מעדכנים את הסכום הכולל
                total -= price;
                totalLabel.Text = $"סה\"כ: {total} ₪";
            }
            else
            {
                MessageBox.Show("בחר מוצר להסיר מהסל");
            }
        }

        // פונקציה לשינוי גודל התמונה
        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap resizedImg = new Bitmap(img, new Size(width, height));
            return resizedImg;
        }
       

        
        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            SummaryForm summaryForm = new SummaryForm(cartDataGridView, total);
            summaryForm.ShowDialog();
        }
        //private void CheckoutButton_Click(object sender, EventArgs e)
        //{
        //    ReceiptForm receiptForm = new ReceiptForm(cartDataGridView, total);
        //    receiptForm.ShowDialog();
        //}
        private void saleWuthPic_Load(object sender, EventArgs e)
        {

        }
    }
}
