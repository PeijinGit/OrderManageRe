using OrderManaRe.Common;
using OrderManaRe.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManaRe.Model
{
    class InvoiceReport : Report
    {
        
        public InvoiceReport(string customerName, string customerAddress, string dueDate, List<Shape> shapes, TableHelper tableHelper)
        {
            base.tableHelper = tableHelper;
            base.CustomerName = customerName;
            base.Address = customerAddress;
            base.DueDate = dueDate;
            base.OrderedBlocks = shapes;
        }

        public override void GenerateReport()
        {
            Console.WriteLine("\nYour invoice report has been generated: ");
            Console.WriteLine(base.ToString());
            tableHelper.GenerateTable(OrderedBlocks);
            OrderSquareDetails();
            OrderTriangleDetails();
            OrderCircleDetails();
            RedPaintSurcharge();
        }

        public void OrderSquareDetails()
        {
            Console.WriteLine("\nSquares 		  " + base.OrderedBlocks[0].TotalQuantityOfShape() + " @ $" + base.OrderedBlocks[0].Price + " ppi = $" + base.OrderedBlocks[0].Total());
        }
        public void OrderTriangleDetails()
        {
            Console.WriteLine("Triangles 		  " + base.OrderedBlocks[1].TotalQuantityOfShape() + " @ $" + base.OrderedBlocks[1].Price + " ppi = $" + base.OrderedBlocks[1].Total());
        }
        public void OrderCircleDetails()
        {
            Console.WriteLine("Circles 		  " + base.OrderedBlocks[2].TotalQuantityOfShape() + " @ $" + base.OrderedBlocks[2].Price + " ppi = $" + base.OrderedBlocks[2].Total());
        }

        public void RedPaintSurcharge()
        {
            Console.WriteLine("Red Color Surcharge       " + TotalAmountOfRedShapes() + " @ $" +
                base.OrderedBlocks[0].AdditionalCharge + " ppi = $" + TotalPriceRedPaintSurcharge());
        }

        public int TotalAmountOfRedShapes()
        {
            return OrderedBlocks[0].NumberOfRedShape + OrderedBlocks[1].NumberOfRedShape +
                   OrderedBlocks[2].NumberOfRedShape;
        }

        public int TotalPriceRedPaintSurcharge()
        {
            return TotalAmountOfRedShapes() * OrderedBlocks[0].AdditionalCharge;
        }

    }
}
