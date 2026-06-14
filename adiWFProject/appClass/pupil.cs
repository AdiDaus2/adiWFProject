using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace adiWFProject
{
    public class pupil : DbInterface
    {
        private string pupilID;
        private string pupilName;
        private string tribeName;
        private DateTime birthDate;
        private string address;
        private string parentPhone;
        private string schoolName;
        private string cityName;
        private string staffID;

        public pupil() { }

        #region Properties
        public string PupilID { get { return pupilID; } set { pupilID = value; } }
        public string PupilFullName { get { return pupilName; } set { pupilName = value; } }
        public string SelfTribeName { get { return tribeName; } set { tribeName = value; } }
        public DateTime BirthDate { get { return birthDate; } set { birthDate = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string ParentPhoneNumber { get { return parentPhone; } set { parentPhone = value; } }
        public string SchoolName { get { return schoolName; } set { schoolName = value; } }
        public string CityName { get { return cityName; } set { cityName = value; } }
        public string StaffID { get { return staffID; } set { staffID = value; } }
        #endregion

        public void Insert()
        {
            string SqlStr = string.Format("INSERT INTO pupil (pupilID, pupilName, tribeName, birthDate, address, parentPhone, schoolName, cityName, staffID) " +
                                           "VALUES ('{0}', '{1}', '{2}', #{3}#, '{4}', '{5}', '{6}', '{7}', '{8}')",
                                           pupilID, pupilName, tribeName, birthDate.ToString("yyyy/MM/dd"), address, parentPhone, schoolName, cityName, staffID);
            DbMain.InsDelUpd(SqlStr);
        }

        public bool Delete(string IdKey)
        {
            string SqlStr = string.Format("DELETE FROM pupil WHERE pupilID='{0}'", IdKey);
            return DbMain.InsDelUpd(SqlStr);
        }

        public void Delete(int IdKey)
        {
            Delete(IdKey.ToString());
        }

        public void Update()
        {
            string SqlStr = string.Format("UPDATE pupil SET pupilName='{1}', tribeName='{2}', birthDate=#{3}#, address='{4}', parentPhone='{5}', schoolName='{6}', cityName='{7}', staffID='{8}' WHERE pupilID='{0}'",
                pupilID, pupilName, tribeName, birthDate.ToString("yyyy/MM/dd"), address, parentPhone, schoolName, cityName, staffID);

            DbMain.InsDelUpd(SqlStr);
        }

        public DataSet GetInfoByIdKey(string IdKey)
        {
            string SqlStr = string.Format("SELECT * FROM pupil WHERE pupilID='{0}'", IdKey);
            return DbMain.ReturnDS(SqlStr);
        }

        public bool Found(string Id)
        {
            string str = string.Format("SELECT * FROM pupil WHERE pupilID='{0}'", Id);
            DataSet ds = DbMain.ReturnDS(str);
            return (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0);
        }
    }
}