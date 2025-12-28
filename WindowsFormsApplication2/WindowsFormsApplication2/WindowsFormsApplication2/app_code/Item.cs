using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;


namespace WindowsFormsApplication2
{
         class Item : DbInterface
    {
            private int itemCode;
            private string itemName;
            private int itemPrice;
            private int quantity;
            private string ganre;
            private int publisherId;
                   
            private string language;



            public Item()
            {
            }
            public int ItemCode
            {
                get { return itemCode; }
                set { itemCode = value; }
            }
            public string ItemName
            {
                get { return itemName; }
                set { itemName = value; }
            }
            public int ItemPrice
            {
                get { return itemPrice; }
                set { itemPrice = value; }
            }
            public int Quantity
            {
                get { return quantity; }
                set { quantity = value; }
            }
            public int PublisherId
            {
                get { return publisherId; }
                set { publisherId = value; }
            }
           public string Ganre
           {
                get { return ganre; }
                set { ganre = value; }
            }
            
            
            public string Language
            {
                get { return language; }
                set { language = value; }
            }

        

        public void Insert()
           {
           // string SqlStr = string.Format("insert into item(itemName, quantity, price,  ganre, supplierID, language) values('{0}', {1}, {2} , '{3}', {4} , '{5}')" , itemName, quantity, itemPrice, language, publisherId, ganre);
            string SqlStr = string.Format("INSERT INTO item(itemName, quantity, price, ganre, supplierID, lang) values ('{0}', {1}, {2},'{3}', {4},'{5}')", itemName, quantity, itemPrice, ganre, publisherId,language);
            DbMain.InsDelUpd(SqlStr);
        }
       
            public void Delete(int IdKey)
            {
                string SqlStr = string.Format("delete  from item where itemID={0}", IdKey);
                DbMain.InsDelUpd(SqlStr);

            }
            
            public void Update()
            {
                string SqlStr = string.Format("update item   set itemName='{0}',quantity={1}, price={2}, ganre='{3}', supplierID={4}, lang='{5}' where itemID={6}", itemName, quantity, itemPrice, ganre, publisherId, language,ItemCode);
                DbMain.InsDelUpd(SqlStr); 
               
            }
          public void UpdateQuntity()
          {
            string SqlStr = string.Format("update item  set quantity={0} where itemID={1}", Quantity, ItemCode);
            DbMain.InsDelUpd(SqlStr);
        }

        //פעולת חיפוש רשומה לפי שדה מפתח
        public DataSet GetInfoByIdKey(int IdKey)
        {
            Customer db = new Customer();
            DataSet ds = new DataSet();
            string SqlStr = string.Format("select * from item where itemId={0}", IdKey);
            ds = DbMain.ReturnDS(SqlStr);
            return ds;
        }

        //פעולה מחזירה אמת אם הרשומה נמצאת אחרת מחזירה שקר לפי שדה מפתח
        public bool Found(int Id)
        {
            DataSet ds = new DataSet();
            string str = string.Format("select * from item where itemId={0} ", Id);
            ds = DbMain.ReturnDS(str);
            if (ds.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;

        }


    }
}
