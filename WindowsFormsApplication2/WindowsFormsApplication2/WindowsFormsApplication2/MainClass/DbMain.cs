using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    class DbMain
    {
        private OleDbConnection cnn = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private DataSet ds = new DataSet();
        public DbMain()
        {
            cnn.ConnectionString = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=data\\dbExm.accdb ;Persist Security Info=False";
        }
        // tableName  הפונקציה מחזירה את כל הרשומות  בטבלה  
        public DataSet GetAllRecord(string  tableName)
        {
            DataSet ds = new DataSet();

            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cmd.CommandText = "select * from " + tableName;
                cmd.Connection = cnn;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { cnn.Close(); }
            return ds;
        }

        //  SQL    הפונקציה מחזירה נתונים לפי מחרוזת שליפה    
        public DataSet GetQuery(string sql)
        {
            DataSet ds = new DataSet();

            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cmd.CommandText = sql;
                cmd.Connection = cnn;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { cnn.Close(); }
            return ds;
        }

        //הוספת שורה לטבלה
        public void insertRow(string insetString )
        {
           // string SqlStr = string.Format("insert into Customers(customerId,customerName,customerAddress,customerPhoneNum,customerCity,customerEmail,customerBDMonth)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", s.CustomerId, s.CustomerName, s.CustomerAddress, s.CustomerPhoneNum, s.CustomerCity, s.CustomerEmail, s.CustomerBDMonth);
            InsDelUpd(insetString);
        }
        // מחיקת שורה מהטבלה 
        public void deleteRow(string deletString)
        {
           // string SqlStr = string.Format("delete  from Customers where customerId={0}", customerId);
            InsDelUpd(deletString);
        }
        //עדכון שורה בטבלה
        public void updateRow(string updateString)
        {
            //string SqlStr = string.Format("update Customers   set customerName='{0}', customerAddress='{1}', customerPhoneNum='{2}' ,customerCity='{3}',customerEmail='{4}',customerBDMonth='{5}' where customerId={6}",s.CustomerName, s.CustomerAddress, s.CustomerPhoneNum, s.CustomerCity, s.CustomerEmail, s.CustomerBDMonth, s.CustomerId);
            InsDelUpd(updateString);
        }

        public void InsDelUpd(string SqlStr)
        {
            /*          טענת כניסה: הפונקציה מקבלת מחרוזת פקודה
                   טענת יציאה : הפונקציה מעדכנת את בסיס הנתונים       
            */
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                // פתיחת ההתחברות עם בסיס הנתונים 
                cnn.Open();
                cmd.Connection = cnn;
                // sql  מאפיין אשר מאפשר לקבוע או לקבל את הוראת :CommandText המאפיין   
                cmd.CommandText = SqlStr;
                // (Delete,Update,Insert) לעדכון בסיס הנתונים sql מתודה שמבצעת הוראת 
                cmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // סגירת ההתחברות (סגירת הקשר עם בסיס הנתונים חיונית בשביל לתרום ליעילות האפליקציה
                cnn.Close();
            }
        }
        /* טענת כניסה: הפונקציה מקבלת מחרוזת פקודה
                DataSet טענת יציאה: הפונקציה מחזירה
         */
        public DataSet ReturnDS(string SqlStr)
        {
            DataSet ds = new DataSet();
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                //  sql מאפיין אשר מאפשר לקבוע או לקבל את הוראת :CommandText
                cmd.CommandText = SqlStr;
                //  OleDbConnection מאפיין אשר מאפשר לקבוע או לקבל את אובייקט ההתחברות מהמחלקה :Connection
                cmd.Connection = cnn;
                //DataSet ומשימה שנייה בכדי לעדכן את בסיס הנתונים בהתאם למידע שהתרחש ב  DataSet יצירת מופע למחלקה המייצגת אובייקט ההתחברות לבסיס הנתונים. ייצוג זה דרוש לשתי משימות משימה ראשונה בכדי להעביר נתונים מבסיס הנתונים ל 
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                // DataSet טוענת את הנתונים לתוך אובייקט  Fill המתודה 
                da.Fill(ds);
            }
            catch (Exception e)
            { MessageBox.Show(e.Message); }
            finally
            {
                cnn.Close();
            }
            return ds;
        }
        

    }
}

    

