using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;


namespace WindowsFormsApplication2
{
    class buyingFromSuplier: Person, DbInterface
    {
        private int buyId;
        private DateTime buyDate;
        private int supplierId;
        private DateTime receiveDate;
        private int itemId;
        private int quantity;

        public int BuyId { get => buyId; set => buyId = value; }
        public DateTime BuyDate { get => buyDate; set => buyDate = value; }
        public int SupplierId { get => supplierId; set => supplierId = value; }
        public DateTime ReceiveDate { get => receiveDate; set => receiveDate = value; }
        public int ItemId { get => itemId; set => itemId = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public void Insert()
        {
            string SqlStr = string.Format("insert into buyingFromSuplier(buyId,buyDate,supplierId,receiveDate)values({0},'{1}','{2}','{3}')", BuyId,BuyDate,SupplierId,ReceiveDate);
            DbMain.InsDelUpd(SqlStr);

        }
        public void Delete(int IdKey)
        {
            string SqlStr = string.Format("delete  from buyingFromSuplier where buyId ={0}", IdKey);
            DbMain.InsDelUpd(SqlStr);
        }
        public void Update()
        {
            string SqlStr = string.Format("update  buyingFromSuplier set buyDate = '{0}',supplierId = '{1}', receiveDate='{2}', customerPhoneNum={3} ,customerCity='{4}',customerEmail='{5}'  where buyId={6} ", base.PersonLastName, base.PersonFirstName, base.PersonAddress, base.PersonPhoneNum, base.PersonCity, base.PersonEmail,  base.PersonId);
            DbMain.InsDelUpd(SqlStr);

        }

        //פעולת חיפוש רשומה לפי שדה מפתח
        public DataSet GetInfoByIdKey(int IdKey)
        {
            Customer db = new Customer();
            DataSet ds = new DataSet();
            string SqlStr = string.Format("select * from buyingFromSuplier where buyId={0}", IdKey);
            ds = DbMain.ReturnDS(SqlStr);
            return ds;
        }

        //פעולה מחזירה אמת אם הרשומה נמצאת אחרת מחזירה שקר לפי שדה מפתח
        public bool Found(int Id)
        {
            DataSet ds = new DataSet();
            string str = string.Format("select * from buyingFromSuplier where customerId={0} ", Id);
            ds = DbMain.ReturnDS(str);
            if (ds.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;

        }


    }
}
