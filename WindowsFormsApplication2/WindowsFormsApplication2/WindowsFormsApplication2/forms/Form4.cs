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
    public partial class Form4 : Form
    {
      //  private GeminiApiClient _geminiClient;

        public Form4()
        {
            InitializeComponent();
            var apiKey = "AIzaSyCQzTUW9YsiniF_wmo1gCAgN-9iiiihEuY";
            if (apiKey == "AIzaSyCQzTUW9YsiniF_wmo1gCAgN-9iiiihEuY")
            {
                MessageBox.Show("Please replace 'YOUR_API_KEY' with your actual API key.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sendButton.Enabled = false; // נטרל את הכפתור אם אין מפתח
            }

      //      _geminiClient = new GeminiApiClient(apiKey);
        }

        private async Task sendButton_ClickAsync(object sender, EventArgs e)
        {
            // 1. קבלת הקלט מהמשתמש
            string prompt = promptTextBox.Text;
            if (string.IsNullOrWhiteSpace(prompt))
            {
                MessageBox.Show("Please enter a prompt.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. עדכון הממשק לפני שליחת הבקשה
                resultTextBox.Text = "Generating response, please wait...";
                sendButton.Enabled = false; // נטרול הכפתור למניעת לחיצות כפולות
                promptTextBox.Enabled = false;

                // 3. שליחת הבקשה ל-API באופן אסינכרוני
                // הממשק הגרפי יישאר רספונסיבי בזכות ה-await
            //    string result = await _geminiClient.GenerateContentAsync(prompt);

                // 4. הצגת התוצאה בתיבת הטקסט
            //    resultTextBox.Text = result;
            }
            catch (Exception ex)
            {
                // 5. טיפול בשגיאות
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultTextBox.Text = "Failed to get a response.";
            }
            finally
            {
                // 6. הפעלת הפקדים מחדש בסיום הפעולה (בהצלחה או בכישלון)
                sendButton.Enabled = true;
                promptTextBox.Enabled = true;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
