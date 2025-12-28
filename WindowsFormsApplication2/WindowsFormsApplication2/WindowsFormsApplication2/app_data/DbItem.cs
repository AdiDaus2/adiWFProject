using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace WindowsFormsApplication2
{
    class DbItem : DbMain
    {
        public void insertItem(Item s)
        {
            string SqlStr = string.Format("insert into item(itemCode,itemName,itemPrice,quantity)values('{0}','{1}','{2}','{3}')", s.ItemCode, s.ItemName, s.ItemPrice, s.Quantity);
            base.insertRow(SqlStr);

        }
        public void deleteItem(Item s)
        {
            string SqlStr = string.Format("delete  from item where itemCode={0}", s.ItemCode);
            base.deleteRow(SqlStr);

        }
        public void deleteItem(int id)
        {
            string SqlStr = string.Format("delete  from item where itemCode={0}", id);
            base.deleteRow(SqlStr);

        }
        public void updateItem(Item s)
        {
            string SqlStr = string.Format("update item   set itemName='{0}', itemPrice='{1}',quantity='{2}' where customerId={6}", s.ItemCode, s.ItemName, s.ItemPrice, s.Quantity);
            base.deleteRow(SqlStr);
        }

        //פעולת חיפוש פריט לפי ת.ז
        public DataSet GetCustomersinfo(Item s)
        {
            DataSet ds = new DataSet();
            string SqlStr = string.Format("select * from item where itemCode={0}", s.ItemCode);
            ds = ReturnDS(SqlStr);
            return ds;
        }

        //פעולה מחזירה אמת אם פריט נמצא אחרת מחזירה שקר לפי תז
        public bool Found(int itemCode)
        {
            DataSet ds = new DataSet();
            string str = string.Format("select * from Customers where itemCode={0} ", itemCode);
            ds = ReturnDS(str);
            if (ds.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;
        }






    }
}
