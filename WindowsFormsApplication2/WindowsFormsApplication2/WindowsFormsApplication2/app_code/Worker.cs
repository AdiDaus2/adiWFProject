using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;


namespace WindowsFormsApplication2
{
    class Worker : Person, DbInterface
    {
       
        private string startDate;
        private string jobTitle;
        private string password;

        public Worker()
        {
        }

               
        
        public string StartDate { get => startDate; set => startDate = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public string Password { get => password; set => password = value; }
        public void Insert()
        {
            string SqlStr = string.Format("insert into worker(workerID,workerLastName,workerFirstname,adress,city,workersPhoneNum,email,stratDate, jobTitle, pass)values({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", base.PersonId, base.PersonLastName, base.PersonFirstName, base.PersonAddress, base.PersonCity ,base.PersonPhoneNum, base.PersonEmail, startDate, jobTitle, password);
            DbMain.InsDelUpd(SqlStr);

        }
        public void Delete(int IdKey)
        {
            string SqlStr = string.Format("delete  from worker where workerID={0}", IdKey);
            DbMain.InsDelUpd(SqlStr);
        }      
        public void Update()
        {
            string SqlStr = string.Format("update worker   set WorkerLastName='{0}', workerFirstname={1},address={2}',city='{3}',WorkersPhoneNum='{4}',email='{5}',startDate='{6}', jobTitle='{7}', password='{8}' where workerId={9}", base.PersonLastName, base.PersonFirstName, base.PersonAddress, base.PersonCity, base.PersonPhoneNum, base.PersonEmail, startDate, jobTitle, password, base.PersonId);
            DbMain.InsDelUpd(SqlStr);
        }
        public DataSet GetInfoByIdKey(int IdKey)
        {
            Customer db = new Customer();
            DataSet ds = new DataSet();
            string SqlStr = string.Format("select * from worker where workerID={0}", IdKey);
            ds = DbMain.ReturnDS(SqlStr);
            return ds;
        }

        //פעולה מחזירה אמת אם הרשומה נמצאת אחרת מחזירה שקר לפי שדה מפתח
        public bool Found(int Id)
        {
            DataSet ds = new DataSet();
            string str = string.Format("select * from worker where workerID={0} ", Id);
            ds = DbMain.ReturnDS(str);
            if (ds.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;

        }

    }
}
