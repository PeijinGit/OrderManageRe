using OrderManaRe.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManaRe.Common
{
    class TableHelper
    {
         string Square = "Square";
         string Triangle = "Triangle";
         string Circle = "Circle";
         int tableWidth = 73;

        public void GenerateTable(List<Shape> OrderedBlocks)
        {
            tableWidth = 73;
            PrintLine();
            PrintRow("        ", "   Red   ", "  Blue  ", " Yellow ");
            PrintLine();
            PrintRow(Square, OrderedBlocks[0].NumberOfRedShape.ToString(), OrderedBlocks[0].NumberOfBlueShape.ToString(), OrderedBlocks[0].NumberOfYellowShape.ToString());
            PrintRow(Triangle, OrderedBlocks[1].NumberOfRedShape.ToString(), OrderedBlocks[1].NumberOfBlueShape.ToString(), OrderedBlocks[1].NumberOfYellowShape.ToString());
            PrintRow(Circle, OrderedBlocks[2].NumberOfRedShape.ToString(), OrderedBlocks[2].NumberOfBlueShape.ToString(), OrderedBlocks[2].NumberOfYellowShape.ToString());
            PrintLine();
        }

        public void GenerateCuttingTable(List<Shape> OrderedBlocks) 
        {
            tableWidth = 20;
            PrintLine();
            PrintRow("        ", "   Qty   ");
            PrintLine();
            PrintRow(Square, OrderedBlocks[0].TotalQuantityOfShape().ToString());
            PrintRow(Triangle, OrderedBlocks[1].TotalQuantityOfShape().ToString());
            PrintRow(Circle, OrderedBlocks[2].TotalQuantityOfShape().ToString());
            PrintLine();
        }

        private void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        private void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        private string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}
