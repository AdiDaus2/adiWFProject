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
    public partial class SummaryForm : Form
    {
        private TextBox cardNumberTextBox;
        private TextBox expiryTextBox;
        private TextBox cvvTextBox;
        private DataGridView cartDataGridView;
        private decimal total;

        public SummaryForm(DataGridView cartDataGridView, decimal total)
        {
            this.cartDataGridView = cartDataGridView;
            this.total = total;

            this.Text = "סיכום תשלום";
            this.Size = new Size(450, 700);
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;

            Panel panel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };

            Label titleLabel = new Label
            {
                Text = "סיכום תשלום:\n\n",
                AutoSize = true,
                Font = new Font("Arial", 14, FontStyle.Bold),
                Dock = DockStyle.Top
            };

            panel.Controls.Add(titleLabel);

            int yOffset = titleLabel.Height + 10;

            Label dateLabel = new Label
            {
                Text = "תאריך: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                AutoSize = true,
                Location = new Point(10, yOffset)
            };
            panel.Controls.Add(dateLabel);
            yOffset += dateLabel.Height + 10;

            string orderId = "#" + new Random().Next(100000, 999999).ToString();
            Label orderIdLabel = new Label
            {
                Text = "מספר הזמנה: " + orderId,
                AutoSize = true,
                Location = new Point(10, yOffset)
            };
            panel.Controls.Add(orderIdLabel);
            yOffset += orderIdLabel.Height + 20;

            foreach (DataGridViewRow row in cartDataGridView.Rows)
            {
                string productName = row.Cells["CartProductName"].Value.ToString();
                decimal price = (decimal)row.Cells["CartProductPrice"].Value;

                Label itemLabel = new Label
                {
                    Text = $"מוצר: {productName} | מחיר: {price} ₪",
                    AutoSize = true,
                    Location = new Point(10, yOffset)
                };

                yOffset += itemLabel.Height + 5;
                panel.Controls.Add(itemLabel);
            }

            yOffset += 10;

            Label totalLabel = new Label
            {
                Text = $"סה\"כ לתשלום: {total} ₪",
                AutoSize = true,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(10, yOffset)
            };
            panel.Controls.Add(totalLabel);
            yOffset += totalLabel.Height + 20;

            // שדות קלט לפרטי תשלום
            Label paymentLabel = new Label
            {
                Text = "הזן פרטי תשלום:",
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Bold),
                Location = new Point(10, yOffset)
            };
            panel.Controls.Add(paymentLabel);
            yOffset += paymentLabel.Height + 10;

            cardNumberTextBox = new TextBox { Text = "מספר כרטיס", ForeColor = Color.Gray, Width = 200, Location = new Point(10, yOffset) };
            cardNumberTextBox.GotFocus += (s, e) => {
                if (cardNumberTextBox.Text == "מספר כרטיס")
                {
                    cardNumberTextBox.Text = "";
                    cardNumberTextBox.ForeColor = Color.Black;
                }
            };
            cardNumberTextBox.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(cardNumberTextBox.Text))
                {
                    cardNumberTextBox.Text = "מספר כרטיס";
                    cardNumberTextBox.ForeColor = Color.Gray;
                }
            };
            panel.Controls.Add(cardNumberTextBox);
            yOffset += cardNumberTextBox.Height + 5;

            expiryTextBox = new TextBox { Text = "תוקף (MM/YY)", ForeColor = Color.Gray, Width = 100, Location = new Point(10, yOffset) };
            expiryTextBox.GotFocus += (s, e) => {
                if (expiryTextBox.Text == "תוקף (MM/YY)")
                {
                    expiryTextBox.Text = "";
                    expiryTextBox.ForeColor = Color.Black;
                }
            };
            expiryTextBox.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(expiryTextBox.Text))
                {
                    expiryTextBox.Text = "תוקף (MM/YY)";
                    expiryTextBox.ForeColor = Color.Gray;
                }
            };
            panel.Controls.Add(expiryTextBox);
            yOffset += expiryTextBox.Height + 5;

            cvvTextBox = new TextBox { Text = "CVV", ForeColor = Color.Gray, Width = 60, Location = new Point(10, yOffset) };
            cvvTextBox.GotFocus += (s, e) => {
                if (cvvTextBox.Text == "CVV")
                {
                    cvvTextBox.Text = "";
                    cvvTextBox.ForeColor = Color.Black;
                }
            };
            cvvTextBox.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(cvvTextBox.Text))
                {
                    cvvTextBox.Text = "CVV";
                    cvvTextBox.ForeColor = Color.Gray;
                }
            };
            panel.Controls.Add(cvvTextBox);
            yOffset += cvvTextBox.Height + 20;

            // כפתור הצגת קבלה
            Button openReceiptButton = new Button
            {
                Text = "הצג קבלה",
                Width = 100,
                Height = 30,
                Location = new Point(10, yOffset)
            };
            openReceiptButton.Click += (s, e) =>
            {
                ReceiptForm receiptForm = new ReceiptForm(cartDataGridView, total, cardNumberTextBox.Text, expiryTextBox.Text);
                receiptForm.ShowDialog();
            };
            panel.Controls.Add(openReceiptButton);

            this.Controls.Add(panel);
        }
    


    private void PaymentForm_Load(object sender, EventArgs e)
        {

        }
    }
}


