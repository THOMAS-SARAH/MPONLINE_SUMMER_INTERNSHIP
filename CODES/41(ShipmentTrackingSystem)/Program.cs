using System;

namespace ShipmentTrackingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n====== Shipment Tracking System ======");

                Console.WriteLine("1. Sales by Salesman and Category");

                Console.WriteLine("2. Monthly Sales by Salesman");

                Console.WriteLine("3. Current Shipment Status");

                Console.WriteLine("4. Shipments Delivered on Given Date");

                Console.WriteLine("5. Average Transit Time per Vehicle");

                Console.WriteLine("6. Shipments Still In Transit");

                Console.WriteLine("7. Route History");

                Console.WriteLine("8. Exit");

                Console.Write("Enter Choice : ");

                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Queries.SalesBySalesmanCategory();
                        break;

                    case 2:
                        Queries.MonthlySales();
                        break;

                    case 3:
                        Queries.ShipmentStatus();
                        break;

                    case 4:
                        Queries.DeliveredOnDay();
                        break;

                    case 5:
                        Queries.AverageTransit();
                        break;

                    case 6:
                        Queries.InTransit();
                        break;

                    case 7:
                        Queries.RouteHistory();
                        break;

                    case 8:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
}
