using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Customer
{
    public class CustomerDetails
    {
        public CustomerDetails()
        {
        }
        String BankName = "";

        public String BankName1
        {
            get { return BankName; }
            set { BankName = value; }
        }
        String CreditCardNum = "";

        public String CreditCardNum1
        {
            get { return CreditCardNum; }
            set { CreditCardNum = value; }
        }
        String Name;

        public String Name1
        {
            get { return Name; }
            set { Name = value; }
        }
        String Address;

        public String Address1
        {
            get { return Address; }
            set { Address = value; }
        }
        long PhonNumber;

        public long PhonNumber1
        {
            get { return PhonNumber; }
            set { PhonNumber = value; }
        }
        String Date = "";

        public String Date1
        {
            get { return Date; }
            set { Date = value; }
        }

    }
}
