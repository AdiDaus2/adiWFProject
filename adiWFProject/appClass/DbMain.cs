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
        // פונקציית עזר פרטית לבניית מחרוזת החיבור באופן אחיד לכל המחלקה
        private static string GetConnString()
        {
            // הנתיב הדינמי: מחפש תיקיית access בתוך תיקיית ההרצה של הפרויקט
            string dbPath = Path.Combine(Application.StartupPath, "access", "Database1.accdb");
            return $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};Persist Security Info=False";
        }

        /* פונקציה לעדכון, מחיקה והכנסה (INSERT, UPDATE, DELETE)
           מחזירה את מספר השורות שהושפעו
        */
        public static void InsDelUpd(string SqlStr)
        {
            using (OleDbConnection cnn = new OleDbConnection(GetConnString()))
            {
                using (OleDbCommand cmd = new OleDbCommand(SqlStr, cnn))
                {
                    try
                    {
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show("שגיאת עדכון בסיס נתונים:\n" + ex.Message);
                    }
                    finally
                    {
                        cnn.Close();
                    }
                }
            }
        }

        /* פונקציה מרכזית לשליפת נתונים (SELECT)
           DataSet מחזירה אובייקט 
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
                    MessageBox.Show("שגיאת שליפת נתונים:\n" + e.Message);
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
           (כיום היא זהה ל-ReturnDS, שמרנו עליה בשביל תאימות לקוד קיים)
        */
        public static DataSet GetQuery(string sql)
        {
            return ReturnDS(sql);
        }
    }
}