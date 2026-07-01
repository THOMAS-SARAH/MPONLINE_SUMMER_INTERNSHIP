using System;

class AutomobileInvoice
{
    private string customerName;
    private string vehicleName;
    private double vehiclePrice;
    private double accessoriesPrice;
    private double discount;

    public static double TotalSalesAmount = 0;
    public static int TotalVehicleSales = 0;

    public void GetData()
    {
        Console.Write("Enter Customer Name : ");
        customerName = Console.ReadLine();

        Console.Write("Enter Vehicle Name : ");
        vehicleName = Console.ReadLine();

        Console.Write("Enter Vehicle Price : ");
        vehiclePrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Add Accessories? (Y/N): ");
        char ch = Convert.ToChar(Console.ReadLine());

        if (ch == 'Y' || ch == 'y')
        {
            Console.Write("Enter Accessories Price : ");
            accessoriesPrice = Convert.ToDouble(Console.ReadLine());
        }
        else
        {
            accessoriesPrice = 0;
        }

        Console.Write("Give Discount? (Y/N): ");
        ch = Convert.ToChar(Console.ReadLine());

        if (ch == 'Y' || ch == 'y')
        {
            Console.Write("Enter Discount Amount : ");
            discount = Convert.ToDouble(Console.ReadLine());
        }
        else
        {
            discount = 0;
        }
    }

    public void GenerateBill()
    {
        double total = vehiclePrice + accessoriesPrice - discount;

        Console.WriteLine("\n========= AUTOMOBILE SHOWROOM BILL =========");
        Console.WriteLine("Customer Name      : " + customerName);
        Console.WriteLine("Vehicle Name       : " + vehicleName);
        Console.WriteLine("Vehicle Price      : " + vehiclePrice);
        Console.WriteLine("Accessories Price  : " + accessoriesPrice);
        Console.WriteLine("Discount           : " + discount);
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Final Amount       : " + total);
        Console.WriteLine("============================================");

        TotalSalesAmount += total;
        TotalVehicleSales++;
    }

    public static void ShowSalesReport()
    {
        Console.WriteLine("\n========= SALES REPORT =========");
        Console.WriteLine("Total Vehicle Sales : " + TotalVehicleSales);
        Console.WriteLine("Total Sales Amount  : " + TotalSalesAmount);
    }
}
