using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;


namespace WindowsFormsApplication2
{
     class SaleDetails:DbInterface  
    {
        private int saleCode;
        private int itemCode;
        private int wantedQuantity;

        public SaleDetails()
        {
        }

        public int SaleCode
        {
            get { return saleCode; }
            set { saleCode = value; }
        }

        public int ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }


        public int WantedQuantity
        {
            get { return wantedQuantity; }
            set { wantedQuantity = value; }
        }
        public void Insert()
        {
            string SqlStr = string.Format("insert into salesDetails(salesDetailsID,itemID,amount)values('{0}','{1}','{2}')", SaleCode, ItemCode, WantedQuantity);
            DbMain.InsDelUpd(SqlStr);

        }
        
        public void Delete(int IdKey)
        {
            string SqlStr = string.Format("delete  from salesDetails where salesDetailsID={0}", IdKey);
            DbMain.InsDelUpd(SqlStr);
         }
        public void Update()
        {
            string SqlStr = string.Format("update salesDetails   set itemID'{0}', amount='{1}' where salesDetailsID={6}", ItemCode, WantedQuantity, SaleCode);
            DbMain.InsDelUpd(SqlStr);
        }

        public DataSet GetInfoByIdKey(int IdKey)
        {
            Customer db = new Customer();
            DataSet ds = new DataSet();
            string SqlStr = string.Format("select * from salesDetails where salesID={0}", IdKey);
            ds = DbMain.ReturnDS(SqlStr);
            return ds;
        }

        //פעולה מחזירה אמת אם הרשומה נמצאת אחרת מחזירה שקר לפי שדה מפתח
        public bool Found(int Id)
        {
            DataSet ds = new DataSet();
            string str = string.Format("select * from salesDetails where salesID={0} ", Id);
            ds = DbMain.ReturnDS(str);
            if (ds.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;

        }






    }
}
