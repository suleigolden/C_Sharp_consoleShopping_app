using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using Order;
using SalePerson;
using GCar;
using Customer;
using Invoice;
using Product;

namespace GoldenCarInc
{
    class Program
    {
       public  static void Main()
        {
            Program Home = new Program();
            Home.Home();
        }
       #region HOME
       public void Home()
        {
           cs:
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                GOLDEN CAR INC");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                               =================\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("            [HOME]    [SEARCH]     [HOW TO BUY]  [CONTACT US]   [EXIT]");
            Console.WriteLine("               1          2             3              4          5\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("       ''''''''''          .''''''''           '          ''''''''''");
            Console.WriteLine("     ''          '       .'                   '  '        '          '");
            Console.WriteLine("    |                   '                    '    '       '           ' ");
            Console.WriteLine("    |                   '                   '      '      '            '");
            Console.WriteLine("    |                   '                  '        '     '           '");
            Console.WriteLine("    |                   '                 ''''''''''''    '''''''''''");
            Console.WriteLine("    |        '''''''    '                '            '   '  ' ");
            Console.WriteLine("    |              '     '              '              '  '    .  ");
            Console.WriteLine("     '.           '      '             '                ' '      . ");
            Console.WriteLine("        '''''''''    0     '''''''''''                   ''         .   \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Respond With either 1, 2, 3, 4, or 5 and PRESS ENTER");
            int Userdecision = int.Parse(Console.ReadLine());
            switch (Userdecision)
            {
                case 1:
                    Program.Main();
                    break;
                case 2:
                    Search();
                    break;
                case 3:
                    HowToBuy();
                    break;
                case 4:
                    ContactUs();
                    break;
                case 5:
                    Console.WriteLine(">>>>>>>>>>>>Have A great Day!<<<<<<<<<<<<<<<<");
                    break;
                default:
                    Console.WriteLine("Your Choice  is invalid please press P");
                    goto cs;
            }


        }
#endregion
        #region SEARCH
        public void Search()
        {
            bb:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                VEHICLE SEARCH");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                               =================");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("            [HOME]    [SEARCH]     [BUY CAR]  [BOOKING]    [EXIT]");
            Console.WriteLine("               1          2             3          4         5\n");
            Console.ForegroundColor = ConsoleColor.White;
            OrderCar order = new OrderCar();
            Console.WriteLine("                                 OUR PRODUCT");
            Console.WriteLine("                                =============\n");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("VEHICLES");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("       YEAR   MAKE  MODEL    <> YEAR   MAKE  MODEL     <> YEAR   MAKE     MODEL            \n");
            Console.WriteLine("       {0}   {1}   {2}       <> {3}   {4}   {5} <> {6}   {7}   {8}          ", order.Year11, order.Make11, order.ModelMmw11, order.Year11, order.Make112, order.ModelHonda11, order.Year41, order.Make31, order.ModelToyota11);
            Console.WriteLine("       {0}   {1}   {2}       <> {3}   {4}   {5}  <> {6}   {7}   {8}          ", order.Year41, order.Make11, order.ModelMmw21, order.Year41, order.Make112, order.ModelHonda21, order.Year51, order.Make31, order.ModelToyota21);
            Console.WriteLine("       {0}   {1}   {2}  <> {3}   {4}   {5}     <> {6}   {7}   {8}          ", order.Year31, order.Make11, order.ModelMmw31, order.Year31, order.Make112, order.ModelHonda31, order.Year31, order.Make31, order.ModelToyota31);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("TRUCKS");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("       {0}   {1}   {2}",order.Truck11,order.Truck21,order.Truck31);
            Console.WriteLine("        ");
            Console.WriteLine("       {0}   {1}       {2}",order.Truck41,order.Truck51,order.Truck61);
            Console.WriteLine("        ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Note: TRUCTS ARE UNAVAILABLE AT THE MOMENT!!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("        ");
            Console.WriteLine("      -------------------------------------\n");
            Console.WriteLine("       ACTION TYPE    |        LOCATION\n");
            Console.WriteLine("       {0}     |        {1} ",order.ActionType1,order.Location1);
            Console.WriteLine("       {0}     |        {1} ", order.ActionType2, order.Location2);
            Console.WriteLine("                               {0} ", order.Location3);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Respond With either 1, 2, 3, 4, or 5 and PRESS ENTER");
            int UserChoice = int.Parse(Console.ReadLine());
            switch (UserChoice)
            {
                case 1:
                    Program.Main();
                    break;
                case 2:
                    Console.Write("Enter The Make Of Your Car : ");
                    order.Make11 = Console.ReadLine();
                    Console.Write("Enter The Model Of Your Car : ");
                    order.ModelHonda11 = Console.ReadLine();
                    Console.Write("Enter The Year Of Your Car : ");
                    order.Year11 =int.Parse( Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    char[] anims = new char[] { 'L', 'O', 'A','D','I','N','G' };
                    int animsIndex = 0;
                    for (int n = 0; n < 39; n++)
                    {
                        Console.Write(                          anims[animsIndex]);
                        Thread.Sleep(100);
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        animsIndex++;
                        if (animsIndex >= anims.Length)
                            animsIndex = 0;
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("           ┌───────────────────────────────────────────────────────╖");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("            Make : {0} ****** Model: {1} ****** Year: {2}        ",order.Make11,order.ModelHonda11,order.Year11);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("           ╘═══════════════════════════════════════════════════════╝");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("The Car That Has The Following Details Has Been Found And Is Available in");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("            {0}>>>>>>>>>>>{1}>>>>AND>>>>>>{2}", order.Location3,order.Location2,order.Location1);
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
            Pl:
                    Console.WriteLine("PRESS BUY TO BUY THE CAR\n");
                    Console.WriteLine("PRESS B TO GO BACK AND SEARCH FOR ANOTHER CAR\n");
                    Console.WriteLine("PRESS BOOK TO BOOK THE CAR");
                    string by = Console.ReadLine().ToUpper();
                    switch (by)
                    {
                        case "BUY":
                            BuyCar();
                            break;
                        case "B":
                            goto bb;
                        case "BOOK":
                            Booking();
                            break;
                        default:
                            Console.WriteLine("Your Choice {0} is invalid please press BUY or B or BOOK and press enter");
                            goto Pl;
                    }
                    break;
                case 3:
                    BuyCar();
                    break;
                case 4:
                    Booking();
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(">>>>>>>>>>>>Have A great Day!<<<<<<<<<<<<<<<<");
                    break;
                default:
                    Console.WriteLine("Your Choice {0}, is invalid please press  1, 2, 3, 4 or 5", UserChoice);
                    goto bb;
            }

        }
        #endregion
        #region HOW TO BUY
        public void HowToBuy()
        {
            yy:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                    FIND YOUR CAR WE WELL DO THE REST");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                  =====================================\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                    [HOME]    [SEARCH]    [EXIT] ");
            Console.WriteLine("                       1          2         3 \n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[CLIENT]---->[BUY A CAR]---->[PAY FOR PURCHASE]--->[RECEIVE CAR AT THE DESTINATION PORT]\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" 1...Go To Search\n ");
            Console.WriteLine(" 2...Search For The Car That You Want\n");
            Console.WriteLine(" 3...Select Action Type Of Your Choice\n");
            Console.WriteLine(" 4...Complete The Transaction\n");
            Console.WriteLine("NOTE...");
            Console.WriteLine("If you decide to buy the car now, we will only give you the invoice.");
            Console.WriteLine("While the Docments will be handle to you at the Receive destination point\n");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Respond With either 1, 2,or 3 and PRESS ENTER");
            int Userchoice = int.Parse(Console.ReadLine());
            switch (Userchoice)
            {
                case 1:
                    Program.Main();
                    break;
                case 2:
                    Search();
                    break;
                case 3:
                    Console.WriteLine(">>>>>>>>>>>>Have A great Day!<<<<<<<<<<<<<<<<");
                    break;
                default:
                    Console.WriteLine("Your Choice {0}, is invalid please press P", Userchoice);
                    goto yy;
            }
        }
        #endregion

        #region CONTACT US
        public void ContactUs()
        {
            CustomerDetails cus = new CustomerDetails();
            SalePersonDetails sale = new SalePersonDetails();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                 GOLDEN CAR INC.contact");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                ========================");
        bck:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("            [HOME]      [NEWS]   [EXIT]   [MESSAGE US] ");
            Console.WriteLine("               1          2        3          4\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                                                     find us on        ");
            Console.WriteLine("                                                      FACEBOOK     \n ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(sale.Name1);
            Console.WriteLine("");
            Console.WriteLine(sale.Address1);
            Console.WriteLine("");
            Console.WriteLine(sale.PhonNumber1);
            Console.WriteLine("");
            Console.WriteLine(sale.Email1);
            Console.WriteLine("");
            Console.WriteLine(sale.DaysOfOperation1);
            Console.WriteLine("");
            Console.WriteLine(sale.TimeOfOperation1);
            Console.WriteLine("\n");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Respond With either 1, 2, 3, or 4 and PRESS ENTER");
            int userDecision = int.Parse(Console.ReadLine());
            switch (userDecision)
            {
                case 1:
                    Program.Main();
                    break;
                case 2:
            
                    FileStream fs = new FileStream("Myinfoo.text", FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    sr.BaseStream.Seek(0, SeekOrigin.Begin);
                    string srt = sr.ReadLine();
                    while (srt != null)
                    {
                        Console.WriteLine(srt);
                        srt = sr.ReadLine();
                    }
                    sr.Close();
                    fs.Close();
                    Console.WriteLine("Press < B > TO GO BACK");
                    string Back = Console.ReadLine().ToUpper();
                    if (Back == "B")
                    {
                        goto bck;
                    }
                    break;
                case 3:
                    Console.WriteLine(">>>>>>>>>>>>Have A great Day!<<<<<<<<<<<<<<<<");
                    break;
                case 4:
                    //kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk
            www:
                    try
                    {
                        Console.WriteLine("");
                        Console.Write("Enter Your Name : ");
                        cus.Name1= Console.ReadLine();

                        Console.Write("Enter Your Adress : ");
                        cus.Address1= Console.ReadLine();

                        Console.Write("Phone Number : ");
                        cus.PhonNumber1=Convert.ToInt32(Console.ReadLine());

                        if (cus.Name1 == "") { Console.WriteLine("Name And Adress Must not Be Empty!!"); goto www; }
                        else if (cus.Address1 == "") { Console.WriteLine("Name And Adress Must not Be Empty!!"); goto www; }
                        //else if (phn == null) { Console.WriteLine("Phone Number Must not Be Empty!!"); } 
                        else
                        {
                            FileStream fts = new FileStream("Names.text", FileMode.Append, FileAccess.Write);
                            StreamWriter sw = new StreamWriter(fts);
                            Console.WriteLine("");
                            Console.Write("Write Your Messeage :  ");
                            string str = Console.ReadLine();
                            sw.Write(str);
                            sw.Flush();
                            sw.Close();
                            fts.Close();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Yes {0},     Message Sent");
                            Console.ForegroundColor = ConsoleColor.White;
                        bckk:
                            Console.WriteLine("PRESS B TO GO BACK");
                            string mbk = Console.ReadLine().ToUpper();
                            switch (mbk)
                            {
                                case "B":
                                    break;
                                default:
                                    Console.WriteLine("Your Choice {0}, is invalid please press B", mbk);
                                    goto bckk;

                            }

                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Name And Address Must Be Letters not Numbers");
                        goto www;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("The Numbers That You Enterd is Many. it ca only be between {0} & {1}", int.MaxValue, int.MinValue);
                    }
                    //kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk
                    break;
                default:
                    Console.WriteLine("Your Choice {0}, is invalid please respond with 1, 2, 3 or 4",userDecision);
                    goto bck;
            }

        }
        #endregion
        #region BUY CAR
        public void BuyCar()
        {
           
            Car car = new Car();
            OrderCar order = new OrderCar();
            CustomerDetails customer = new CustomerDetails();
            InvoiceOfTheCar invoice = new InvoiceOfTheCar();
            DateTime Date = new DateTime();
            Console.WriteLine("     ");
            Console.WriteLine("");

            Console.WriteLine("Car Available  :  {0}  {1}  {2}",car.GetCar1(),car.GetCa2(),car.GetCarss3());
            Console.WriteLine();
            Console.WriteLine("Model Available:  {0}         {1}       {2}",order.ModelMmw11,order.ModelHonda11,order.ModelToyota11);
            Console.WriteLine("                  {0}         {1}        {2}", order.ModelMmw21, order.ModelHonda21, order.ModelToyota21);
            Console.WriteLine("                  {0}    {1}           {2}", order.ModelMmw31, order.ModelHonda31, order.ModelToyota31);
            //Console.WriteLine();
            //Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Engine Capacity:  {0}  ",car.GetEngCapacityNumber());
            Console.WriteLine();
            Console.WriteLine("Engine Type    :  {0}  ", car.EngType1);
            Console.WriteLine();
            Console.WriteLine("Alloy Wheels   :  {0}  ",car.GetWeelType());
            Console.WriteLine();
            Console.WriteLine("AC Available   :  {0}  ",car.Ac1);
            Console.WriteLine();
            Console.WriteLine("DOORS          :  {0}...{1}", car.GetDor4(),car.GetDor2());
            Console.WriteLine();
            Console.WriteLine("Color Availabe :  {0} ",car.GetColor());

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            tt:
           Console.WriteLine("PRESS    C   TO CUSTOMIZE THE CAR THAT YOU WANT To BUY\n");
           Console.WriteLine("PRESS    A   TO SELECT OREDY MADE CAR");
            string UserDecision = Console.ReadLine().ToUpper();
            switch (UserDecision)
            {
                case "C":
                    Console.Write("Enter The Name Of The Car : ");
                    car.SetCarName(Console.ReadLine());
                    Console.Write("Enter The Model Of The Car : ");
                    order.ModelHonda11 = Console.ReadLine();
                    Console.Write("Enter The Engine Capacity Of The Car : ");
                    car.SetEngCapacityNumber(Console.ReadLine());
                    Console.Write("Enter The Engine Type Of The Car : ");
                    car.EngType1=Console.ReadLine();
                    Console.Write("Enter The weels Color Of The Car : ");
                    car.SetweelType(Console.ReadLine());
                    Console.Write("Enter The AC Capacity Of The Car : ");
                    car.Ac1=Console.ReadLine();
                    Console.Write("Enter The Number Of Door Of The Car : ");
                    car.SetDoors4(Console.ReadLine());
                    Console.Write("Enter The Color Of The Car : ");
                    car.SetColor(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    char[] anims = new char[] { 'L', 'O', 'A', 'D', 'I', 'N', 'G' };
                    int animsIndex = 0;
                    for (int n = 0; n < 39; n++)
                    {
                        Console.Write(anims[animsIndex]);
                        Thread.Sleep(100);
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        animsIndex++;
                        if (animsIndex >= anims.Length)
                            animsIndex = 0;
                    }
                    //Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("");
                    Console.WriteLine("The Car has been Customize as follows........\n");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("The Car NAME is [ {0} ]", car.GetCarName());
                    Console.WriteLine("");
                    Console.WriteLine("And the Car MODEL is [ {0} ]", order.ModelHonda11);
                    Console.WriteLine("");
                    Console.WriteLine("The Car Has [ {0} ] Engine Capacity ", car.GetEngCapacityNumber());
                    Console.WriteLine("");
                    Console.WriteLine("The Car is [ {0} ]  ", car.EngType1);
                    Console.WriteLine("");
                    Console.WriteLine("The Weels Color of The Car is [ {0} ]", car.GetWeels());
                    Console.WriteLine("");
                    Console.WriteLine("The  AC Capacity Of The Car is [ {0} ]", car.Ac1);
                    Console.WriteLine("");
                    Console.WriteLine("And it's also Has [ {0} ]", car.GetDor4());
                    Console.WriteLine("");
                    Console.WriteLine("Wile The Color Of The Car is [ {0} ] ", car.GetColor());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("");
            bc:
                    Console.WriteLine("PREES C TO VIEW THE COST OF THE CAR or <B> To GO BACK\n\n");
                    string cost = Console.ReadLine().ToUpper();
                    switch (cost)
                    {
                        case "C":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            char[] load = new char[] { 'L', 'O', 'A', 'D', 'I', 'N', 'G' };
                            int loadIndex = 0;
                            for (int n = 0; n < 39; n++)
                            {
                                Console.Write(load[loadIndex]);
                                Thread.Sleep(100);
                                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                loadIndex++;
                                if (loadIndex >= load.Length)
                                    loadIndex = 0;
                            }
                            
                            Console.WriteLine("This Car Will Only Cost You = 1,500,0000");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.White;
                    pp:
                            Console.WriteLine("PREES P TO PAY FOR THE CAR or <B> To GO BACK\n\n");
                            string pay = Console.ReadLine().ToUpper();
                            switch (pay)
                            {
                                case "P":
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("WELCOME!...please filled in the following form\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("Enter Your FULL Name : ");
                                    customer.Name1 = Console.ReadLine();
                                    Console.Write("Enter Your Address : ");
                                    customer.Address1 = Console.ReadLine();
                                    Console.Write("Enter Your Phone Number : ");
                                    customer.PhonNumber1 = long.Parse(Console.ReadLine());
                                    Console.Write("Enter Your Bank Name : ");
                                    customer.BankName1 = Console.ReadLine();
                                    Console.Write("Enter Your Credit Card Number : ");
                                    customer.CreditCardNum1 = Console.ReadLine();
                                    Console.Write("Enter Date");
                                    customer.Date1 = Console.ReadLine();
                            amt:
                                    Console.WriteLine("Enter The AMOUNT OF THE CAR");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    long priceoption = 1000000;
                                    Console.WriteLine("NOTE.... Enter 1 miloin only. The rest Of Payment will Be Completed In The Destination Were You are Going To Collect The Car And The Rest of The DUCMENTS!");
                                    car.Price=long.Parse((Console.ReadLine()));
                                    if ( car.Price==priceoption)
                                    {
                                        goto contineu;
                                    }
                                    if (car.Price < priceoption)
                                    {
                                        Console.WriteLine("\n");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("YOUR AMOUNT {0} IS INSUFICIANT. YOU NEED 1000000 TO COMPLET THE TRANSACTION",car.Price);
                                        Console.WriteLine("\n");
                                        goto amt;
                                    }
                                    if (car.Price > priceoption)
                                    {
                                    rhe:
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("\n");
                                        Console.WriteLine("WARNING!!!!..YOU ENTERD EXTRA AMOUNT.");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Press R to Read The instruction befor you type in your AMOUNT\n");
                                        Console.WriteLine("Press H to See How To Buy A Car In Our Campany\n");
                                        Console.WriteLine("OR Press E to Exit");
                                        Console.WriteLine("\n");
                                        string RHE = Console.ReadLine().ToUpper();
                                        switch (RHE)
                                        {
                                            case "R":
                                                goto amt;
                                                
                                            case "H":
                                                Program pr = new Program();
                                                pr.HowToBuy();
                                                break;
                                            case "E":
                                                Console.WriteLine(">>>>>>>>>>>HAVE A GREAT DAY<<<<<<<<<");
                                                break;
                                            default:
                                                Console.WriteLine("Your Choice {0} is invalid please press R, H or E and press Enter");
                                                goto rhe;
                                        }
                                    }
                            contineu:
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("\n");
                                    Console.WriteLine("Thanks {0}, Please Press P Now To PRINT your INVOICE",customer.Name1);
                                    string print = Console.ReadLine().ToUpper();
                                    switch (print)
                                    {
                                        case "P":
                                            Console.WriteLine("");
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine("┌────****───────────────****──────────****──────────****────────****────────╖\n");
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("        ┌────<>──────<>──────<>─────<>─────<>──────<>────<>────╖\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                   {0}                                  ", invoice.Name1);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("              {0}                                  ", invoice.Address1);
                                            Console.WriteLine("              {0}                                  ", invoice.Email1);
                                            Console.WriteLine("              {0}                                  ", invoice.PhonNumber1);
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("        ╘═══<>══════<>══════<>══════<>═════<>══════<>════<>════╝");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("");
                                            Console.WriteLine("   SOLD TO");
                                            Console.WriteLine("   ────────");
                                            Console.WriteLine("       NAME           : {0} ", customer.Name1);
                                            Console.WriteLine("       ADDRESS        : {0}", customer.Address1);
                                            Console.WriteLine("       PHONE NUMBER   : {0}", customer.PhonNumber1);
                                            Console.WriteLine("       BANK NUMBER    : {0}",customer.BankName1);
                                            Console.WriteLine("       CREDIT CARD NO : {0}",customer.CreditCardNum1);
                                            Console.WriteLine("");
                                            Console.WriteLine("                                         INVOICE No : {0} ", invoice.InvoiceNumber1);
                                            Console.WriteLine("                                         DATE       : {0}", customer.Date1);
                                            Console.WriteLine("                                         TIME       : {0}", Date.ToString("T"));
                                            Console.WriteLine("");
                                            Console.WriteLine("       MAKE        : {0}", car.GetCarName());
                                            Console.WriteLine("       MODEL       : {0}", order.ModelHonda11);
                                            Console.WriteLine("       ENGINE TYPE : {0}", car.EngType1);
                                            Console.WriteLine("       COLOR       : {0}", car.GetColor());
                                            Console.WriteLine("");
                                            Console.WriteLine("                                         CAR ID : {0}",car.GetNumber());
                                            Console.WriteLine("                                         AMOUNT PAID : {0}",car.GetCost());
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine("");
                                            Console.WriteLine("╘════****══════════════****═══════════****══════════****═════════****═══════╝");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("{0}!, Make Sure You Come Along With This Invoice Wen Coming To Our Office..THANKS",customer.Name1);
                                            Console.WriteLine("");
                                            Console.WriteLine("_________________________________________\n");
                                            Console.WriteLine("            {0}",customer.BankName1);
                                            Console.WriteLine("|          *************************      |");
                                            Console.WriteLine("|                                         |");
                                            Console.WriteLine("| WITHDRAWAL Alart!                       |");
                                            Console.WriteLine("|                                         |");
                                            Console.WriteLine("| ACC No : {0}",customer.CreditCardNum1);
                                            Console.WriteLine("| Amount : {0}",car.Price);
                                            Console.WriteLine("| Balance: 87,000000                      |");
                                            Console.WriteLine("| Date   : {0}",customer.Date1);
                                            Console.WriteLine("| TIME   : {0}", Date.ToString("T"));
                                            Console.WriteLine("|");
                                            Console.WriteLine("|_________________________________________|");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("PRESS M TO GO BACK TO THE MAIN MENU or E TO EXIT");
                                            string exit = Console.ReadLine().ToUpper();
                                            switch (exit)
                                            {
                                                case "M":
                                                    Program.Main();
                                                    break;
                                                case "E":
                                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                                    Console.WriteLine(">>>>>>>>>>HAVE A GREAT DAY!<<<<<<<<<<<<<");
                                                    break;
                                            }
                                            break;
                                    }
                                    break;
                                case "B":
                                    BuyCar();
                                    break;
                                default:
                                    Console.WriteLine("Your Choice {0}, is invalid please press P", pay);
                                    goto pp;
                            }
                           
                            break;
                        case "B":
                            BuyCar();
                            break;
                        default:
                            Console.WriteLine("Your Choice {0}, is invalid please press P",cost);
                            goto bc;
                    }
                    break;
                case "A":
            ck:
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("                       GOLDEN CAR INC");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("                     <><><><><><><><><><>\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(  "              {0}  {1}  {2}",car.GetCar1(),car.GetCa2(),car.GetCarss3());
                    Console.WriteLine("                1           2            3\n\n");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("       __________              __________               __________");
                    Console.WriteLine("   _---            ---    _---            ---      _---            ---  ");
                    Console.WriteLine("   --()---------()----    --()---------()----      --()---------()----");
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("SELECT YOUR CAR CHOICE\n");
                    int Ck = int.Parse(Console.ReadLine());
                    switch (Ck)
                    {
                        case 1:
                            Console.WriteLine("Make  : {0}",order.Make11);
                            Console.WriteLine("MODEL  : {0}",order.ModelHonda11);
                            Console.WriteLine("ENGINE TYPE : AUTOMATIC");
                            Console.WriteLine("DOORS : FOUR DOORS");
                            Console.WriteLine("WEELS : Golden");
                            Console.WriteLine("ENGINE CAPACITY : 0.98887 ");
                            Console.WriteLine("CAR ID : {0}",car.GetNumber());
                            Console.WriteLine("COLOR : BLACK");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("       __________");
                            Console.WriteLine("   _---            ---");
                            Console.WriteLine("   --()---------()----");
                            Console.WriteLine("\n");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.White;
                    cs:
                            Console.WriteLine("PREES C TO VIEW THE COST OF THE CAR or <B> To GO BACK\n\n");
                            string costt = Console.ReadLine().ToUpper();
                            switch (costt)
                            {
                                case "C":
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    char[] load = new char[] { 'L', 'O', 'A', 'D', 'I', 'N', 'G' };
                                    int loadIndex = 0;
                                    for (int n = 0; n < 39; n++)
                                    {
                                        Console.Write(load[loadIndex]);
                                        Thread.Sleep(100);
                                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                        loadIndex++;
                                        if (loadIndex >= load.Length)
                                            loadIndex = 0;
                                    }

                                    Console.WriteLine("This Car Will Only Cost You = 1,500,0000");
                                    Console.WriteLine("");
                                    Console.ForegroundColor = ConsoleColor.White;
                            cy:
                                    Console.WriteLine("PREES P TO PAY FOR THE CAR or <B> To GO BACK\n\n");
                                    string pay = Console.ReadLine().ToUpper();
                                    switch (pay)
                                    {
                                        case "P":
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine("WELCOME!...please filled in the following form\n");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("Enter Your FULL Name");
                                            customer.Name1 = Console.ReadLine();
                                            Console.WriteLine("Enter Your Address");
                                            customer.Address1 = Console.ReadLine();
                                            Console.WriteLine("Enter Your Phone Number");
                                            customer.PhonNumber1 = long.Parse(Console.ReadLine());
                                            Console.Write("Enter Your Bank Name : ");
                                            customer.BankName1 = Console.ReadLine();
                                            Console.Write("Enter Your Credit Card Number : ");
                                             customer.CreditCardNum1 = Console.ReadLine();
                                             Console.Write("Enter Date");
                                             customer.Date1 = Console.ReadLine();
                                        amt:
                                            Console.WriteLine("Enter The AMOUNT OF THE CAR");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        long priceoption = 1000000;
                                        Console.WriteLine("NOTE.... Enter 1 miloin only. The rest Of Payment will Be Completed In The Destination Were You are Going To Collect The Car And The Rest of The DUCMENTS!");
                                        car.Price = long.Parse((Console.ReadLine()));
                                        if (car.Price == priceoption)
                                        {
                                            goto contineu;
                                        }
                                        if (car.Price < priceoption)
                                        {
                                            Console.WriteLine("\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("YOUR AMOUNT {0} IS INSUFICIANT. YOU NEED 1000000 TO COMPLET THE TRANSACTION", car.Price);
                                            Console.WriteLine("\n");
                                            goto amt;
                                        }
                                        if (car.Price > priceoption)
                                        {
                                        rhe:
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("\n");
                                            Console.WriteLine("WARNING!!!!..YOU ENTERD EXTRA AMOUNT.");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("Press R to Read The instruction befor you type in your AMOUNT\n");
                                            Console.WriteLine("Press H to See How To Buy A Car In Our Campany\n");
                                            Console.WriteLine("OR Press E to Exit");
                                            Console.WriteLine("\n");
                                            string RHE = Console.ReadLine().ToUpper();
                                            switch (RHE)
                                            {
                                                case "R":
                                                    goto amt;

                                                case "H":
                                                    Program pr = new Program();
                                                    pr.HowToBuy();
                                                    break;
                                                case "E":
                                                    Console.WriteLine(">>>>>>>>>>>HAVE A GREAT DAY<<<<<<<<<");
                                                    break;
                                                default:
                                                    Console.WriteLine("Your Choice {0} is invalid please press R, H or E and press Enter");
                                                    goto rhe;
                                            }
                                        }
                                    contineu:
                                            Console.WriteLine("\n");
                                            Console.WriteLine("Thanks {0}, Please Press P Now To PRINT your INVOICE", customer.Name1);
                                            string print = Console.ReadLine().ToUpper();
                                            switch (print)
                                            {
                                                case "P":
                                                    Console.WriteLine("");
                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                    Console.WriteLine("┌────****───────────────****──────────****──────────****────────****────────╖\n");
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("        ┌────<>──────<>──────<>─────<>─────<>──────<>────<>────╖\n");
                                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                                    Console.WriteLine("                   {0}                                  ", invoice.Name1);
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("              {0}                                  ", invoice.Address1);
                                                    Console.WriteLine("              {0}                                  ", invoice.Email1);
                                                    Console.WriteLine("              {0}                                  ", invoice.PhonNumber1);
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("        ╘═══<>══════<>══════<>══════<>═════<>══════<>════<>════╝");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("");
                                                    Console.WriteLine("   SOLD TO");
                                                    Console.WriteLine("   ────────");
                                                    Console.WriteLine("       NAME         : {0} ", customer.Name1);
                                                    Console.WriteLine("       ADDRESS      : {0}", customer.Address1);
                                                    Console.WriteLine("       PHONE NUMBER : {0}", customer.PhonNumber1);
                                                    Console.WriteLine("");
                                                    Console.WriteLine("                                         INVOICE No : {0} ", invoice.InvoiceNumber1);
                                                    Console.WriteLine("                                         DATE       : {0}", Date.ToString("D"));
                                                    Console.WriteLine("                                         TIME       : {0}", Date.ToString("T"));
                                                    Console.WriteLine("");
                                                    Console.WriteLine("       MAKE        : {0}", order.Make11);
                                                    Console.WriteLine("       MODEL       : {0}", order.ModelMmw11);
                                                    Console.WriteLine("       ENGINE TYPE : AUTOMATIC");
                                                    Console.WriteLine("       COLOR       : BLACK");
                                                    Console.WriteLine("");
                                                    Console.WriteLine("                                         CAR ID : {0}", car.GetNumber());
                                                    Console.WriteLine("                                         AMOUNT PAID : {0}", car.GetCost());
                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                    Console.WriteLine("");
                                                    Console.WriteLine("╘════****══════════════****═══════════****══════════****═════════****═══════╝");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("");
                                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                                    Console.WriteLine("{0}!, Make Sure You Come Along With This Invoice Wen Coming To Our Office..THANKS", customer.Name1);
                                                    Console.WriteLine("");
                                                    Console.WriteLine("_________________________________________\n");
                                                    Console.WriteLine("            {0}", customer.BankName1);
                                                    Console.WriteLine("|          *************************      |");
                                                    Console.WriteLine("|                                         |");
                                                    Console.WriteLine("| WITHDRAWAL Alart!                       |");
                                                    Console.WriteLine("|                                         |");
                                                    Console.WriteLine("| ACC No : {0}", customer.CreditCardNum1);
                                                    Console.WriteLine("| Amount : {0}", car.Price);
                                                    Console.WriteLine("| Balance: 87,000000                      |");
                                                    Console.WriteLine("| Date   : {0}", customer.Date1);
                                                    Console.WriteLine("| TIME   : {0}", Date.ToString("T"));
                                                    Console.WriteLine("|");
                                                    Console.WriteLine("|_________________________________________|");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                            mm:
                                                    Console.WriteLine("PRESS M TO GO BACK TO THE MAIN MENU or E TO EXIT");
                                                    string exit = Console.ReadLine().ToUpper();
                                                    switch (exit)
                                                    {
                                                        case "M":
                                                            Program.Main();
                                                            break;
                                                        case "E":
                                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                                            Console.WriteLine(">>>>>>>>>>HAVE A GREAT DAY!<<<<<<<<<<<<<");
                                                            break;
                                                        default:
                                                            Console.WriteLine("Your Choice {0}, is invalid please press P", exit);
                                                            goto mm;
                                                    }
                                                    break;
                                            }
                                            break;
                                        case "B":
                                            BuyCar();
                                            break;
                                        default:
                                            Console.WriteLine("Your Choice {0}, is invalid please press P or B", pay);
                                            goto cy;
                                    }

                                    break;
                                case "B":
                                    BuyCar();
                                    break;
                                default:
                                    Console.WriteLine("Your Choice {0}, is invalid please press P", costt);
                                    goto cs;

                            }
                            break;
                        case 2:
                            Console.WriteLine("Make  : {0}", order.Make11);
                            Console.WriteLine("MODEL  : {0}", order.ModelHonda11);
                            Console.WriteLine("ENGINE TYPE : AUTOMATIC");
                            Console.WriteLine("DOORS : FOUR DOORS");
                            Console.WriteLine("WEELS : Golden");
                            Console.WriteLine("ENGINE CAPACITY : 0.98887 ");
                            Console.WriteLine("CAR ID : {0}", car.GetNumber());
                            Console.WriteLine("COLOR : BLACK");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("       __________");
                            Console.WriteLine("   _---            ---");
                            Console.WriteLine("   --()---------()----");
                            Console.WriteLine("\n");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.White;
                    ces:
                            Console.WriteLine("PREES C TO VIEW THE COST OF THE CAR or <B> To GO BACK\n\n");
                            string cos = Console.ReadLine().ToUpper();
                            switch (cos)
                            {
                                case "C":
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    char[] load = new char[] { 'L', 'O', 'A', 'D', 'I', 'N', 'G' };
                                    int loadIndex = 0;
                                    for (int n = 0; n < 39; n++)
                                    {
                                        Console.Write(load[loadIndex]);
                                        Thread.Sleep(100);
                                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                        loadIndex++;
                                        if (loadIndex >= load.Length)
                                            loadIndex = 0;
                                    }

                                    Console.WriteLine("This Car Will Only Cost You = 1,500,0000");
                                    Console.WriteLine("");
                                    Console.ForegroundColor = ConsoleColor.White;
                            ppl:
                                    Console.WriteLine("PREES P TO PAY FOR THE CAR or <B> To GO BACK\n\n");
                                    string pay = Console.ReadLine().ToUpper();
                                    switch (pay)
                                    {
                                        case "P":
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine("WELCOME!...please filled in the following form\n");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("Enter Your FULL Name");
                                            customer.Name1 = Console.ReadLine();
                                            Console.WriteLine("Enter Your Address");
                                            customer.Address1 = Console.ReadLine();
                                            Console.WriteLine("Enter Your Phone Number");
                                            customer.PhonNumber1 = long.Parse(Console.ReadLine());
                                            Console.Write("Enter Your Bank Name : ");
                                            customer.BankName1 = Console.ReadLine();
                                            Console.Write("Enter Your Credit Card Number : ");
                                            customer.CreditCardNum1 = Console.ReadLine();
                                            Console.Write("Enter Date");
                                            customer.Date1 = Console.ReadLine();
                                        amt:
                                            Console.WriteLine("Enter The AMOUNT OF THE CAR");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        long priceoption = 1000000;
                                        Console.WriteLine("NOTE.... Enter 1 miloin only. The rest Of Payment will Be Completed In The Destination Were You are Going To Collect The Car And The Rest of The DUCMENTS!");
                                        car.Price = long.Parse((Console.ReadLine()));
                                        if (car.Price == priceoption)
                                        {
                                            goto contineu;
                                        }
                                        if (car.Price < priceoption)
                                        {
                                            Console.WriteLine("\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("YOUR AMOUNT {0} IS INSUFICIANT. YOU NEED 1000000 TO COMPLET THE TRANSACTION", car.Price);
                                            Console.WriteLine("\n");
                                            goto amt;
                                        }
                                        if (car.Price > priceoption)
                                        {
                                        rhe:
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("\n");
                                            Console.WriteLine("WARNING!!!!..YOU ENTERD EXTRA AMOUNT.");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("Press R to Read The instruction befor you type in your AMOUNT\n");
                                            Console.WriteLine("Press H to See How To Buy A Car In Our Campany\n");
                                            Console.WriteLine("OR Press E to Exit");
                                            Console.WriteLine("\n");
                                            string RHE = Console.ReadLine().ToUpper();
                                            switch (RHE)
                                            {
                                                case "R":
                                                    goto amt;

                                                case "H":
                                                    Program pr = new Program();
                                                    pr.HowToBuy();
                                                    break;
                                                case "E":
                                                    Console.WriteLine(">>>>>>>>>>>HAVE A GREAT DAY<<<<<<<<<");
                                                    break;
                                                default:
                                                    Console.WriteLine("Your Choice {0} is invalid please press R, H or E and press Enter");
                                                    goto rhe;
                                            }
                                        }
                                    contineu:
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("\n");
                                    prt:
                                            Console.WriteLine("Thanks {0}, Please Press P Now To PRINT your INVOICE", customer.Name1);
                                            string print = Console.ReadLine().ToUpper();
                                            switch (print)
                                            {
                                                case "P":
                                                    Console.WriteLine("");
                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                    Console.WriteLine("┌────****───────────────****──────────****──────────****────────****────────╖\n");
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("        ┌────<>──────<>──────<>─────<>─────<>──────<>────<>────╖\n");
                                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                                    Console.WriteLine("                   {0}                                  ", invoice.Name1);
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("              {0}                                  ", invoice.Address1);
                                                    Console.WriteLine("              {0}                                  ", invoice.Email1);
                                                    Console.WriteLine("              {0}                                  ", invoice.PhonNumber1);
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("        ╘═══<>══════<>══════<>══════<>═════<>══════<>════<>════╝");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("");
                                                    Console.WriteLine("   SOLD TO");
                                                    Console.WriteLine("   ────────");
                                                    Console.WriteLine("       NAME         : {0} ", customer.Name1);
                                                    Console.WriteLine("       ADDRESS      : {0}", customer.Address1);
                                                    Console.WriteLine("       PHONE NUMBER : {0}", customer.PhonNumber1);
                                                    Console.WriteLine("");
                                                    Console.WriteLine("                                         INVOICE No : {0} ", invoice.InvoiceNumber1);
                                                    Console.WriteLine("                                         DATE       : {0}", Date.ToString("D"));
                                                    Console.WriteLine("                                         TIME       : {0}", Date.ToString("T"));
                                                    Console.WriteLine("");
                                                    Console.WriteLine("       MAKE        : {0}", order.Make11);
                                                    Console.WriteLine("       MODEL       : {0}", order.ModelHonda11);
                                                    Console.WriteLine("       ENGINE TYPE : AUTOMATIC");
                                                    Console.WriteLine("       COLOR       : BALCK");
                                                    Console.WriteLine("");
                                                    Console.WriteLine("                                         CAR ID : {0}", car.GetNumber());
                                                    Console.WriteLine("                                         AMOUNT PAID : {0}", car.GetCost());
                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                    Console.WriteLine("");
                                                    Console.WriteLine("╘════****══════════════****═══════════****══════════****═════════****═══════╝");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("");
                                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                                    Console.WriteLine("{0}!, Make Sure You Come Along With This Invoice Wen Coming To Our Office..THANKS", customer.Name1);
                                                    Console.WriteLine("");
                                                    Console.WriteLine("_________________________________________\n");
                                                    Console.WriteLine("            {0}", customer.BankName1);
                                                    Console.WriteLine("|          *************************      |");
                                                    Console.WriteLine("|                                         |");
                                                    Console.WriteLine("| WITHDRAWAL Alart!                       |");
                                                    Console.WriteLine("|                                         |");
                                                    Console.WriteLine("| ACC No : {0}", customer.CreditCardNum1);
                                                    Console.WriteLine("| Amount : {0}", car.Price);
                                                    Console.WriteLine("| Balance: 87,000000                      |");
                                                    Console.WriteLine("| Date   : {0}", customer.Date1);
                                                    Console.WriteLine("| TIME   : {0}", Date.ToString("T"));
                                                    Console.WriteLine("|");
                                                    Console.WriteLine("|_________________________________________|");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                            bbk:
                                                    Console.WriteLine("PRESS M TO GO BACK TO THE MAIN MENU or E TO EXIT");
                                                    string exit = Console.ReadLine().ToUpper();
                                                    switch (exit)
                                                    {
                                                        case "M":
                                                            Program.Main();
                                                            break;
                                                        case "E":
                                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                                            Console.WriteLine(">>>>>>>>>>HAVE A GREAT DAY!<<<<<<<<<<<<<");
                                                            break;
                                                        default:
                                                            Console.WriteLine("Your Choice {0}, is invalid please press M or E", exit);
                                                            goto bbk;
                                                    }
                                                    break;
                                                default:
                                                    Console.WriteLine("Your Choice {0}, is invalid please press P", print);
                                                    goto prt;
                                            }
                                            break;
                                        case "B":
                                            BuyCar();
                                            break;
                                        default:
                                            Console.WriteLine("Your Choice {0}, is invalid please press P", pay);
                                            goto ppl;
                                    }

                                    break;
                                case "B":
                                    BuyCar();
                                    break;
                                default:
                                    Console.WriteLine("Your Choice {0}, is invalid please press C or B", cos);
                                    goto ces;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Make  : {0}", order.Make31);
                            Console.WriteLine("MODEL  : {0}", order.ModelToyota11);
                            Console.WriteLine("DOORS : FOUR DOORS");
                            Console.WriteLine("WEELS : Golden");
                            Console.WriteLine("ENGINE TYPE : AUTOMATIC");
                            Console.WriteLine("ENGINE CAPACITY : 0.98887 ");
                            Console.WriteLine("CAR ID : {0}", car.GetNumber());
                            Console.WriteLine("COLOR : BLACK");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("       __________");
                            Console.WriteLine("   _---            ---");
                            Console.WriteLine("   --()---------()----");
                            Console.WriteLine("\n");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.White;
                    mom:
                            Console.WriteLine("PREES C TO VIEW THE COST OF THE CAR or <B> To GO BACK\n\n");
                            string money = Console.ReadLine().ToUpper();
                            switch (money)
                            {
                                case "C":
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    char[] load = new char[] { 'L', 'O', 'A', 'D', 'I', 'N', 'G' };
                                    int loadIndex = 0;
                                    for (int n = 0; n < 39; n++)
                                    {
                                        Console.Write(load[loadIndex]);
                                        Thread.Sleep(100);
                                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                        loadIndex++;
                                        if (loadIndex >= load.Length)
                                            loadIndex = 0;
                                    }

                                    Console.WriteLine("This Car Will Only Cost You = 1,500,0000");
                                    Console.WriteLine("");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("PREES P TO PAY FOR THE CAR or <B> To GO BACK\n\n");
                                    string pay = Console.ReadLine().ToUpper();
                                    switch (pay)
                                    {
                                        case "P":
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine("WELCOME!...please filled in the following form\n");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("Enter Your FULL Name");
                                            customer.Name1 = Console.ReadLine();
                                            Console.WriteLine("Enter Your Address");
                                            customer.Address1 = Console.ReadLine();
                                            Console.WriteLine("Enter Your Phone Number");
                                            customer.PhonNumber1 = long.Parse(Console.ReadLine());
                                            Console.Write("Enter Your Bank Name : ");
                                            customer.BankName1 = Console.ReadLine();
                                            Console.Write("Enter Your Credit Card Number : ");
                                            customer.CreditCardNum1 = Console.ReadLine();
                                            Console.Write("Enter Date");
                                            customer.Date1 = Console.ReadLine();
                                        amt:
                                            Console.WriteLine("Enter The AMOUNT OF THE CAR");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        long priceoption = 1000000;
                                        Console.WriteLine("NOTE.... Enter 1 miloin only. The rest Of Payment will Be Completed In The Destination Were You are Going To Collect The Car And The Rest of The DUCMENTS!");
                                        car.Price = long.Parse((Console.ReadLine()));
                                        if (car.Price == priceoption)
                                        {
                                            goto contineu;
                                        }
                                        if (car.Price < priceoption)
                                        {
                                            Console.WriteLine("\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("YOUR AMOUNT {0} IS INSUFICIANT. YOU NEED 1000000 TO COMPLET THE TRANSACTION", car.Price);
                                            Console.WriteLine("\n");
                                            goto amt;
                                        }
                                        if (car.Price > priceoption)
                                        {
                                        rhe:
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("\n");
                                            Console.WriteLine("WARNING!!!!..YOU ENTERD EXTRA AMOUNT.");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("Press R to Read The instruction befor you type in your AMOUNT\n");
                                            Console.WriteLine("Press H to See How To Buy A Car In Our Campany\n");
                                            Console.WriteLine("OR Press E to Exit");
                                            Console.WriteLine("\n");
                                            string RHE = Console.ReadLine().ToUpper();
                                            switch (RHE)
                                            {
                                                case "R":
                                                    goto amt;

                                                case "H":
                                                    Program pr = new Program();
                                                    pr.HowToBuy();
                                                    break;
                                                case "E":
                                                    Console.WriteLine(">>>>>>>>>>>HAVE A GREAT DAY<<<<<<<<<");
                                                    break;
                                                default:
                                                    Console.WriteLine("Your Choice {0} is invalid please press R, H or E and press Enter");
                                                    goto rhe;
                                            }
                                        }
                                    contineu:
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("\n");
                                            Console.WriteLine("Thanks {0}, Please Press P Now To PRINT your INVOICE", customer.Name1);
                                            string print = Console.ReadLine().ToUpper();
                                            switch (print)
                                            {
                                                case "P":
                                                    Console.WriteLine("");
                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                    Console.WriteLine("┌────****───────────────****──────────****──────────****────────****────────╖\n");
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("        ┌────<>──────<>──────<>─────<>─────<>──────<>────<>────╖\n");
                                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                                    Console.WriteLine("                   {0}                                  ", invoice.Name1);
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("              {0}                                  ", invoice.Address1);
                                                    Console.WriteLine("              {0}                                  ", invoice.Email1);
                                                    Console.WriteLine("              {0}                                  ", invoice.PhonNumber1);
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("        ╘═══<>══════<>══════<>══════<>═════<>══════<>════<>════╝");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("");
                                                    Console.WriteLine("   SOLD TO");
                                                    Console.WriteLine("   ────────");
                                                    Console.WriteLine("       NAME         : {0} ", customer.Name1);
                                                    Console.WriteLine("       ADDRESS      : {0}", customer.Address1);
                                                    Console.WriteLine("       PHONE NUMBER : {0}", customer.PhonNumber1);
                                                    Console.WriteLine("");
                                                    Console.WriteLine("                                         INVOICE No : {0} ", invoice.InvoiceNumber1);
                                                    Console.WriteLine("                                         DATE       : {0}", Date.ToString("D"));
                                                    Console.WriteLine("                                         TIME       : {0}", Date.ToString("T"));
                                                    Console.WriteLine("");
                                                    Console.WriteLine("       MAKE        : {0}", order.Make31);
                                                    Console.WriteLine("       MODEL       : {0}", order.ModelToyota11);
                                                    Console.WriteLine("       ENGINE TYPE : Automatic");
                                                    Console.WriteLine("       COLOR       : Black");
                                                    Console.WriteLine("");
                                                    Console.WriteLine("                                         CAR ID : {0}", car.GetNumber());
                                                    Console.WriteLine("                                         AMOUNT PAID : {0}", car.GetCost());
                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                    Console.WriteLine("");
                                                    Console.WriteLine("╘════****══════════════****═══════════****══════════****═════════****═══════╝");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("");
                                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                                    Console.WriteLine("{0}!, Make Sure You Come Along With This Invoice Wen Coming To Our Office..THANKS", customer.Name1);
                                                    Console.WriteLine("");
                                                    Console.WriteLine("_________________________________________\n");
                                                    Console.WriteLine("            {0}", customer.BankName1);
                                                    Console.WriteLine("|          *************************      |");
                                                    Console.WriteLine("|                                         |");
                                                    Console.WriteLine("| WITHDRAWAL Alart!                       |");
                                                    Console.WriteLine("|                                         |");
                                                    Console.WriteLine("| ACC No : {0}", customer.CreditCardNum1);
                                                    Console.WriteLine("| Amount : {0}", car.Price);
                                                    Console.WriteLine("| Balance: 87,000000                      |");
                                                    Console.WriteLine("| Date   : {0}", customer.Date1);
                                                    Console.WriteLine("| TIME   : {0}", Date.ToString("T"));
                                                    Console.WriteLine("|");
                                                    Console.WriteLine("|_________________________________________|");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("PRESS M TO GO BACK TO THE MAIN MENU or E TO EXIT");
                                                    string exit = Console.ReadLine().ToUpper();
                                                    switch (exit)
                                                    {
                                                        case "M":
                                                            Program.Main();
                                                            break;
                                                        case "E":
                                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                                            Console.WriteLine(">>>>>>>>>>HAVE A GREAT DAY!<<<<<<<<<<<<<");
                                                            break;
                                                    }
                                                    break;
                                            }
                                            break;
                                        case "B":
                                            BuyCar();
                                            break;
                                    }

                                    break;
                                case "B":
                                    BuyCar();
                                    break;
                                default:
                                    Console.WriteLine("Your Choice {0}, is invalid please press C or B", money);
                                    goto mom;
                            }
                            break;
                        default:
                            Console.WriteLine("Your Choice {0}, is invalid please press P", Ck);
                            goto ck;

                    }
                    break;
                default:
                    Console.WriteLine("Your Choice {0}, is invalid please press C or A", UserDecision);
                    goto tt;
            }
        }
        #endregion
        #region BOOKING
        public void Booking()
        {
            ProductCar product = new ProductCar();
            Car car = new Car();
            OrderCar order = new OrderCar();
            CustomerDetails customer = new CustomerDetails();
            InvoiceOfTheCar invoice = new InvoiceOfTheCar();
            DateTime Date = new DateTime();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("                                 GOLDEN CAR BOOKING INC");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                                <><><><><><><><><><><><><>\n");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("SEARCH A CAR");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
            Console.Write("Enter The Name or Make Of The Car : ");
            product.Make11=Console.ReadLine();
            Console.Write("Enter The Model Of The Car : ");
            product.ModelHonda11 = Console.ReadLine();
            Console.Write("Enter The Engine Capacity Of The Car : ");
            product.EnginCapacity1=Console.ReadLine();
            Console.Write("Enter The Engine Type Of The Car : ");
            product.EnginType1 = Console.ReadLine();
            Console.Write("Enter The AC Capacity Of The Car : ");
            product.AC1 = Console.ReadLine();
            Console.Write("Enter The Number Of Door Of The Car : ");
            product.Doors1=Console.ReadLine();
            Console.Write("Enter The Color Of The Car : ");
            product.Color1=Console.ReadLine();
            Console.Write("Enter The Location Of Tha Car : ");
            string  Location = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.Yellow;
            char[] load = new char[] { 'S', 'E', 'A', 'C', 'H', 'I', 'N','G' };
            int loadIndex = 0;
            for (int n = 0; n < 39; n++)
            {
                Console.Write(load[loadIndex]);
                Thread.Sleep(100);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                loadIndex++;
                if (loadIndex >= load.Length)
                    loadIndex = 0;
            }
            if (Location == product.Location1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" Make            : {0} ",product.Make11);
                Console.WriteLine(" Model            : {0}",product.ModelHonda11);
                Console.WriteLine(" Engine Capacity  : {0} ",product.EnginCapacity1);
                Console.WriteLine(" Engine Type     : {0}",product.EnginType1);
                Console.WriteLine(" AC              : {0}",product.AC1);
                Console.WriteLine(" Door Of The Car : {0}",product.Doors1);
                Console.WriteLine(" Color Of The Car : {0}",product.Color1);
                Console.WriteLine("");
                Console.WriteLine("This Car is Available in {0}",Location);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("       __________");
                Console.WriteLine("   _---            ---");
                Console.WriteLine("   --()---------()----");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Yellow;
            bckt:
                Console.WriteLine("Press < B > now to BOOK The Car or < S > to Search for another CAR\n");
                Console.ForegroundColor = ConsoleColor.White;
                string book = Console.ReadLine().ToUpper();
                switch (book)
                {
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("WELCOME!...please filled in the following form\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Enter Booking Date : ");
                        product.BookingDate1 = Console.ReadLine();
                        Console.Write("Enter Pick Up Date : ");
                        product.PicUpDate1 = Console.ReadLine();
                        Console.Write("Enter Your FULL Name :");
                        customer.Name1 = Console.ReadLine();
                        Console.Write("Enter Your Address : ");
                        customer.Address1 = Console.ReadLine();
                        Console.WriteLine("Enter Your Phone Number : ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                poo:
                        Console.WriteLine("Thanks {0}, Please Press P Now To PRINT your INVOICE", customer.Name1);
                                            string print = Console.ReadLine().ToUpper();
                                            switch (print)
                                            {
                                                case "P":
                                                    Console.WriteLine("");
                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                    Console.WriteLine("┌────****───────────────****──────────****──────────****────────****────────╖\n");
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("        ┌────<>──────<>──────<>─────<>─────<>──────<>────<>────╖\n");
                                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                                    Console.WriteLine("                   {0}                                  ", invoice.Name1);
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("              {0}                                  ", invoice.Address1);
                                                    Console.WriteLine("              {0}                                  ", invoice.Email1);
                                                    Console.WriteLine("              {0}                                  ", invoice.PhonNumber1);
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("        ╘═══<>══════<>══════<>══════<>═════<>══════<>════<>════╝");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("");
                                                    Console.WriteLine("   BOOK TO");
                                                    Console.WriteLine("   ────────");
                                                    Console.WriteLine("       NAME         : {0} ", customer.Name1);
                                                    Console.WriteLine("       ADDRESS      : {0}", customer.Address1);
                                                    Console.WriteLine("       PHONE NUMBER : {0}", customer.PhonNumber1);
                                                    Console.WriteLine("");
                                                    Console.WriteLine("                                         INVOICE No   : {0} ", invoice.InvoiceNumber1);
                                                    Console.WriteLine("                                         BOOKING DATE : {0} ",product.BookingDate1);
                                                    Console.WriteLine("                                         PICK UP DATE : {0} ",product.PicUpDate1);
                                                    Console.WriteLine("                                         DATE         : {0}", Date.ToString("D"));
                                                    Console.WriteLine("                                         TIME         : {0}", Date.ToString("T"));
                                                    Console.WriteLine("");
                                                    Console.WriteLine("       MAKE        : {0}", product.Make11);
                                                    Console.WriteLine("       MODEL       : {0}", product.ModelHonda11);
                                                    Console.WriteLine("       ENGINE TYPE : {0}",product.EnginType1);
                                                    Console.WriteLine("       COLOR       : {0}",product.Color1);
                                                    Console.WriteLine("");
                                                    Console.WriteLine("                                         CAR ID : {0}", car.GetNumber());
                                                    Console.WriteLine("                                         AMOUNT PAID : WithHeld");
                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                    Console.WriteLine("");
                                                    Console.WriteLine("╘════****══════════════****═══════════****══════════****═════════****═══════╝\n\n");
                                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                                    Console.WriteLine("{0}!, Make Sure You Come Along With This Invoice Wen Coming To Our Office..THANKS", customer.Name1);
                                                    Console.WriteLine("");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                            kkl:
                                                    Console.WriteLine("PRESS M TO GO BACK TO THE MAIN MENU or E TO EXIT");
                                                    string exit = Console.ReadLine().ToUpper();
                                                    switch (exit)
                                                    {
                                                        case "M":
                                                            Program.Main();
                                                            break;
                                                        case "E":
                                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                                            Console.WriteLine(">>>>>>>>>>HAVE A GREAT DAY!<<<<<<<<<<<<<");
                                                            break;
                                                            default:
                                                            Console.WriteLine("Your Choice {0}, is invalid please press M or E",exit);
                                                            goto kkl;
                                                    }
                                                    break;
                                                    default:
                                                           Console.WriteLine("Your Choice {0}, is invalid please press P",print);
                                                           goto poo;
                                            }
                        break;
                    case "S":
                        Booking();
                        break;
                    default:
                        Console.WriteLine("Your Choice {0}, is invalid please press B or S",book);
                        goto bckt;
                }
                
            }
            else if (Location == product.Location2)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" Make            : {0} ", product.Make11);
                Console.WriteLine(" Model            : {0}", product.ModelHonda11);
                Console.WriteLine(" Engine Capacity  : {0} ", product.EnginCapacity1);
                Console.WriteLine(" Engine Type     : {0}", product.EnginType1);
                Console.WriteLine(" AC              : {0}", product.AC1);
                Console.WriteLine(" Door Of The Car : {0}", product.Doors1);
                Console.WriteLine(" Color Of The Car : {0}", product.Color1);
                Console.WriteLine("");
                Console.WriteLine("This Car is Available in {0}", Location);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("       __________");
                Console.WriteLine("   _---            ---");
                Console.WriteLine("   --()---------()----");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Yellow;
            bbkk:
                Console.WriteLine("Press < B > now to BOOK The Car or < S > to Search for another CAR\n");
                Console.ForegroundColor = ConsoleColor.White;
                string book = Console.ReadLine().ToUpper();
                switch (book)
                {
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("WELCOME!...please filled in the following form\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Enter Booking Date : ");
                        product.BookingDate1 = Console.ReadLine();
                        Console.Write("Enter Pick Up Date : ");
                        product.PicUpDate1 = Console.ReadLine();
                        Console.Write("Enter Your FULL Name :");
                        customer.Name1 = Console.ReadLine();
                        Console.Write("Enter Your Address : ");
                        customer.Address1 = Console.ReadLine();
                        Console.WriteLine("Enter Your Phone Number : ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                ppo:
                        Console.WriteLine("Thanks {0}, Please Press P Now To PRINT your INVOICE", customer.Name1);
                        string print = Console.ReadLine().ToUpper();
                        switch (print)
                        {
                            case "P":
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("┌────****───────────────****──────────****──────────****────────****────────╖\n");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("        ┌────<>──────<>──────<>─────<>─────<>──────<>────<>────╖\n");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("                   {0}                                  ", invoice.Name1);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("              {0}                                  ", invoice.Address1);
                                Console.WriteLine("              {0}                                  ", invoice.Email1);
                                Console.WriteLine("              {0}                                  ", invoice.PhonNumber1);
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("        ╘═══<>══════<>══════<>══════<>═════<>══════<>════<>════╝");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("");
                                Console.WriteLine("   BOOK TO");
                                Console.WriteLine("   ────────");
                                Console.WriteLine("       NAME         : {0} ", customer.Name1);
                                Console.WriteLine("       ADDRESS      : {0}", customer.Address1);
                                Console.WriteLine("       PHONE NUMBER : {0}", customer.PhonNumber1);
                                Console.WriteLine("");
                                Console.WriteLine("                                         INVOICE No   : {0} ", invoice.InvoiceNumber1);
                                Console.WriteLine("                                         BOOKING DATE : {0} ", product.BookingDate1);
                                Console.WriteLine("                                         PICK UP DATE : {0} ", product.PicUpDate1);
                                Console.WriteLine("                                         DATE         : {0}", Date.ToString("D"));
                                Console.WriteLine("                                         TIME         : {0}", Date.ToString("T"));
                                Console.WriteLine("");
                                Console.WriteLine("       MAKE        : {0}", product.Make11);
                                Console.WriteLine("       MODEL       : {0}", product.ModelHonda11);
                                Console.WriteLine("       ENGINE TYPE : {0}", product.EnginType1);
                                Console.WriteLine("       COLOR       : {0}", product.Color1);
                                Console.WriteLine("");
                                Console.WriteLine("                                         CAR ID : {0}", car.GetNumber());
                                Console.WriteLine("                                         AMOUNT PAID : WithHeld");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("");
                                Console.WriteLine("╘════****══════════════****═══════════****══════════****═════════****═══════╝\n\n");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("{0}!, Make Sure You Come Along With This Invoice Wen Coming To Our Office..THANKS", customer.Name1);
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.White;
                        ex:
                                Console.WriteLine("PRESS M TO GO BACK TO THE MAIN MENU or E TO EXIT");
                                string exit = Console.ReadLine().ToUpper();
                                switch (exit)
                                {
                                    case "M":
                                        Program.Main();
                                        break;
                                    case "E":
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine(">>>>>>>>>>HAVE A GREAT DAY!<<<<<<<<<<<<<");
                                        break;
                                        default:
                                        Console.WriteLine("Your Choice {0}, is invalid please press M or E",exit);
                                        goto ex;
                                }
                                break;
                                default:
                                Console.WriteLine("Your Choice {0}, is invalid please press P ",print);
                                goto ppo;
                        }
                        break;
                    case "S":
                        Booking();
                        break;
                        default:
                        Console.WriteLine("Your Choice {0}, is invalid please press B or S",book);
                        goto bbkk;
                }
                
            }
            else if (Location == product.Location3)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" Make            : {0} ", product.Make11);
                Console.WriteLine(" Model            : {0}", product.ModelHonda11);
                Console.WriteLine(" Engine Capacity  : {0} ", product.EnginCapacity1);
                Console.WriteLine(" Engine Type     : {0}", product.EnginType1);
                Console.WriteLine(" AC              : {0}", product.AC1);
                Console.WriteLine(" Door Of The Car : {0}", product.Doors1);
                Console.WriteLine(" Color Of The Car : {0}", product.Color1);
                Console.WriteLine("");
                Console.WriteLine("This Car is Available in {0}", Location);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("       __________");
                Console.WriteLine("   _---            ---");
                Console.WriteLine("   --()---------()----");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Yellow;
            bbll:
                Console.WriteLine("Press < B > now to BOOK The Car or < S > to Search for another CAR\n");
                Console.ForegroundColor = ConsoleColor.White;
                string book = Console.ReadLine().ToUpper();
                switch (book)
                {
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("WELCOME!...please filled in the following form\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Enter Booking Date : ");
                        product.BookingDate1 = Console.ReadLine();
                        Console.Write("Enter Pick Up Date : ");
                        product.PicUpDate1 = Console.ReadLine();
                        Console.Write("Enter Your FULL Name :");
                        customer.Name1 = Console.ReadLine();
                        Console.Write("Enter Your Address : ");
                        customer.Address1 = Console.ReadLine();
                        Console.WriteLine("Enter Your Phone Number : ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                ppr:
                        Console.WriteLine("Thanks {0}, Please Press P Now To PRINT your INVOICE", customer.Name1);
                        string print = Console.ReadLine().ToUpper();
                        switch (print)
                        {
                            case "P":
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("┌────****───────────────****──────────****──────────****────────****────────╖\n");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("        ┌────<>──────<>──────<>─────<>─────<>──────<>────<>────╖\n");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("                   {0}                                  ", invoice.Name1);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("              {0}                                  ", invoice.Address1);
                                Console.WriteLine("              {0}                                  ", invoice.Email1);
                                Console.WriteLine("              {0}                                  ", invoice.PhonNumber1);
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("        ╘═══<>══════<>══════<>══════<>═════<>══════<>════<>════╝");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("");
                                Console.WriteLine("   BOOK TO");
                                Console.WriteLine("   ────────");
                                Console.WriteLine("       NAME         : {0} ", customer.Name1);
                                Console.WriteLine("       ADDRESS      : {0}", customer.Address1);
                                Console.WriteLine("       PHONE NUMBER : {0}", customer.PhonNumber1);
                                Console.WriteLine("");
                                Console.WriteLine("                                         INVOICE No   : {0} ", invoice.InvoiceNumber1);
                                Console.WriteLine("                                         BOOKING DATE : {0} ", product.BookingDate1);
                                Console.WriteLine("                                         PICK UP DATE : {0} ", product.PicUpDate1);
                                Console.WriteLine("                                         DATE         : {0}", Date.ToString("D"));
                                Console.WriteLine("                                         TIME         : {0}", Date.ToString("T"));
                                Console.WriteLine("");
                                Console.WriteLine("       MAKE        : {0}", product.Make11);
                                Console.WriteLine("       MODEL       : {0}", product.ModelHonda11);
                                Console.WriteLine("       ENGINE TYPE : {0}", product.EnginType1);
                                Console.WriteLine("       COLOR       : {0}", product.Color1);
                                Console.WriteLine("");
                                Console.WriteLine("                                         CAR ID : {0}", car.GetNumber());
                                Console.WriteLine("                                         AMOUNT PAID : WithHeld");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("");
                                Console.WriteLine("╘════****══════════════****═══════════****══════════****═════════****═══════╝\n\n");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("{0}!, Make Sure You Come Along With This Invoice Wen Coming To Our Office..THANKS", customer.Name1);
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.White;
                        bt:
                                Console.WriteLine("PRESS M TO GO BACK TO THE MAIN MENU or E TO EXIT");
                                string exit = Console.ReadLine().ToUpper();
                                switch (exit)
                                {
                                    case "M":
                                        Program.Main();
                                        break;
                                    case "E":
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine(">>>>>>>>>>HAVE A GREAT DAY!<<<<<<<<<<<<<");
                                        break;
                                        default:
                                        Console.WriteLine("Your Choice {0}, is invalid please press B or S",exit);
                                        goto bt;
                                }
                                break;
                                default:
                        Console.WriteLine("Your Choice {0}, is invalid please press P",print);
                        goto ppr;
                        }
                        break;
                    case "S":
                        Booking();
                        break;
                        default:
                        Console.WriteLine("Your Choice {0}, is invalid please press B or S",book);
                        goto bbll;
                }

                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sory! This Car is Not AVAILABE in this Location ");
                Console.ForegroundColor = ConsoleColor.White;
            bw:
                Console.WriteLine("Press <B> To Search for another car or <E> to Exit");
                string search = Console.ReadLine().ToUpper();
                switch (search)
                {
                    case "B":
                        Booking();
                        break;
                    case "E":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(">>>>>>>>>>Have A Great Day<<<<<<<<<<<<");
                        break;
                        default:
                        Console.WriteLine("Your Choice {0}, is invalid please press B or E",search);
                        goto bw;
                }
            }

        }
        #endregion
    }
}

