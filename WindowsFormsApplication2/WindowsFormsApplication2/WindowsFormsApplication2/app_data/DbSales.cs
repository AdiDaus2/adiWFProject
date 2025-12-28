using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace WindowsFormsApplication2
{
    class DbSale : DbMain
    {
        public void insertSale(Sales s)
        {
            string SqlStr = string.Format("insert into Sale(SaleCode,SaleDate,customerId,wokerNum)values('{0}','{1}','{2}','{3}','{4}')", s.SaleCode, s.CustomerId, s.SaleDate, s.EmployeeNum);
            base.insertRow(SqlStr);

        }
        public void deleteSale(Sales s)
        {
            string SqlStr = string.Format("delete  from Customers where customerId={0}", s.CustomerId);
            base.deleteRow(SqlStr);

        }
        public void deleteSale(int id)
        {
            string SqlStr = string.Format("delete  from Sale where customerId={0}", id);
            base.deleteRow(SqlStr);

        }
        public void updateSale(Sales s)
        {
          //  string SqlStr = string.Format("update Sales   set customerName='{0}', customerAddress='{1}', customerPhoneNum='{2}' ,customerCity='{3}',customerEmail='{4}',customerBDMonth='{5}' where customerId={6}", s.CustomerName, s.CustomerAddress, s.CustomerPhoneNum, s.CustomerCity, s.CustomerEmail, s.CustomerBDMonth, s.CustomerId);
        //    base.deleteRow(SqlStr);
        }

        //פעולת חיפוש לקוח לפי ת.ז
        public DataSet GetSaleinfo(Sales s)
        {
            DataSet ds = new DataSet();
            string SqlStr = string.Format("select * from Sale where SaleId={0}", s.SaleCode);
            ds = ReturnDS(SqlStr);
            return ds;
        }

        //פעולה מחזירה אמת אם לקוח נמצא אחרת מחזירה שקר לפי תז
        public bool Found(int SaleCode)
        {
            DataSet ds = new DataSet();
            string str = string.Format("select * from Customers where SaleCode={0} ", SaleCode);
            ds = ReturnDS(str);
            if (ds.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;
        }






    }
}
