using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManaRe.Model
{
    class Triangle : Shape
    {
        public Triangle(int red, int blue, int yellow)
        {
            base.Price = 2;
            base.NumberOfRedShape = red;
            base.NumberOfBlueShape = blue;
            base.NumberOfYellowShape = yellow;
        }
    }
}
