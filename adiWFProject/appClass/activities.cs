/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;



namespace adiWFProject
{
    class activities: DbMain, DbInterface
    {
        private int activityNum;
        private string activtyDescraption;
        private int minAge;
        private int maxAge;
        private string activityWriteId;
        private DateTime writeDate;
 
        public activities()
        {

        }

        public int ActivityNum
        {
            get { return activityNum; }
            set { activityNum = value; }
        }

        public string ActivtyDescraption
        {
            get { return activtyDescraption; }
            set { activtyDescraption = value; }
        }

        public int MinAge
        {
            get { return minAge; }
            set { minAge = value; }
        }

        public int MaxAge
        {
            get { return maxAge; }
            set { maxAge = value; }
        }
        
        public string ActivityWriteId
        {
            get { return activityWriteId; }
            set { activityWriteId = value; }
        }

        public DateTime WriteDate
        {
            get { return writeDate; }
            set { writeDate = value; }
        }
        public void Insert()
        {
            string SqlStr = string.Format("INSERT INTO activities(activityNum, activtyDescraption, minAge, maxAge, activityWriteId, writeDate) values ('{0}','{1}','{2}','{3}','{4}','{5}')", activityNum, activtyDescraption, minAge, maxAge, activityWriteId, writeDate);
            DbMain.InsDelUpd(SqlStr);
        }

        public void Delete(int IdKey)
        {
            string SqlStr = string.Format("delete  from activities where activityNum={0}", IdKey);
            DbMain.InsDelUpd(SqlStr);

        }

            public void Update()
            {
              string SqlStr = string.Format("update activities set activityNum='{0}',activtyDescraption='{1}', minAge={2}, maxAge='{3}', activityWriteId={4}, writeDate='{5}'", activityNum, activtyDescraption, minAge, maxAge, activityWriteId, writeDate);
              DbMain.InsDelUpd(SqlStr);
            }
           
            

            //פעולת חיפוש רשומה לפי שדה מפתח
            public DataSet GetInfoByIdKey(int IdKey)
            {
                Customer db = new Customer();
                DataSet ds = new DataSet();
                string SqlStr = string.Format("select * from activities where activityNum={0}", IdKey);
                ds = DbMain.ReturnDS(SqlStr);
                return ds;
            }

            //פעולה מחזירה אמת אם הרשומה נמצאת אחרת מחזירה שקר לפי שדה מפתח
            public bool Found(int Id)
            {
                DataSet ds = new DataSet();
                string str = string.Format("select * from activities where activityNum={0} ", Id);
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
    // הורדת הירושה מ-DbMain אם היא לא נחוצה, מימוש הממשק DbInterface
    class activities : DbInterface
    {
        private int activityNum;
        private string activtyDescraption; // שים לב לאיות במבנה הטבלה באקסס
        private int minAge;
        private int maxAge;
        private string activityWriteId;
        private DateTime writeDate;

        public activities()
        {
        }

        #region Getters and Setters
        public int ActivityNum
        {
            get { return activityNum; }
            set { activityNum = value; }
        }

        public string ActivtyDescraption
        {
            get { return activtyDescraption; }
            set { activtyDescraption = value; }
        }

        public int MinAge
        {
            get { return minAge; }
            set { minAge = value; }
        }

        public int MaxAge
        {
            get { return maxAge; }
            set { maxAge = value; }
        }

        public string ActivityWriteId
        {
            get { return activityWriteId; }
            set { activityWriteId = value; }
        }

        public DateTime WriteDate
        {
            get { return writeDate; }
            set { writeDate = value; }
        }
        #endregion

        public void Insert()
        {
            // תיקון: בשדות מספריים (activityNum, minAge, maxAge) לא שמים גרש (')
            // תיקון: בשדות תאריך ב-Access משתמשים בסולמית (#) או פורמט מתאים
            string SqlStr = string.Format("INSERT INTO activities (activityNum, activtyDescraption, minAge, maxAge, activityWriteId, writeDate) " +
                                          "VALUES ({0}, '{1}', {2}, {3}, '{4}', '{5}')",
                                          activityNum, activtyDescraption, minAge, maxAge, activityWriteId, writeDate.ToString("yyyy-MM-dd"));
            DbMain.InsDelUpd(SqlStr);
        }

        public void Delete(int IdKey)
        {
            string SqlStr = string.Format("DELETE FROM activities WHERE activityNum = {0}", IdKey);
            DbMain.InsDelUpd(SqlStr);
        }

        public void Update()
        {
            // תיקון: הסרת גרשיים משדות מספריים והוספת גרשיים לשדות טקסט
            // הנחה: activityWriteId הוא מחרוזת (סטרינג)
            string SqlStr = string.Format("UPDATE activities SET activtyDescraption='{1}', minAge={2}, maxAge={3}, activityWriteId='{4}', writeDate='{5}' WHERE activityNum={0}",
                                          activityNum, activtyDescraption, minAge, maxAge, activityWriteId, writeDate.ToString("yyyy-MM-dd"));
            DbMain.InsDelUpd(SqlStr);
        }

        // פעולת חיפוש רשומה לפי שדה מפתח
        public DataSet GetInfoByIdKey(int IdKey)
        {
            // תיקון: הסרת השורה המיותרת של Customer שלא קיימת/קשורה
            string SqlStr = string.Format("SELECT * FROM activities WHERE activityNum = {0}", IdKey);
            return DbMain.ReturnDS(SqlStr);
        }

        // פעולה מחזירה אמת אם הרשומה נמצאת אחרת מחזירה שקר לפי שדה מפתח
        public bool Found(int Id)
        {
            string str = string.Format("SELECT * FROM activities WHERE activityNum = {0}", Id);
            DataSet ds = DbMain.ReturnDS(str);
            if (ds.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;
        }
    }
}

