using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;


namespace adiWFProject
{
    class Customer : Person, DbInterface
    {

        private int customerDbMonth;
        private string entryDate;

        public Customer()
        {
        }
        public int CustomerDbMonth { get => customerDbMonth; set => customerDbMonth = value; }
        public string EntryDate { get => entryDate; set => entryDate = value; }



        public void Insert()
        {
            string SqlStr = string.Format("insert into customer(customerId,customerLastName,customerFirstName,customerAddress,customerPhoneNum, customerCity, customerEmail, customerDbMonth)values({0},'{1}','{2}','{3}',{4},'{5}','{6}',{7})", base.PersonId, base.PersonLastName, base.PersonFirstName, base.PersonAddress, base.PersonPhoneNum, base.PersonCity, base.PersonEmail, customerDbMonth);
            DbMain.InsDelUpd(SqlStr);

        }
        public void Delete(int IdKey)
        {
            string SqlStr = string.Format("delete  from customer where customerId ={0}", IdKey);
            DbMain.InsDelUpd(SqlStr);
        }
        public void Update()
        {
            string SqlStr = string.Format("update  customer set customerLastName = '{0}',customerFirstName = '{1}', customerAddress='{2}', customerPhoneNum={3} ,customerCity='{4}',customerEmail='{5}',customerDbMonth = {6}  where customerId={7} ", base.PersonLastName, base.PersonFirstName, base.PersonAddress, base.PersonPhoneNum, base.PersonCity, base.PersonEmail, customerDbMonth, base.PersonId);
            DbMain.InsDelUpd(SqlStr);

        }

        //פעולת חיפוש רשומה לפי שדה מפתח
        public DataSet GetInfoByIdKey(int IdKey)
        {
            Customer db = new Customer();
            DataSet ds = new DataSet();
            string SqlStr = string.Format("select * from customer where customerId={0}", IdKey);
            ds = DbMain.ReturnDS(SqlStr);
            return ds;
        }

        //פעולה מחזירה אמת אם הרשומה נמצאת אחרת מחזירה שקר לפי שדה מפתח
        public bool Found (int Id)
        {
            DataSet ds = new DataSet();
        string str = string.Format("select * from Customer where customerId={0} ", Id);
        ds = DbMain.ReturnDS(str);
            if (ds.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;

        }


    }
}





