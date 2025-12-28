using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace WindowsFormsApplication2
{
    class DbWorkers : DbMain
    {
        public void insertCustomers(Workers s)
        {
          //  string SqlStr = string.Format("insert into workers(customerId,customerName,customerAddress,customerPhoneNum,customerCity,customerEmail,customerBDMonth)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", s.CustomerId, s.CustomerName, s.CustomerAddress, s.CustomerPhoneNum, s.CustomerCity, s.CustomerEmail, s.CustomerBDMonth);
         //   base.insertRow(SqlStr);

        }
        public void deleteCustomers(Workers s)
        {
            string SqlStr = string.Format("delete  from workers where workerNum={0}", s.WorkerNum);
            base.deleteRow(SqlStr);

        }
        public void deleteCustomers(int id)
        {
            string SqlStr = string.Format("delete  from workers where workerNum={0}", id);
            base.deleteRow(SqlStr);

        }
        public void updateCustomers(Workers s)
        {
           // string SqlStr = string.Format("update workers   set customerName='{0}', customerAddress='{1}', customerPhoneNum='{2}' ,customerCity='{3}',customerEmail='{4}',customerBDMonth='{5}' where customerId={6}", s.CustomerName, s.CustomerAddress, s.CustomerPhoneNum, s.CustomerCity, s.CustomerEmail, s.CustomerBDMonth, s.CustomerId);
           // base.deleteRow(SqlStr);
        }

        //פעולת חיפוש לקוח לפי ת.ז
        public DataSet GetCustomersinfo(Workers s)
        {
            DataSet ds = new DataSet();
            string SqlStr = string.Format("select * from Customers where customerId={0}", s.WorkerNum);
            ds = ReturnDS(SqlStr);
            return ds;
        }

        //פעולה מחזירה אמת אם לקוח נמצא אחרת מחזירה שקר לפי תז
        public bool Found(int workerNum)
        {
            DataSet ds = new DataSet();
            string str = string.Format("select * from workers where workerNum={0} ", workerNum);
            ds = ReturnDS(str);
            if (ds.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;
        }

    }
}
