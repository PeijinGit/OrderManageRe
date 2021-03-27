using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManaRe.Model
{
    class Circle : Shape
    {
        public Circle(int red, int blue, int yellow)
        {
            base.Price = 3;
            base.NumberOfRedShape = red;
            base.NumberOfBlueShape = blue;
            base.NumberOfYellowShape = yellow;
        }
    }
}
