using System;

class Program
{
    static void Main(string[] args)
    {
        char choice;

        do
        {
            AutomobileInvoice obj = new AutomobileInvoice();

            obj.GetData();
            obj.GenerateBill();

            Console.Write("\nAdd Another Vehicle Sale? (Y/N): ");
            choice = Convert.ToChar(Console.ReadLine());

        } while (choice == 'Y' || choice == 'y');

        AutomobileInvoice.ShowSalesReport();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
