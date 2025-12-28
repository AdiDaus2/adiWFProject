using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Student student;
        public Form1()
        {
            InitializeComponent();
            student = new Student();
            student.Id = 12354654;
            student.FirstName = "Toby";
            student.Dob = new DateTime(1990, 12, 1);
            Populate(student);
            
        }
        private void Populate(Student s)
        {
            txtFirstName.Text = s.FirstName;
            dateTimePicker1.Value = s.Dob;
        }
        private bool UpdateStudent(Student s)
        {
            bool ok = true;
            try
            {
                s.FirstName = txtFirstName.Text;
                errorProvider1.SetError(txtFirstName, "");
            }
            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(txtFirstName, ex.Message);
            } try
            {
                student.Dob = dateTimePicker1.Value;
                errorProvider1.SetError(dateTimePicker1, "");
            }
            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(dateTimePicker1, ex.Message);
            }
            return ok;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             openFileDialog1.ShowDialog();
             string fileName = openFileDialog1.FileName;
             try
             {
                 pictureBox1.Image = Image.FromFile(fileName);
             }
             catch (System.IO.FileNotFoundException ex) { pictureBox1.Image = null; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UpdateStudent(student))
            {
                MessageBox.Show("YESH");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
