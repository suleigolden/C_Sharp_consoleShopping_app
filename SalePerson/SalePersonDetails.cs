using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalePerson
{
    public class SalePersonDetails
    {
        public SalePersonDetails()
        {
        }
        String Name = "NAME : Golden Car Inc";

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
        String DaysOfOperation = "DAYS OF SERVICE : Monday to Friday";

        public String DaysOfOperation1
        {
            get { return DaysOfOperation; }
            set { DaysOfOperation = value; }
        }
        String TimeOfOperation = "TIME OF SERVICE : 9 :00am, to 6 :00pm";

        public String TimeOfOperation1
        {
            get { return TimeOfOperation; }
            set { TimeOfOperation = value; }
        }
    }
}
