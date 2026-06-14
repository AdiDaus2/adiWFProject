using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace adiWFProject
{
    class DbMain
    {
        // פונקציית עזר פרטית לבניית מחרוזת החיבור באופן קבוע ויציב עבור המחשב שלך
        private static string GetConnString()
        {
            // שימוש בנתיב ה-Full Path המדויק מהמחשב שלך
            string dbPath = @"C:\Users\ronen\OneDrive\שולחן העבודה\עדי - פרוייקט י_ב\adiWFProject\adiWFProject\access\Database1.accdb";
            return $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};Persist Security Info=False";
        }

        /* פונקציה לעדכון, מחיקה והכנסה (INSERT, UPDATE, DELETE)
           מחזירה אומדן האם הפעולה הצליחה
        */
        public static bool InsDelUpd(string SqlStr)
        {
            using (OleDbConnection cnn = new OleDbConnection(GetConnString()))
            {
                using (OleDbCommand cmd = new OleDbCommand(SqlStr, cnn))
                {
                    try
                    {
                        cnn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show("שגיאת עדכון בסיס נתונים:\n" + ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    finally
                    {
                        cnn.Close();
                    }
                }
            }
        }

        /* פונקציה מרכזית לשליפת נתונים (SELECT)
           מחזירה אובייקט DataSet
        */
        public static DataSet ReturnDS(string SqlStr)
        {
            DataSet ds = new DataSet();
            using (OleDbConnection cnn = new OleDbConnection(GetConnString()))
            {
                try
                {
                    OleDbDataAdapter da = new OleDbDataAdapter(SqlStr, cnn);
                    da.Fill(ds);
                }
                catch (Exception e)
                {
                    MessageBox.Show("שגיאת שליפת נתונים:\n" + e.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cnn.Close();
                }
            }
            return ds;
        }

        /*
           פונקציה לשליפת כל הרשומות מטבלה מסוימת
        */
        public static DataSet GetAllRecord(string tableName)
        {
            string sql = "SELECT * FROM " + tableName;
            return ReturnDS(sql);
        }

        /*
           פונקציית GetQuery - לשימוש בשאילתות חופשיות
        */
        public static DataSet GetQuery(string sql)
        {
            return ReturnDS(sql);
        }

        /* פונקציה חדשה: שליפת נתונים ישירות כ-DataTable
           מצוינת לעבודה עם דוחות, לולאות וחישובי סטטיסטיקות
        */
        public static DataTable GetTable(string SqlStr)
        {
            DataSet ds = ReturnDS(SqlStr);
            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            return null;
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.OleDb;
//using System.Data;
//using System.Windows.Forms;
//using System.IO;

//namespace adiWFProject
//{
//    class DbMain
//    {
//        // פונקציית עזר פרטית לבניית מחרוזת החיבור באופן קבוע ויציב עבור המחשב שלך
//        private static string GetConnString()
//        {
//            // שימוש בנתיב ה-Full Path המדויק מהמחשב שלך
//            string dbPath = @"C:\Users\ronen\OneDrive\שולחן העבודה\עדי - פרוייקט י_ב\adiWFProject\adiWFProject\access\Database1.accdb";
//            return $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};Persist Security Info=False";
//        }

//        /* פונקציה לעדכון, מחיקה והכנסה (INSERT, UPDATE, DELETE)
//           מחזירה אומדן האם הפעולה הצליחה
//        */
//        public static bool InsDelUpd(string SqlStr)
//        {
//            using (OleDbConnection cnn = new OleDbConnection(GetConnString()))
//            {
//                using (OleDbCommand cmd = new OleDbCommand(SqlStr, cnn))
//                {
//                    try
//                    {
//                        cnn.Open();
//                        int rowsAffected = cmd.ExecuteNonQuery();
//                        return rowsAffected > 0;
//                    }
//                    catch (OleDbException ex)
//                    {
//                        MessageBox.Show("שגיאת עדכון בסיס נתונים:\n" + ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                        return false;
//                    }
//                    finally
//                    {
//                        cnn.Close();
//                    }
//                }
//            }
//        }

//        /* פונקציה מרכזית לשליפת נתונים (SELECT)
//           מחזירה אובייקט DataSet
//        */
//        public static DataSet ReturnDS(string SqlStr)
//        {
//            DataSet ds = new DataSet();
//            using (OleDbConnection cnn = new OleDbConnection(GetConnString()))
//            {
//                try
//                {
//                    OleDbDataAdapter da = new OleDbDataAdapter(SqlStr, cnn);
//                    da.Fill(ds);
//                }
//                catch (Exception e)
//                {
//                    MessageBox.Show("שגיאת שליפת נתונים:\n" + e.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//                finally
//                {
//                    cnn.Close();
//                }
//            }
//            return ds;
//        }

//        /*
//           פונקציה לשליפת כל הרשומות מטבלה מסוימת
//        */
//        public static DataSet GetAllRecord(string tableName)
//        {
//            string sql = "SELECT * FROM " + tableName;
//            return ReturnDS(sql);
//        }

//        /*
//           פונקציית GetQuery - לשימוש בשאילתות חופשיות
//        */
//        public static DataSet GetQuery(string sql)
//        {
//            return ReturnDS(sql);
//        }
//    }
//}

////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;
////using System.Data.OleDb;
////using System.Data;
////using System.Windows.Forms;
////using System.IO;

////namespace adiWFProject
////{
////    class DbMain
////    {
////        // פונקציית עזר פרטית לבניית מחרוזת החיבור באופן אחיד לכל המחלקה
////        private static string GetConnString()
////        {
////            // הנתיב הדינמי: מחפש תיקיית access בתוך תיקיית ההרצה של הפרויקט
////            string dbPath = Path.Combine(Application.StartupPath, "access", "Database1.accdb");
////            return $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};Persist Security Info=False";
////        }

////        /* פונקציה לעדכון, מחיקה והכנסה (INSERT, UPDATE, DELETE)
////           מחזירה את מספר השורות שהושפעו
////        */
////        public static void InsDelUpd(string SqlStr)
////        {
////            using (OleDbConnection cnn = new OleDbConnection(GetConnString()))
////            {
////                using (OleDbCommand cmd = new OleDbCommand(SqlStr, cnn))
////                {
////                    try
////                    {
////                        cnn.Open();
////                        cmd.ExecuteNonQuery();
////                    }
////                    catch (OleDbException ex)
////                    {
////                        MessageBox.Show("שגיאת עדכון בסיס נתונים:\n" + ex.Message);
////                    }
////                    finally
////                    {
////                        cnn.Close();
////                    }
////                }
////            }
////        }

////        /* פונקציה מרכזית לשליפת נתונים (SELECT)
////           DataSet מחזירה אובייקט 
////        */
////        public static DataSet ReturnDS(string SqlStr)
////        {
////            DataSet ds = new DataSet();
////            using (OleDbConnection cnn = new OleDbConnection(GetConnString()))
////            {
////                try
////                {
////                    OleDbDataAdapter da = new OleDbDataAdapter(SqlStr, cnn);
////                    da.Fill(ds);
////                }
////                catch (Exception e)
////                {
////                    MessageBox.Show("שגיאת שליפת נתונים:\n" + e.Message);
////                }
////                finally
////                {
////                    cnn.Close();
////                }
////            }
////            return ds;
////        }

////        /*
////           פונקציה לשליפת כל הרשומות מטבלה מסוימת
////        */
////        public static DataSet GetAllRecord(string tableName)
////        {
////            string sql = "SELECT * FROM " + tableName;
////            return ReturnDS(sql);
////        }

////        /*
////           פונקציית GetQuery - לשימוש בשאילתות חופשיות
////           (כיום היא זהה ל-ReturnDS, שמרנו עליה בשביל תאימות לקוד קיים)
////        */
////        public static DataSet GetQuery(string sql)
////        {
////            return ReturnDS(sql);
////        }
////    }
////}