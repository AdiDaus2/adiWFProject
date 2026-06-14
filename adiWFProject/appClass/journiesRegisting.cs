/*
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adiWFProject
{
    internal class journiesRegisting : DbInterface
    {
        private string pupilID;
        private int parentPhoneNum;
        private Boolean selfHealth;
        private int journeyCode;
        private string journeyName;
        private string pupilName;
        private DateTime registerDate;
        private string place;
        private int totalPayment;
        private string paymentType;
        private string creditCardType;
        private int creditCardNumber;

        public journiesRegisting()
        { }

        public string JourneyName
        {
            get { return journeyName; }
            set { journeyName = value; }
        }
        public string PupilName
        {
            get { return pupilName; }
            set { pupilName = value; }
        }
        public string Place
        {
            get { return place; }
            set { place = value; }
        }
        public int ParentPhoneNum
        {
            get { return parentPhoneNum; }
            set { parentPhoneNum = value; }
        }
        public int JourneyCode
        {
            get { return journeyCode; }
            set { journeyCode = value; }
        }

        public string PupilID
        {
            get { return pupilID; }
            set { pupilID = value; }
        }

        public Boolean SelfHealth
        {
            get { return selfHealth; }
            set { selfHealth = value; }
        }

        public DateTime RegisterDate
        {
            get { return registerDate; }
            set { registerDate = value; }
        }

        public int TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }

        public string PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }

        public string CreditCardType
        {
            get { return creditCardType; }
            set { creditCardType = value; }
        }

        public int CreditCardNumber
        {
            get { return creditCardNumber; }
            set { creditCardNumber = value; }
        }

        public void Insert()
        {
        
            string SqlStr = string.Format("INSERT INTO journiesRegisting(journeyCode, journeyName, pupilID, pupilName, place, parentPhoneNum, selfHealth, registerDate, totalPayment, paymentType, creditCardType) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", journeyCode, journeyName, pupilID, pupilName, place, parentPhoneNum, selfHealth, registerDate, totalPayment, paymentType, creditCardType);
            DbMain.InsDelUpd(SqlStr);
        }

        public void Delete(int IdKey)
        {
            string SqlStr = string.Format("delete  from journiesRegisting where journeyCode={0}", IdKey);
            DbMain.InsDelUpd(SqlStr);

        }

        public void Update()
        {
            string SqlStr = string.Format("update journiesRegisting set journeyCode='{0}', journeyName = '{1}', pupilID='{2}', pupilName='{3}', place='{4}', parentPhoneNum='{5}', selfHealth='{6}', registerDate='{7}', totalPayment='{8}', paymentType='{9}', creditCardType='{10}'", journeyCode, journeyName, pupilID, pupilName, place, parentPhoneNum, selfHealth, registerDate, totalPayment, paymentType, creditCardType);
            DbMain.InsDelUpd(SqlStr);
        }



        //פעולת חיפוש רשומה לפי שדה מפתח
        public DataSet GetInfoByIdKey(int IdKey)
        {
            Customer db = new Customer();
            DataSet ds = new DataSet();
            string SqlStr = string.Format("select * from journiesRegisting where journeyCode={0}", IdKey);
            ds = DbMain.ReturnDS(SqlStr);
            return ds;
        }

        //פעולה מחזירה אמת אם הרשומה נמצאת אחרת מחזירה שקר לפי שדה מפתח
        public bool Found(int Id)
        {
            DataSet ds = new DataSet();
            string str = string.Format("select * from journiesRegisting where journeyCode={0} ", Id);
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
    internal class journiesRegisting : DbInterface
    {
        private string pupilID;
        private string parentPhoneNum; // שינוי מ-int ל-string (טלפון מתחיל ב-0)
        private bool selfHealth;
        private int journeyCode;
        private string journeyName;
        private DateTime registerDate;
        private string place;
        private int totalPayment;
        private string paymentType;
        private string creditCardType;
        private string creditCardNumber; // שינוי ל-string למניעת חריגת מספרים

        public journiesRegisting()
        { }

        #region Properties
        public string JourneyName { get { return journeyName; } set { journeyName = value; } }
        public string Place { get { return place; } set { place = value; } }
        public string ParentPhoneNum { get { return parentPhoneNum; } set { parentPhoneNum = value; } }
        public int JourneyCode { get { return journeyCode; } set { journeyCode = value; } }
        public string PupilID { get { return pupilID; } set { pupilID = value; } }
        public bool SelfHealth { get { return selfHealth; } set { selfHealth = value; } }
        public DateTime RegisterDate { get { return registerDate; } set { registerDate = value; } }
        public int TotalPayment { get { return totalPayment; } set { totalPayment = value; } }
        public string PaymentType { get { return paymentType; } set { paymentType = value; } }
        public string CreditCardType { get { return creditCardType; } set { creditCardType = value; } }
        public string CreditCardNumber { get { return creditCardNumber; } set { creditCardNumber = value; } }
        #endregion

        public void Insert()
        {
            // שים לב לגרשיים: מספרים (journeyCode, totalPayment) ללא גרש, טקסט ותאריך עם גרש/סולמית
            string SqlStr = string.Format("INSERT INTO journiesRegisting (journeyCode, journeyName, pupilID, place, parentPhoneNum, selfHealth, registerDate, totalPayment, paymentType, creditCardType) " +
                "values ({0}, '{1}', '{2}', '{3}', '{4}', {5}, #{6}#, {7}, '{8}', '{9}')",
                journeyCode, journeyName, pupilID, place, parentPhoneNum, selfHealth, registerDate.ToString("yyyy/MM/dd"), totalPayment, paymentType, creditCardType);

            DbMain.InsDelUpd(SqlStr);
        }

        // דוגמה לאיך זה צריך להיראות בתוך journiesRegisting.cs
        public void Delete(string pId, int jCode)
        {
            string sql = string.Format("DELETE FROM journiesRegisting WHERE pupilID='{0}' AND journeyCode={1}", pId, jCode);
            DbMain.InsDelUpd(sql);
        }

        // מימוש חובה של ה-Interface (לפי חתימה קבועה)
        public void Delete(int IdKey)
        {
            string SqlStr = string.Format("DELETE FROM journiesRegisting WHERE journeyCode={0}", IdKey);
            DbMain.InsDelUpd(SqlStr);
        }

        public void Update()
        {
            // עדכון לפי מפתח כפול (מסע וחניך)
            string SqlStr = string.Format("UPDATE journiesRegisting SET journeyName='{1}', place='{2}', parentPhoneNum='{3}', selfHealth={4}, registerDate=#{5}#, totalPayment={6}, paymentType='{7}', creditCardType='{8}' " + "WHERE journeyCode={0} AND pupilID='{9}'",
                journeyCode, journeyName, place, parentPhoneNum, selfHealth, registerDate.ToString("yyyy/MM/dd"), totalPayment, paymentType, creditCardType, pupilID);

            DbMain.InsDelUpd(SqlStr);
        }

        public DataSet GetInfoByIdKey(int journeyId, string pupilId)
        {
            string SqlStr = string.Format("SELECT * FROM journiesRegisting WHERE journeyCode={0} AND pupilID='{1}'", journeyId, pupilId);
            return DbMain.ReturnDS(SqlStr);
        }

        public DataSet GetInfoByIdKey(int IdKey) // מימוש ה-Interface
        {
            string SqlStr = string.Format("SELECT * FROM journiesRegisting WHERE journeyCode={0}", IdKey);
            return DbMain.ReturnDS(SqlStr);
        }

        public bool Found(int journeyId, string pupilId)
        {
            string str = string.Format("SELECT * FROM journiesRegisting WHERE journeyCode={0} AND pupilID='{1}'", journeyId, pupilId);
            DataSet ds = DbMain.ReturnDS(str);
            return (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0);
        }

        public bool Found(int Id) // מימוש ה-Interface
        {
            string str = string.Format("SELECT * FROM journiesRegisting WHERE journeyCode={0}", Id);
            DataSet ds = DbMain.ReturnDS(str);
            return (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0);
        }
    }
}