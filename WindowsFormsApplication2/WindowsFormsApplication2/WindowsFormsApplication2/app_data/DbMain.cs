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
       
        
             

        public static void InsDelUpd(string SqlStr)
        {
            /*          טענת כניסה: הפונקציה מקבלת מחרוזת פקודה
                   טענת יציאה : הפונקציה מעדכנת את בסיס הנתונים       
            */
            OleDbConnection cnn = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            DataSet ds = new DataSet();

            cnn.ConnectionString = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\access\\db2.accdb ;Persist Security Info=False";

           
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
        /*    טענת כניסה: הפונקציה מקבלת מחרוזת שליפה  
                DataSet טענת יציאה: הפונקציה מחזירה
         */
        public static  DataSet ReturnDS(string SqlStr)
        {
            DataSet ds = new DataSet();
            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection cnn = new OleDbConnection();
            cnn.ConnectionString = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\access\\db2.accdb ;Persist Security Info=False";

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




        // tableName  הפונקציה מחזירה את כל הרשומות  בטבלה  
        public  static DataSet GetAllRecord(string  tableName)
        {
            DataSet ds = new DataSet();

            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection cnn = new OleDbConnection();
            cnn.ConnectionString = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\access\\db2.accdb ;Persist Security Info=False";
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
        public static DataSet GetQuery(string sql)
        {
            DataSet ds = new DataSet();

            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection cnn = new OleDbConnection();
            cnn.ConnectionString = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\access\\db2.accdb ;Persist Security Info=False";
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

      

       

    }
}

    

