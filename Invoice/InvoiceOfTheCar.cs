using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Invoice
{
    public class InvoiceOfTheCar
    {
        public InvoiceOfTheCar()
        {
        }
        String Name = " GOLDEN CAR INC";

        public String Name1
        {
            get { return Name; }
            set { Name = value; }
        }
        String Address = "ADDRESS : No 1 kaduna Road D-line Portharcourt";

        public String Address1
        {
            get { return Address; }
            set { Address = value; }
        }
        String PhonNumber = "PHONE NUBER : +2348032316026 OR +2348098316026";

        public String PhonNumber1
        {
            get { return PhonNumber; }
            set { PhonNumber = value; }
        }
        String Email = "EMAIL : goldencarinc@gmail.com";

        public String Email1
        {
            get { return Email; }
            set { Email = value; }
        }
        String InvoiceNumber = "SG000098";

        public String InvoiceNumber1
        {
            get { return InvoiceNumber; }
            set { InvoiceNumber = value; }
        }
        //DateTime Date = new DateTime();
       
    }
}
