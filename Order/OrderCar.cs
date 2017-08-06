using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    public class OrderCar
    {
        public OrderCar()
        {
        }
        #region YEAR
        private int Year1 = 2004;

        public int Year11
        {
            get { return Year1; }
            set { Year1 = value; }
        }
        private int Year2 = 2004;

        public int Year21
        {
            get { return Year2; }
            set { Year2 = value; }
        }
        private int Year3 = 2007;

        public int Year31
        {
            get { return Year3; }
            set { Year3 = value; }
        }
        private int Year4 = 2009;

        public int Year41
        {
            get { return Year4; }
            set { Year4 = value; }
        }
        private int Year5 = 2005;

        public int Year51
        {
            get { return Year5; }
            set { Year5 = value; }
        }
        #endregion

        #region MAKE
        string Make1 = "BMW";

        public string Make11
        {
            get { return Make1; }
            set { Make1 = value; }
        }
        string Make2 = "HONDA";

        public string Make112
        {
            get { return Make2; }
            set { Make2 = value; }
        }
        string Make3 = "TOYOTA";

        public string Make31
        {
            get { return Make3; }
            set { Make3 = value; }
        }
        string Truck1 = "HUMMER";

        public string Truck11
        {
            get { return Truck1; }
            set { Truck1 = value; }
        }
        string Truck2 = "INFINITY";

        public string Truck21
        {
            get { return Truck2; }
            set { Truck2 = value; }
        }
        string Truck3 = "LAMBORGHINI";

        public string Truck31
        {
            get { return Truck3; }
            set { Truck3 = value; }
        }
        string Truck4 = "JAGUAR";

        public string Truck41
        {
            get { return Truck4; }
            set { Truck4 = value; }
        }
        string Truck5 = "FORD";

        public string Truck51
        {
            get { return Truck5; }
            set { Truck5 = value; }
        }
        string Truck6 = "ISUZU";

        public string Truck61
        {
            get { return Truck6; }
            set { Truck6 = value; }
        }
        #endregion

        #region MODELS
        string ModelMmw1 = "X5";

        public string ModelMmw11
        {
            get { return ModelMmw1; }
            set { ModelMmw1 = value; }
        }
        string ModelMmw2 = "X7";

        public string ModelMmw21
        {
            get { return ModelMmw2; }
            set { ModelMmw2 = value; }
        }
        string ModelMmw3 = "5SERIES";

        public string ModelMmw31
        {
            get { return ModelMmw3; }
            set { ModelMmw3 = value; }
        }

        string ModelHonda1 = "ELEMENT";

        public string ModelHonda11
        {
            get { return ModelHonda1; }
            set { ModelHonda1 = value; }
        }
        string ModelHonda2 = "ACCORD";

        public string ModelHonda22
        {
            get { return ModelHonda2; }
            set { ModelHonda2 = value; }
        }

        public string ModelHonda21
        {
            get { return ModelHonda2; }
            set { ModelHonda2 = value; }
        }
        string ModelHonda3 = "CRV";

        public string ModelHonda31
        {
            get { return ModelHonda3; }
            set { ModelHonda3 = value; }
        }

        string ModelToyota1 = "AVALON";

        public string ModelToyota11
        {
            get { return ModelToyota1; }
            set { ModelToyota1 = value; }
        }
        string ModelToyota2 = "CAMRY";

        public string ModelToyota21
        {
            get { return ModelToyota2; }
            set { ModelToyota2 = value; }
        }
        string ModelToyota3 = "MATRIX";

        public string ModelToyota31
        {
            get { return ModelToyota3; }
            set { ModelToyota3 = value; }
        }
        #endregion

        #region ACTION TYPE
        string ActionTypeBy = "Buy -- Car";

        public string ActionType1
        {
            get { return ActionTypeBy; }
            set { ActionTypeBy = value; }
        }
        string ActionTypeBd = "Book-- Car";

        public string ActionType2
        {
            get { return ActionTypeBd; }
            set { ActionTypeBd = value; }
        }
        #endregion

        #region LOCATION
        string LocationA = "ABUJA";

        public string Location1
        {
            get { return LocationA; }
            set { LocationA = value; }
        }
        string LocationP = "PORTHARCOURT";

        public string Location2
        {
            get { return LocationP; }
            set { LocationP = value; }
        }
        string LocationL = "LAGOS";

        public string Location3
        {
            get { return LocationL; }
            set { LocationL = value; }
        }
        #endregion
    }
}
