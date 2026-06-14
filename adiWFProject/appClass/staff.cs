using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace adiWFProject
{
    public class staff : pupil, DbInterface
    {
        private string staffFullName;
        private string selfTribeName;
        private string phoneNumber;

        public staff() : base()
        { }

        public string StaffFullName
        {
            get { return staffFullName; }
            set { staffFullName = value; }
        }

        public new string SelfTribeName
        {
            get { return selfTribeName; }
            set { selfTribeName = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public new void Insert()
        {
            string SqlStr = string.Format(
                "INSERT INTO staff (staffID, staffFullName, selfTribeName, birthDate, address, phoneNumber, cityName, schoolName) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                this.PupilID, this.StaffFullName, this.SelfTribeName, this.BirthDate.ToString("yyyy-MM-dd"),
                this.Address, this.PhoneNumber, this.CityName, this.SchoolName);

            DbMain.InsDelUpd(SqlStr);
        }

        public new void Delete(int IdKey)
        {
            string SqlStr = string.Format("DELETE FROM staff WHERE staffID='{0}'", IdKey);
            DbMain.InsDelUpd(SqlStr);
        }

        public new void Update()
        {
            string SqlStr = string.Format(
                "UPDATE staff SET staffFullName='{1}', selfTribeName='{2}', birthDate='{3}', address='{4}', " +
                "phoneNumber='{5}', cityName='{6}', schoolName='{7}' WHERE staffID='{0}'",
                this.PupilID, this.StaffFullName, this.SelfTribeName, this.BirthDate.ToString("yyyy-MM-dd"),
                this.Address, this.PhoneNumber, this.CityName, this.SchoolName);

            DbMain.InsDelUpd(SqlStr);
        }

        public DataSet GetInfoByIdKey(int IdKey)
        {
            string SqlStr = string.Format("SELECT * FROM staff WHERE staffID='{0}'", IdKey);
            return DbMain.ReturnDS(SqlStr);
        }

        public bool Found(int Id)
        {
            string str = string.Format("SELECT * FROM staff WHERE staffID='{0}'", Id);
            DataSet ds = DbMain.ReturnDS(str);
            return ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0;
        }
    }
}