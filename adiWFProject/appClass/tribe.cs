/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace adiWFProject
{
    internal class tribe : DbInterface
    {
        private string tribeName;
        private DateTime establishmentDate;

        public string TribeName
        {
            get { return tribeName; }
            set { tribeName = value; }
        }

        public DateTime EstablishmentDate
        { 
            get { return establishmentDate; } 
            set {  establishmentDate = value; } 
        }



        public void Insert()
        {
            string SqlStr = string.Format("INSERT INTO tribe(tribeName, establishmentDate) values ('{0}','{1}')", tribeName, establishmentDate);
            DbMain.InsDelUpd(SqlStr);
        }

        public void Delete(int IdKey)
        {
            string SqlStr = string.Format("delete  from tribe where tribeName={0}", IdKey);
            DbMain.InsDelUpd(SqlStr);
        }

        public void Update()
        {
            string SqlStr = string.Format("update tribe set tribeName='{0}',establishmentDate='{1}'", tribeName, establishmentDate);
            DbMain.InsDelUpd(SqlStr);
        }

        //פעולת חיפוש רשומה לפי שדה מפתח
        public DataSet GetInfoByIdKey(int IdKey)
        {
            Customer db = new Customer();
            DataSet ds = new DataSet();
            string SqlStr = string.Format("select * from tribe where tribeName={0}", IdKey);
            ds = DbMain.ReturnDS(SqlStr);
            return ds;
        }

        //פעולה מחזירה אמת אם הרשומה נמצאת אחרת מחזירה שקר לפי שדה מפתח
        public bool Found(int Id)
        {
            DataSet ds = new DataSet();
            string str = string.Format("select * from tribe where tribeName={0} ", Id);
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
    internal class tribe : DbInterface
    {
        private string tribeName;
        private DateTime establishmentDate;

        public string TribeName
        {
            get { return tribeName; }
            set { tribeName = value; }
        }

        public DateTime EstablishmentDate
        {
            get { return establishmentDate; }
            set { establishmentDate = value; }
        }

        // הכנסת שבט חדש
        public void Insert()
        {
            // שים לב: תאריך ב-Access לפעמים דורש סולמיות (#) במקום גרש, 
            // אך ברוב הגרסאות המודרניות גרש יעבוד.
            string SqlStr = string.Format("INSERT INTO tribe (tribeName, establishmentDate) VALUES ('{0}', '{1}')",
                tribeName, establishmentDate.ToString("yyyy-MM-dd"));
            DbMain.InsDelUpd(SqlStr);
        }

        // מחיקת שבט לפי שמו (מפתח)
        public void Delete(string tribeKey) // שינוי מ-int ל-string כי tribeName הוא מחרוזת
        {
            string SqlStr = string.Format("DELETE FROM tribe WHERE tribeName = '{0}'", tribeKey);
            DbMain.InsDelUpd(SqlStr);
        }

        // עדכון פרטי שבט קיים
        public void Update()
        {
            // חשוב מאוד: הוספת WHERE כדי לעדכן רק את השבט הספציפי
            string SqlStr = string.Format("UPDATE tribe SET establishmentDate = '{0}' WHERE tribeName = '{1}'",
                establishmentDate.ToString("yyyy-MM-dd"), tribeName);
            DbMain.InsDelUpd(SqlStr);
        }

        // חיפוש רשומה לפי שם השבט (Key)
        public DataSet GetInfoByIdKey(string tribeKey)
        {
            DataSet ds = new DataSet();
            string SqlStr = string.Format("SELECT * FROM tribe WHERE tribeName = '{0}'", tribeKey);
            ds = DbMain.GetQuery(SqlStr); // השתמשתי ב-GetQuery כפי שמופיע ב-DbMain שלך
            return ds;
        }

        // בדיקה אם השבט קיים במסד הנתונים
        public bool Found(string tribeKey)
        {
            DataSet ds = new DataSet();
            string str = string.Format("SELECT * FROM tribe WHERE tribeName = '{0}'", tribeKey);
            ds = DbMain.GetQuery(str);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }

        // מימוש הפונקציות מהממשק DbInterface (במידה והוא מחייב חתימות מסוימות)
        // אם ה-Interface מחייב Delete(int), תצטרכי להתאים את מסד הנתונים לעבודה עם ID מספרי
        public void Delete(int IdKey)
        {
            Delete(IdKey.ToString());
        }
    }
}