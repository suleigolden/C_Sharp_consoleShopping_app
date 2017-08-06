using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GCar
{
    public class Car
    {
        //String[] CarModel = new String[3];
        String CarNames =string.Empty;
        String CarType=string.Empty;
        String EngineCapacity = "";
        String Weels          = "";
        //String ColorNames = "";
        String Color = "(YELLOW)....(RED)....(Wite)....(BLACK)....(BLUE)....(GREEN)";
        String Model          = "";
        String  CarNumber="ME87000998";
        Boolean On = false;
        Boolean Offcar = true;
        String Car1 = "[ BMW ] ";
        String Car2 = "[ HONDA ]  ";
        String Car3 = "[ TOYOTA ]";
        String ToopSpeed = "TOOP SPEED..........368kmh.....250kmph";
        String HoursePawer = "HORSE PAWER..............0.33";
        String EngineCapacityNumber = "ENGINE CAPACITY......0.098..8909....0.788";
        String Dors4 = "FOR DORS";
        String Dors2 = "FOR DORS";
        String WeelsType = "[ GOLDEN WEELS ]  [ SILVER WEELS ]";
        long Cost=0;
        public Car()
        {
        }
#region ON/OF 
        //ON AND OFF
        public void CarOn()
        {
            On = true;
        }
        public void CarOff()
        {
            On = false;
        }
        //off car
        public void OffCar(Boolean Ofcar)
        {
            if (On)
            {
                Offcar = Ofcar;
            }
        }
#endregion

        //COLOR
        public void SetColor(String color)
        {
            Color = color;
        }
        public string GetColor()
        {
            return Color;
        }
        //MODEL
        public void SetModel(String model)
        {
            Model = model;
        }
        public String GetModel()
        {
            return Model;
        }
        //Car NAME
        public void SetCarName(string cname)
        {
            CarNames = cname;
        }
        public string GetCarName()
        {
            return CarNames;
        }
        //CAR TYPE
        public void SetCarType(string Ctype)
        {
            CarType = Ctype;
        }
        public String GetCtype()
        {
            return CarType;
        }
        //ENGIN CAPACITY
        public void SetEng(String setEng)
        {
            EngineCapacity = setEng;
        }
        public String GetCapacity()
        {
            return EngineCapacity;
        }
        //WEELS
        public void SetweelType(string weels)
        {
            Weels = weels;
        }
        public String GetWeels()
        {
            return Weels;
        }
        //AC
        String Ac = "(1.0hp).....(2.0hp)......(0.9hp)";

        public String Ac1
        {
            get { return Ac; }
            set { Ac = value; }
        }
        //Car Number
        public void SetNumber(string  num)
        {
            CarNumber = num;
        }
        public string GetNumber()
        {
            return CarNumber;
        }
        #region Name of Car
        //car1
        public String GetCar1()
        {
            return Car1;
        }
        //Car2
        public String GetCa2()
        {
            return Car2;
        }
        //car3
        public String GetCarss3()
        {
            return Car3;
        }
        #endregion

        #region Properties of the Car
        //Toop speed
        public String GetTopSpeed()
        {
            return ToopSpeed;
        }
        //Hourse power
        public String GetHouesePawer()
        {
            return HoursePawer;
        }
        //Eng capacity
        public void SetEngCapacityNumber(string EncapNum)
        {
            EngineCapacityNumber = EncapNum;
        }
        public String GetEngCapacityNumber()
        {
            return EngineCapacityNumber;
        }
        //Dors
        public void SetDoors4(string doors)
        {
            Dors4 = doors;
        }
        public String GetDor4()
        {
            return Dors4;
        }
        public String GetDor2()
        {
            return Dors2;
        }
       // Weels
        public String GetWeelType()
        {
            return WeelsType;
        }
        //Engine Type
        String EngType = "[ AUTOMATIC ]  [ MANUAL ]";

        public String EngType1
        {
            get { return EngType; }
            set { EngType = value; }
        }
        //Cost
        public void SetCost(long cost)
        {
            Cost = cost;
        }
        public long GetCost()
        {
            return Cost;
        }
        private long price = 0;

        public long Price
        {
            get { return price; }
            set { price = value; }
        }
        #endregion

    }
}
