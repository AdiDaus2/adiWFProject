using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Customers
    {
        private int customerId;
        private string customerName;
        private string customerAddress;
        private int customerPhoneNum;
        private string customerCity;
        private string customerEmail;
        private int customerBDMonth;


        public Customers ()
        {
        }


        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string CustomerAddress
        {
            get { return customerAddress; }
            set { customerAddress = value; }
        }

        public int CustomerPhoneNum
        {
            get { return customerPhoneNum; }
            set { customerPhoneNum = value; }
        }

        public string CustomerCity
        {
            get { return customerCity; }
            set { customerCity = value; }
        }


        public string CustomerEmail
        {
            get { return customerEmail; }
            set { customerEmail = value; }
        }

        public int CustomerBDMonth
        {
            get { return customerBDMonth; }
            set { customerBDMonth = value; }
        }
    }
}
