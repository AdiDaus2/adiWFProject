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
    public partial class ReceiptForm : Form
    {

        public ReceiptForm(DataGridView cartDataGridView, decimal total, string cardNumber, string expiry)
        {
            this.Text = "קבלה";
            this.Size = new Size(400, 600);
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;

            Panel panel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };

            Label titleLabel = new Label
            {
                Text = "קבלה:\n\n",
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

            string maskedCard = cardNumber.Length >= 4 ? cardNumber.Substring(cardNumber.Length - 4).PadLeft(cardNumber.Length, '*') : "****";

            Label paymentInfo = new Label
            {
                Text = $"אמצעי תשלום: כרטיס אשראי\nמספר כרטיס: {maskedCard}\nתוקף: {expiry}",
                AutoSize = true,
                Location = new Point(10, yOffset)
            };
            panel.Controls.Add(paymentInfo);

            this.Controls.Add(panel);
        }


        private void ReceiptForm_Load(object sender, EventArgs e)
        {

        }
    }
}
