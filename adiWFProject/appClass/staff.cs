/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net;


namespace adiWFProject
{
    internal class staff: pupil, DbInterface 
    {
        private string staffFullName;
        private string selfTribeName;
        private string phoneNumber;
      
        public staff()
        { }

        public string StaffFullName
        {
            get { return staffFullName; }
            set { staffFullName = value; }
        }

        public string SelfTribeName
        {
            get { return selfTribeName; }
            set { selfTribeName = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public void Insert()
        {
            string SqlStr = string.Format("INSERT INTO journies(staffID, staffFullName, selfTribeName, birthDate, address, phoneNumber, cityName, schoolName) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", base.StaffID, staffFullName, selfTribeName, base.BirthDate, base.Address, phoneNumber, base.CityName, base.SchoolName);
            DbMain.InsDelUpd(SqlStr);
        }

        public void Delete(int IdKey)
        {
            string SqlStr = string.Format("delete  from staff where staffID={0}", IdKey);
            DbMain.InsDelUpd(SqlStr);
        }

        public void Update()
        {
            string SqlStr = string.Format("update staff set staffID='{0}',staffFullName='{1}', selfTribeName={2}, birthDate='{3}', address={4}, phoneNumber='{5}', cityName='{6}', schoolName='{7}'", base.StaffID, staffFullName, selfTribeName, base.BirthDate, base.Address, phoneNumber, base.CityName, base.SchoolName);
            DbMain.InsDelUpd(SqlStr);
        }

        //פעולת חיפוש רשומה לפי שדה מפתח
        public DataSet GetInfoByIdKey(int IdKey)
        {
            Customer db = new Customer();
            DataSet ds = new DataSet();
            string SqlStr = string.Format("select * from staff where staffID={0}", IdKey);
            ds = DbMain.ReturnDS(SqlStr);
            return ds;
        }

        //פעולה מחזירה אמת אם הרשומה נמצאת אחרת מחזירה שקר לפי שדה מפתח
        public bool Found(int Id)
        {
            DataSet ds = new DataSet();
            string str = string.Format("select * from staff where staffID={0} ", Id);
            ds = DbMain.ReturnDS(str);
            if (ds.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;

        }
    }
}
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace adiWFProject
{
    // המחלקה יורשת מ-pupil ומממשת את ה-Interface
    internal class staff : pupil, DbInterface
    {
        private string staffFullName;
        private string selfTribeName;
        private string phoneNumber;

        public staff() : base() // קריאה לבנאי של מחלקת האב
        { }

        public string StaffFullName
        {
            get { return staffFullName; }
            set { staffFullName = value; }
        }

        public string SelfTribeName
        {
            get { return selfTribeName; }
            set { selfTribeName = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        // --- תיקון פעולת Insert ---
        public void Insert()
        {
            // שים לב: שיניתי את שם הטבלה מ-journies ל-staff (כי זו מחלקת איש צוות)
            // וכן הוספתי גרשיים סביב כל המשתנים שהם טקסט או תאריך
            string SqlStr = string.Format(
                "INSERT INTO staff (staffID, staffFullName, selfTribeName, birthDate, address, phoneNumber, cityName, schoolName) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                this.PupilID, this.StaffFullName, this.SelfTribeName, this.BirthDate.ToString("yyyy-MM-dd"),
                this.Address, this.PhoneNumber, this.CityName, this.SchoolName);

            DbMain.InsDelUpd(SqlStr);
        }

        // --- תיקון פעולת Delete ---
        public void Delete(int IdKey)
        {
            // אם staffID הוא מחרוזת (ID), יש להוסיף גרש בודד: '{0}'
            string SqlStr = string.Format("DELETE FROM staff WHERE staffID='{0}'", IdKey);
            DbMain.InsDelUpd(SqlStr);
        }

        // --- תיקון פעולת Update ---
        public void Update()
        {
            // הוספת גרשיים חסרים סביב שדות טקסטואליים ב-SQL
            string SqlStr = string.Format(
                "UPDATE staff SET staffFullName='{1}', selfTribeName='{2}', birthDate='{3}', address='{4}', " +
                "phoneNumber='{5}', cityName='{6}', schoolName='{7}' WHERE staffID='{0}'",
                this.PupilID, this.StaffFullName, this.SelfTribeName, this.BirthDate.ToString("yyyy-MM-dd"),
                this.Address, this.PhoneNumber, this.CityName, this.SchoolName);

            DbMain.InsDelUpd(SqlStr);
        }

        // --- תיקון GetInfoByIdKey ---
        public DataSet GetInfoByIdKey(int IdKey)
        {
            // הוספת גרשיים אם ה-ID הוא טקסט בבסיס הנתונים
            string SqlStr = string.Format("SELECT * FROM staff WHERE staffID='{0}'", IdKey);
            return DbMain.ReturnDS(SqlStr);
        }

        // --- תיקון Found ---
        public bool Found(int Id)
        {
            string str = string.Format("SELECT * FROM staff WHERE staffID='{0}'", Id);
            DataSet ds = DbMain.ReturnDS(str);

            // בדיקה בטוחה שיש טבלה ויש שורות
            return ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0;
        }
    }
}