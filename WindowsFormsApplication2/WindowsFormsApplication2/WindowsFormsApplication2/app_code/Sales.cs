using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;


namespace WindowsFormsApplication2
{
   class Sales:DbInterface
    {
      private int saleCode;
      private DateTime saleDate;
      private int workerNum;
      private int customerId;
      public string paymentMethod;
      public string creditCompany;
      public string creditNum;
      public int creditExpirationYear;
      public int creditExpirationMonth;
      private string discount;
      private double saleTotal;
      

      public Sales()
      {
      }

        public Sales(int workerNum)
        {
            this.workerNum = workerNum;
        }

        public int SaleCode
      {
          get { return saleCode; }
          set { saleCode = value; }
      }

      public DateTime SaleDate
      {
          get { return saleDate; }
          set { saleDate = value; }
      }

      

      public int CustomerId
      {
          get { return customerId; }
          set { customerId = value; }
      }

          


      public string PaymentMethod
      {
          get { return paymentMethod; }
          set { paymentMethod = value; }
      }

      public string CreditCompany
      {
          get { return creditCompany; }
          set { creditCompany = value; }
      }

      public string CreditNum
      {
          get { return creditNum; }
          set { creditNum = value; }
      }

      public int CreditExpirationYear
      {
          get { return creditExpirationYear; }
          set { creditExpirationYear = value; }
      }

      public int CreditExpirationMonth
      {
          get { return creditExpirationMonth; }
          set { creditExpirationMonth = value; }
      }

      public string Discount
      {
          get { return discount; }
          set { discount = value; }
      }

      public double SaleTotal
      {
          get { return saleTotal; }
          set { saleTotal = value; }
      }
      public void Insert()
      {
          string SqlStr = string.Format("insert into Sales(clientID,salesDate,total)values('{0}','{1}','{2}')", CustomerId, SaleDate, saleTotal);
          DbMain.InsDelUpd(SqlStr);

      }
     
      public void Delete(int IdKey)
        {
            string SqlStr = string.Format("delete  from Sale where salesID={0}", IdKey);
            DbMain.InsDelUpd(SqlStr);
        }
      public void Update()
      {
            string SqlStr = string.Format("update Sales   set SaleDate='{0}', SaleDate='{1}', customerId='{2}' ,wokerNum='{3}' where customerId={4}",  CustomerId, SaleDate, workerNum,SaleCode);
            DbMain.InsDelUpd(SqlStr);
        }

        //פעולת חיפוש רשומה לפי שדה מפתח
        public DataSet GetInfoByIdKey(int IdKey)
        {
            Customer db = new Customer();
            DataSet ds = new DataSet();
            string SqlStr = string.Format("select * from sales where salesID={0}", IdKey);
            ds = DbMain.ReturnDS(SqlStr);
            return ds;
        }

        //פעולה מחזירה אמת אם הרשומה נמצאת אחרת מחזירה שקר לפי שדה מפתח
        public bool Found(int Id)
        {
            DataSet ds = new DataSet();
            string str = string.Format("select * from sales where salesID={0} ", Id);
            ds = DbMain.ReturnDS(str);
            if (ds.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;

        }



    }
}
