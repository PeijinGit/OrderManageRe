using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManaRe.Model
{
    abstract class Shape 
    {
        protected const int additionalCharge = 1;

        /// <summary>
        /// Property????
        /// </summary>
        public int Price { get; set; }
        public int NumberOfRedShape { get; set; }
        public int AdditionalCharge { get => 1; set => throw new Exception(); }
        public int NumberOfBlueShape { get; set; }
        public int NumberOfYellowShape { get; set; }

        public int TotalQuantityOfShape()
        {
            return NumberOfRedShape + NumberOfBlueShape + NumberOfYellowShape;
        }

        public int AdditionalChargeTotal()
        {
            return NumberOfRedShape * AdditionalCharge;
        }
        public int Total() 
        {

            return NumberOfRedShape * Price+ NumberOfBlueShape * Price+ NumberOfYellowShape * Price;
        }


    }
}
