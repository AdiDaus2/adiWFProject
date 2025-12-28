using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adiWFProject
{
   
    class Person
    {
        private int personId;
        private string personLastName;
        private string personFirstName;
        private string personAddress;
        private string personPhoneNum;
        private string personCity;
        private string personEmail;

        public Person()
        {

        }

        public Person(int personId, string personLastName, string personFirstName, string personAddress, string personPhoneNum, string personCity, string personEmail)
        {
            this.PersonId = personId;
            this.PersonLastName = personLastName;
            this.PersonFirstName = personFirstName;
            this.PersonAddress = personAddress;
            this.PersonPhoneNum = personPhoneNum;
            this.PersonCity = personCity;
            this.PersonEmail = personEmail;
        }

        public int PersonId { get => personId; set => personId = value; }
        public string PersonLastName { get => personLastName; set => personLastName = value; }
        public string PersonFirstName { get => personFirstName; set => personFirstName = value; }
        public string PersonAddress { get => personAddress; set => personAddress = value; }
        public string PersonPhoneNum { get => personPhoneNum; set => personPhoneNum = value; }
        public string PersonCity { get => personCity; set => personCity = value; }
        public string PersonEmail { get => personEmail; set => personEmail = value; }
    }
}
