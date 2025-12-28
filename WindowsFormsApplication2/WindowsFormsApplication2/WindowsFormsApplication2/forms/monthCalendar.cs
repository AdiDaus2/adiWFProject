using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show(ClassStatic.n.ToString());
            DateTime date1 = new DateTime();
            date1.Month.ToString();
            MessageBox.Show(date1.Month.ToString());
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selected = monthCalendar1.SelectionRange.Start;
            MessageBox.Show(string.Format("{0:D2}/{1:D2}/{2}", selected.Day, selected.Month, selected.Year));
        }
    }
}
