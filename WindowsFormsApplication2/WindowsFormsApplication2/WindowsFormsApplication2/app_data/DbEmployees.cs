//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.OleDb;
//using System.Data;

//namespace WindowsFormsApplication2
//{
//    class DbCustomer : DbMain
//    {
//        public void insertCustomers(Customers s)
//        {
//            string SqlStr = string.Format("insert into Customers(customerId,customerName,customerAddress,customerPhoneNum,customerCity,customerEmail,customerBDMonth)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", s.CustomerId, s.CustomerName, s.CustomerAddress, s.CustomerPhoneNum, s.CustomerCity, s.CustomerEmail, s.CustomerBDMonth);
//            base.insertRow(SqlStr);

//        }
//        public void deleteCustomers(Customers s)
//        {
//            string SqlStr = string.Format("delete  from Customers where customerId={0}", s.CustomerId);
//            base.deleteRow(SqlStr);

//        }
//        public void deleteCustomers(int id)
//        {
//            string SqlStr = string.Format("delete  from Customers where customerId={0}", id);
//            base.deleteRow(SqlStr);

//        }
//        public void updateCustomers(Customers s)
//        {
//            string SqlStr = string.Format("update Customers   set customerName='{0}', customerAddress='{1}', customerPhoneNum='{2}' ,customerCity='{3}',customerEmail='{4}',customerBDMonth='{5}' where customerId={6}", s.CustomerName, s.CustomerAddress, s.CustomerPhoneNum, s.CustomerCity, s.CustomerEmail, s.CustomerBDMonth, s.CustomerId);
//            base.deleteRow(SqlStr);
//        }

//        //פעולת חיפוש לקוח לפי ת.ז
//        public DataSet GetCustomersinfo(Customers s)
//        {
//            DataSet ds = new DataSet();
//            string SqlStr = string.Format("select * from Customers where customerId={0}", s.CustomerId);
//            ds = ReturnDS(SqlStr);
//            return ds;
//        }

//        //פעולה מחזירה אמת אם לקוח נמצא אחרת מחזירה שקר לפי תז
//        public bool Found(int Idcustomer)
//        {
//            DataSet ds = new DataSet();
//            string str = string.Format("select * from Customers where customerId={0} ", Idcustomer);
//            ds = ReturnDS(str);
//            if (ds.Tables[0].Rows.Count == 0)
//                return false;
//            else
//                return true;
//        }






//    }
//}
