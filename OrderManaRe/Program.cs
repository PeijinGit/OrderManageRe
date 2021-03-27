using OrderManaRe.Common;
using OrderManaRe.Model;
using System;
using System.Collections.Generic;

namespace OrderManaRe
{
    class Program
    {
        static void Main(string[] args)
        {
            //UserInfo userInfo = new UserInfo();
            //CustomerInfoInput(userInfo);
            TableHelper tableHelper = new TableHelper();
            var (customerName, address, dueDate) = CustomerInfoInput();

            var orderedShapes = CustomerOrderInput();

            InvoiceReport(customerName, address, dueDate, orderedShapes, tableHelper);

            CuttingListReport(customerName, address, dueDate, orderedShapes, tableHelper);

            PaintingReport(customerName, address, dueDate, orderedShapes, tableHelper);
        }

        private static (string customerName, string address, string dueDate) CustomerInfoInput()
        {
            Console.Write("Please input your Name: ");
            string customerName = UserInput();
            Console.Write("Please input your Address: ");
            string address = UserInput();
            Console.Write("Please input your Due Date: ");
            string dueDate = UserInput();
            return (customerName, address, dueDate);
        }

        // User Console Input
        public static string UserInput()
        {
            string input = Console.ReadLine();
            while (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("please enter valid details");
                input = Console.ReadLine();

            }
            return input;
        }

        // Get order input
        private static List<Shape> CustomerOrderInput()
        {
            Square square = OrderShapeInput<Square>();
            Triangle triangle = OrderShapeInput<Triangle>();
            Circle circle = OrderShapeInput<Circle>();

            var orderedShapes = new List<Shape>();
            orderedShapes.Add(square);
            orderedShapes.Add(triangle);
            orderedShapes.Add(circle);
            return orderedShapes;
        }

        // Order Triangles Input
        public static T OrderShapeInput<T>()
        {
            Console.Write("\nPlease input the number of Red Triangles: ");
            int redShape = Convert.ToInt32(UserInput());
            Console.Write("Please input the number of Blue Triangles: ");
            int blueShape = Convert.ToInt32(UserInput());
            Console.Write("Please input the number of Yellow Triangles: ");
            int yellowShape = Convert.ToInt32(UserInput());

            object[] pInfos = new object[] { redShape, blueShape, yellowShape };
            T shape = (T)Activator.CreateInstance(typeof(T), pInfos);
            return shape;
        }

        // Generate Painting Report 
        private static void PaintingReport(string customerName, string address, string dueDate, List<Shape> orderedShapes,TableHelper tableHelper)
        {
            PaintingReport paintingReport = new PaintingReport(customerName, address, dueDate, orderedShapes, tableHelper);
            paintingReport.GenerateReport();
        }

        // Generate Painting Report 
        private static void CuttingListReport(string customerName, string address, string dueDate, List<Shape> orderedShapes, TableHelper tableHelper)
        {
            CuttingListReport cuttingListReport = new CuttingListReport(customerName, address, dueDate, orderedShapes, tableHelper);
            cuttingListReport.GenerateReport();
        }

        // Generate Invoice Report 
        private static void InvoiceReport(string customerName, string address, string dueDate, List<Shape> orderedShapes, TableHelper tableHelper)
        {
            InvoiceReport invoiceReport = new InvoiceReport(customerName, address, dueDate, orderedShapes, tableHelper);
            invoiceReport.GenerateReport();
        }
    }
}
