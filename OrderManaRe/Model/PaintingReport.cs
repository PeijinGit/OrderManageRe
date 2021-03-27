using OrderManaRe.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManaRe.Model
{
    class PaintingReport:Report
    {
        public PaintingReport(string customerName, string customerAddress, string dueDate, List<Shape> shapes, TableHelper tableHelper)
        {
            base.tableHelper = tableHelper;
            base.CustomerName = customerName;
            base.Address = customerAddress;
            base.DueDate = dueDate;
            base.OrderedBlocks = shapes;
        }
        public override void GenerateReport()
        {
            Console.WriteLine("\nYour painting report has been generated: ");
            Console.WriteLine(base.ToString());
            tableHelper.GenerateTable(OrderedBlocks);
        }
    }
}
