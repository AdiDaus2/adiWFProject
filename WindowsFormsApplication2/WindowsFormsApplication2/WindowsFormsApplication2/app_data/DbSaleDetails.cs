using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace WindowsFormsApplication2
{
    class DbSaleDetails : DbMain
    {
        public void insertDbSaleDetails(SaleDetails s)
        {
            string SqlStr = string.Format("insert into DbSaleDetails(saleCode,itemCode,quantity)values('{0}','{1}','{2}')", s.SaleCode, s.ItemCode, s.WantedQuantity);
            base.insertRow(SqlStr);

        }
        public void deleteDbSaleDetails(SaleDetails s)
        {
            string SqlStr = string.Format("delete  from Customers where customerId={0}", s.SaleCode);
            base.deleteRow(SqlStr);

        }
        public void deleteDbSaleDetails(int id)
        {
            string SqlStr = string.Format("delete  from Customers where saleCode={0}", id);
            base.deleteRow(SqlStr);

        }
        public void updateDbSaleDetails(SaleDetails s)
        {
            string SqlStr = string.Format("update Customers   set itemCode='{0}', quantity='{1}' where customerId={6}", s.ItemCode, s.WantedQuantity, s.SaleCode);
            base.deleteRow(SqlStr);
        }

        //פעולת חיפוש לקוח לפי ת.ז
        public DataSet GetDbSaleDetailsinfo(SaleDetails s)
        {
            DataSet ds = new DataSet();
            string SqlStr = string.Format("select * from SaleDetails where itemCode={0}", s.SaleCode);
            ds = ReturnDS(SqlStr);
            return ds;
        }

        //פעולה מחזירה אמת אם לקוח נמצא אחרת מחזירה שקר לפי תז
        public bool Found(int itemCode)
        {
            DataSet ds = new DataSet();
            string str = string.Format("select * from Customers where customerId={0} ", itemCode);
            ds = ReturnDS(str);
            if (ds.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;
        }






    }
}
