using OrderManaRe.Common;
using OrderManaRe.Invoice;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManaRe.Model
{
    abstract class Report : IReport
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string DueDate { get; set; }
        public int OrderNumber { get; set; }
        public List<Shape> OrderedBlocks { get; set; }

        protected TableHelper tableHelper;

        public abstract void GenerateReport();

        public int TotalAmountOfRedShapes()
        {
            return OrderedBlocks[0].NumberOfRedShape + OrderedBlocks[1].NumberOfRedShape +
                   OrderedBlocks[2].NumberOfRedShape;
        }

        public int TotalPriceRedPaintSurcharge()
        {
            return TotalAmountOfRedShapes() * OrderedBlocks[0].AdditionalCharge;
        }

        public string ToString()
        {
            return "\nName: " + CustomerName + " Address: " + Address + " Due Date: " + DueDate + " Order #: " + OrderNumber;
        }
    }
}
