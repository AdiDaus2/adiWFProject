using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;


namespace WindowsFormsApplication2
{
     class Supplier : Person,DbInterface
    {
        
        private string supplierContactNum;

        public Supplier()
        {

        }
               
        public string SupplierContactNum
        {
            get { return supplierContactNum; }
            set { supplierContactNum = value; }
        }
        public void Insert()
        {
            string SqlStr = string.Format("insert into supplier(supplierId,supplierName,supplierContactNum)values('{0}','{1}','{2}')", base.PersonId, base.PersonLastName, supplierContactNum);
            DbMain.InsDelUpd(SqlStr);

        }
        public void Delete(int IdKey)
        {
            string SqlStr = string.Format("delete  from workers where supplierId={0}", IdKey);
            DbMain.InsDelUpd(SqlStr);

        }
        
        public void Update()
        {
            string SqlStr = string.Format("update workers   set supplierName='{0}', supplierContactNum='{1}' where supplierId={2}", base.PersonLastName, supplierContactNum, base.PersonId);
            DbMain.InsDelUpd(SqlStr);
        }


        //פעולת חיפוש רשומה לפי שדה מפתח
        public DataSet GetInfoByIdKey(int IdKey)
        {
            Customer db = new Customer();
            DataSet ds = new DataSet();
            string SqlStr = string.Format("select * from supplier where supplierID={0}", IdKey);
            ds = DbMain.ReturnDS(SqlStr);
            return ds;
        }

        //פעולה מחזירה אמת אם הרשומה נמצאת אחרת מחזירה שקר לפי שדה מפתח
        public bool Found(int Id)
        {
            DataSet ds = new DataSet();
            string str = string.Format("select * from supplier where supplierID={0} ", Id);
            ds = DbMain.ReturnDS(str);
            if (ds.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;

        }






    }
}
