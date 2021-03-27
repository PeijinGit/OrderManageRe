using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManaRe.Model
{
    class Square : Shape
    {
        public Square(int red, int blue, int yellow)
        {
            base.Price = 1;
            base.NumberOfRedShape = red;
            base.NumberOfBlueShape = blue;
            base.NumberOfYellowShape = yellow;
        }
    }
}
