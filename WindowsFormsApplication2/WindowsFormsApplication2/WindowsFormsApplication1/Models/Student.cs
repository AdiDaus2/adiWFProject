using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1.Models
{
    class Student
    {
        private int id;
        private string firstName;
        private string lastName;
        private DateTime dob;
        private string phoneNo;//###-#######
        private string email;
        private Image picture;
        private StudentType type;
        public int Id
        {

            set
            {
                this.id = value;
            }
            get
            {
                return id;
            }
        }
        public string FirstName
        {
             set
            {
                if (value.Trim().Length==0)
                    throw new Exception(" חייבים לקלוט שם פרטי");
                this.firstName = value;
            }
            get
            {
                return this.firstName;
            }
        }
       
        public DateTime Dob
        {
             set
            {
                if (DateTime.Today.Year - value.Year < 6)
                    throw new Exception("צעיר מדי");
                this.dob = value;
            }
            get
            {
                return dob;
            }
        }
        public Image Picture { get { return this.picture; } }
        public void AddPicture(string fileName)
        {
            try
            {
                picture = Image.FromFile(fileName);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                picture = null;
            }
        }
        public string AreaCode
        {
            get { return this.phoneNo.Split('-')[0]; }
        }
    }
}
