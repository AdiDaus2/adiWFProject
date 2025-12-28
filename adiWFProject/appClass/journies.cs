/*
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adiWFProject
{
    class journies:DbMain ,DbInterface
    {
        private int journeyCode;
        private string journeyName;
        private DateTime journeyDate;
        private string staffID;
        private int daysNum;
        private string place;
        private Boolean securityInsure;
        private int price;

        public journies()
        { }
        public int JourneyCode
        {
            get { return journeyCode; }
            set { journeyCode = value; }
        }

        public string JourneyName
        {
            get { return journeyName; }
            set { journeyName = value; }
        }

        public DateTime JourneyDate
        {
            get { return journeyDate; }
            set { journeyDate = value; }
        }

        public string StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public int DaysNum
        {
            get { return daysNum; }
            set { daysNum = value; }
        }

        public string Place
        {
            get { return place; }
            set { place = value; }
        }

        public Boolean SecurityInsure
        {
            get { return securityInsure; }
            set { securityInsure = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public void Insert()
        {
            string SqlStr = string.Format("INSERT INTO journies(journeyCode, journeyName, journeyDate, staffID, daysNum, place, securityInsure, price) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", journeyCode, journeyName, journeyDate, staffID, daysNum, place, securityInsure, price);
            DbMain.InsDelUpd(SqlStr);
        }

        public void Delete(int IdKey)
        {
            string SqlStr = string.Format("delete  from journies where journeyCode={0}", IdKey);
            DbMain.InsDelUpd(SqlStr);

        }

        public void Update()
        {
            string SqlStr = string.Format("update journies set journeyCode='{0}',journeyName='{1}', journeyDate={2}, staffID='{3}', daysNum={4}, place='{5}', securityInsure='{6}', price='{7}'", journeyCode, journeyName, journeyDate, staffID, daysNum, place, securityInsure, price);
            DbMain.InsDelUpd(SqlStr);
        }



        //פעולת חיפוש רשומה לפי שדה מפתח
        public DataSet GetInfoByIdKey(int IdKey)
        {
            Customer db = new Customer();
            DataSet ds = new DataSet();
            string SqlStr = string.Format("select * from journies where journeyCode={0}", IdKey);
            ds = DbMain.ReturnDS(SqlStr);
            return ds;
        }

        //פעולה מחזירה אמת אם הרשומה נמצאת אחרת מחזירה שקר לפי שדה מפתח
        public bool Found(int Id)
        {
            DataSet ds = new DataSet();
            string str = string.Format("select * from journies where journeyCode={0} ", Id);
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
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adiWFProject
{
    class journies : DbInterface
    {
        private int journeyCode;
        private string journeyName;
        private DateTime journeyDate;
        private string staffID;
        private int daysNum;
        private string place;
        private bool securityInsure; // Boolean -> bool (C# style)
        private int price;

        public journies()
        { }

        #region Properties
        public int JourneyCode
        {
            get { return journeyCode; }
            set { journeyCode = value; }
        }

        public string JourneyName
        {
            get { return journeyName; }
            set { journeyName = value; }
        }

        public DateTime JourneyDate
        {
            get { return journeyDate; }
            set { journeyDate = value; }
        }

        public string StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public int DaysNum
        {
            get { return daysNum; }
            set { daysNum = value; }
        }

        public string Place
        {
            get { return place; }
            set { place = value; }
        }

        public bool SecurityInsure
        {
            get { return securityInsure; }
            set { securityInsure = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        #endregion

        public void Insert()
        {
            // תיקון: מספרים ללא גרשיים, טקסט עם גרשיים, תאריך עם סולמיות
            // שים לב: ב-Access שדה Yes/No מקבל True/False ללא גרשיים
            string SqlStr = string.Format("INSERT INTO journies(journeyCode, journeyName, journeyDate, staffID, daysNum, [place], securityInsure, price) " +
                                          "values ({0}, '{1}', #{2}#, '{3}', {4}, '{5}', {6}, {7})",
                                          journeyCode, journeyName, journeyDate.ToString("yyyy/MM/dd"), staffID, daysNum, place, securityInsure, price);
            DbMain.InsDelUpd(SqlStr);
        }

        public void Delete(int IdKey)
        {
            string SqlStr = string.Format("delete from journies where journeyCode={0}", IdKey);
            DbMain.InsDelUpd(SqlStr);
        }

        public void Update()
        {
            // תיקון קריטי: הוספת WHERE כדי לא לעדכן את כל הטבלה
            // הוספת סוגריים מרובעים סביב [place] כי זו מילה שמורה ב-SQL
            string SqlStr = string.Format("update journies set journeyName='{1}', journeyDate=#{2}#, staffID='{3}', daysNum={4}, [place]='{5}', securityInsure={6}, price={7} " +
                                          "where journeyCode={0}",
                                          journeyCode, journeyName, journeyDate.ToString("yyyy/MM/dd"), staffID, daysNum, place, securityInsure, price);
            DbMain.InsDelUpd(SqlStr);
        }

        public DataSet GetInfoByIdKey(int IdKey)
        {
            // הסרת Customer db
            string SqlStr = string.Format("select * from journies where journeyCode={0}", IdKey);
            return DbMain.ReturnDS(SqlStr);
        }

        public bool Found(int Id)
        {
            string str = string.Format("select * from journies where journeyCode={0}", Id);
            DataSet ds = DbMain.ReturnDS(str);
            return (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0);
        }
    }
}