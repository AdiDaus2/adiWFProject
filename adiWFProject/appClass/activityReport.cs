/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace adiWFProject
{
    class activityReport : DbMain, DbInterface
    {
        private int rating;
        private int participantsAmount;
        private string parashatShavua;
        private DateTime activityDate;
        private int activityNum;
        private string staffID;
        private string opinion;

        public activityReport()
        { }
        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public int ParticipantsAmount
        {
            get { return participantsAmount; }
            set {  participantsAmount = value; }
        }

        public string ParashatShavua
        {
            get { return parashatShavua; }
            set { parashatShavua = value; }
        }

        public DateTime ActivityDate
        {
            get { return activityDate; }
            set { activityDate = value; }
        }

        public int ActivityNum
        {
            get { return activityNum; }
            set { activityNum = value; }
        }

        public string StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public string Opinion
        {
            get { return opinion; }
            set { opinion = value; }
        }

        public void Insert()
        {
            string SqlStr = string.Format("INSERT INTO activityReport(rating, participantsAmount, parashatShavua, activityDate, activityNum, staffID, opinion) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", rating, participantsAmount, parashatShavua, activityDate, activityNum, staffID, opinion);
            DbMain.InsDelUpd(SqlStr);
        }

        public void Delete(int IdKey)
        {
            string SqlStr = string.Format("delete  from activityReport where activityDate={3}, activityNum={4} ", IdKey);
            DbMain.InsDelUpd(SqlStr);

        }

        public void Update()
        {
            string SqlStr = string.Format("update activityReport set rating='{0}',participantsAmount='{1}', parashatShavua={2}, activityDate='{3}', activityNum={4}, staffID='{5}', opinion='{6}'", rating, participantsAmount, parashatShavua, activityDate, activityNum, staffID, opinion);
            DbMain.InsDelUpd(SqlStr);
        }



        //פעולת חיפוש רשומה לפי שדה מפתח
        public DataSet GetInfoByIdKey(int IdKey)
        {
            Customer db = new Customer();
            DataSet ds = new DataSet();
            string SqlStr = string.Format("select * from activityReport where activityDate={3}, activityNum={4}", IdKey);
            ds = DbMain.ReturnDS(SqlStr);
            return ds;
        }

        //פעולה מחזירה אמת אם הרשומה נמצאת אחרת מחזירה שקר לפי שדה מפתח
        public bool Found(int Id)
        {
            DataSet ds = new DataSet();
            string str = string.Format("select * from activityReport where activityDate={3}, activityNum={4} ", Id);
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
    // המחלקה יורשת מ-DbMain ומממשת את ה-Interface (בהנחה שקיים בפרויקט שלך)
    class activityReport : DbMain, DbInterface
    {
        private int rating;
        private int participantsAmount;
        private string parashatShavua;
        private DateTime activityDate;
        private int activityNum;
        private string staffID;
        private string opinion;

        public activityReport()
        { }

        // Properties
        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public int ParticipantsAmount
        {
            get { return participantsAmount; }
            set { participantsAmount = value; }
        }

        public string ParashatShavua
        {
            get { return parashatShavua; }
            set { parashatShavua = value; }
        }

        public DateTime ActivityDate
        {
            get { return activityDate; }
            set { activityDate = value; }
        }

        public int ActivityNum
        {
            get { return activityNum; }
            set { activityNum = value; }
        }

        public string StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public string Opinion
        {
            get { return opinion; }
            set { opinion = value; }
        }

        // פעולת הכנסה - תיקון פורמט התאריך ל-Access
        public void Insert()
        {
            // ב-Access תאריכים עוטפים ב-#. מספרים לא עוטפים בגרש.
            string SqlStr = string.Format("INSERT INTO activityReport (rating, participantsAmount, parashatShavua, activityDate, activityNum, staffID, opinion) " +
                                          "VALUES ({0}, {1}, '{2}', #{3}#, {4}, '{5}', '{6}')",
                                          rating, participantsAmount, parashatShavua, activityDate.ToString("yyyy/MM/dd"), activityNum, staffID, opinion);
            DbMain.InsDelUpd(SqlStr);
        }

        // פעולת מחיקה - תיקון: IdKey לא יכול לייצג שני שדות בו זמנית. 
        // אם המפתח הוא activityNum, השתמש בו.
        public void Delete(int IdKey)
        {
            string SqlStr = string.Format("DELETE FROM activityReport WHERE activityNum = {0}", IdKey);
            DbMain.InsDelUpd(SqlStr);
        }

        // פעולת עדכון - תיקון אינדקסים ופורמט SQL
        public void Update()
        {
            string SqlStr = string.Format("UPDATE activityReport SET rating={0}, participantsAmount={1}, parashatShavua='{2}', activityDate=#{3}#, staffID='{4}', opinion='{5}' " +
                                          "WHERE activityNum={6}",
                                          rating, participantsAmount, parashatShavua, activityDate.ToString("yyyy/MM/dd"), staffID, opinion, activityNum);
            DbMain.InsDelUpd(SqlStr);
        }

        // חיפוש רשומה לפי קוד פעילות
        public DataSet GetInfoByIdKey(int IdKey)
        {
            // הסרתי את Customer db = new Customer() כי זה לא רלוונטי כאן
            string SqlStr = string.Format("SELECT * FROM activityReport WHERE activityNum = {0}", IdKey);
            return DbMain.ReturnDS(SqlStr);
        }

        // בדיקה אם רשומה קיימת
        public bool Found(int Id)
        {
            string str = string.Format("SELECT * FROM activityReport WHERE activityNum = {0}", Id);
            DataSet ds = DbMain.ReturnDS(str);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}