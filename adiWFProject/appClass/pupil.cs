
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace adiWFProject
{
    class pupil: DbInterface
    {
        private string pupilID;
        private string pupilName;
        private string tribeName;
        private DateTime birthDate;
        private string address;
        private string parentPhone;
        private string schoolName;
        private string cityName;
        private string staffID;

        public pupil()
        { 

        }
        public string PupilID
        {
            get { return pupilID; }
            set { pupilID = value; }
        }

        public string PupilName
        {
            get { return pupilName; }
            set { pupilName = value; }
        }

        public string TribeName
        {
            get { return tribeName; }
            set { tribeName = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string ParentPhone
        {
            get { return parentPhone; }
            set { parentPhone = value; }
        }

        public string SchoolName
        {
            get { return schoolName; }
            set { schoolName = value; }
        }

        public string CityName
        {
            get { return cityName; }
            set { cityName = value; }
        }

        public string StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public void Insert()
        {
            string SqlStr = string.Format("INSERT INTO pupil (pupilID, pupilName, tribeName, birthDate, address, parentPhone, schoolName, cityName, staffID) " +
                                             "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                                             pupilID, pupilName, tribeName, birthDate.ToString("yyyy-MM-dd"), address, parentPhone, schoolName, cityName, staffID);

            DbMain.InsDelUpd(SqlStr);
        }

        public void Delete(int IdKey)
        {
            string SqlStr = string.Format("delete  from pupil where pupilID={0}", IdKey);
            DbMain.InsDelUpd(SqlStr);

        }

        public void Update()
        {
            string SqlStr = string.Format("update pupil set pupilID='{0}',pupilName='{1}', tribeName={2}, birthDate='{3}', address={4}, parentPhone='{5}', schoolName='{6}', cityName='{7}', staffID='{8}'", pupilID, pupilName, tribeName, birthDate, address, parentPhone, schoolName, cityName, staffID);
            DbMain.InsDelUpd(SqlStr);
        }



        //פעולת חיפוש רשומה לפי שדה מפתח
        public DataSet GetInfoByIdKey(int IdKey)
        {
            Customer db = new Customer();
            DataSet ds = new DataSet();
            string SqlStr = string.Format("select * from pupil where pupilID={0}", IdKey);
            ds = DbMain.ReturnDS(SqlStr);
            return ds;
        }

        //פעולה מחזירה אמת אם הרשומה נמצאת אחרת מחזירה שקר לפי שדה מפתח
        public bool Found(int Id)
        {
            DataSet ds = new DataSet();
            string str = string.Format("select * from pupil where pupilID={0} ", Id);
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
    class pupil : DbInterface
    {
        private string pupilID;
        private string pupilName;
        private string tribeName;
        private DateTime birthDate;
        private string address;
        private string parentPhone;
        private string schoolName;
        private string cityName;
        private string staffID;

        public pupil() { }

        #region Properties
        public string PupilID { get { return pupilID; } set { pupilID = value; } }

        // תיקון שגיאת PupilFullName: שיניתי את שם ה-Property שיתאים לטופס שלך
        public string PupilFullName { get { return pupilName; } set { pupilName = value; } }

        // תיקון שגיאות כתיב שיכולות להופיע בטופס (TribeName vs SelfTribeName)
        public string SelfTribeName { get { return tribeName; } set { tribeName = value; } }

        public DateTime BirthDate { get { return birthDate; } set { birthDate = value; } }
        public string Address { get { return address; } set { address = value; } }

        // תיקון ParentPhone שיתאים ל-ParentPhoneNumber בטופס
        public string ParentPhoneNumber { get { return parentPhone; } set { parentPhone = value; } }

        public string SchoolName { get { return schoolName; } set { schoolName = value; } }
        public string CityName { get { return cityName; } set { cityName = value; } }
        public string StaffID { get { return staffID; } set { staffID = value; } }
        #endregion

        public void Insert()
        {
            // הערה: אם אתה עובד עם Access, תאריכים עוטפים ב-#. אם SQL Server, עוטפים ב-'.
            string SqlStr = string.Format("INSERT INTO pupil (pupilID, pupilName, tribeName, birthDate, address, parentPhone, schoolName, cityName, staffID) " +
                                             "VALUES ('{0}', '{1}', '{2}', #{3}#, '{4}', '{5}', '{6}', '{7}', '{8}')",
                                             pupilID, pupilName, tribeName, birthDate.ToString("yyyy/MM/dd"), address, parentPhone, schoolName, cityName, staffID);
            DbMain.InsDelUpd(SqlStr);
        }

        // פתרון שגיאת הכפילות CS0111: משאירים רק פונקציית Delete אחת שמקבלת string
        public void Delete(string IdKey)
        {
            string SqlStr = string.Format("DELETE FROM pupil WHERE pupilID='{0}'", IdKey);
            DbMain.InsDelUpd(SqlStr);
        }

        // מימוש ה-Interface במידה והוא דורש int (אם לא דרוש, אפשר למחוק)
        public void Delete(int IdKey)
        {
            Delete(IdKey.ToString());
        }

        public void Update()
        {
            string SqlStr = string.Format("UPDATE pupil SET pupilName='{1}', tribeName='{2}', birthDate=#{3}#, address='{4}', parentPhone='{5}', schoolName='{6}', cityName='{7}', staffID='{8}' WHERE pupilID='{0}'",
                pupilID, pupilName, tribeName, birthDate.ToString("yyyy/MM/dd"), address, parentPhone, schoolName, cityName, staffID);
            DbMain.InsDelUpd(SqlStr);
        }

        public DataSet GetInfoByIdKey(string IdKey)
        {
            string SqlStr = string.Format("SELECT * FROM pupil WHERE pupilID='{0}'", IdKey);
            return DbMain.ReturnDS(SqlStr);
        }

        public bool Found(string Id)
        {
            string str = string.Format("SELECT * FROM pupil WHERE pupilID='{0}'", Id);
            DataSet ds = DbMain.ReturnDS(str);
            return (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0);
        }
    }
}