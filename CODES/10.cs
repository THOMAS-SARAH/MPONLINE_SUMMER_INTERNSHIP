using System;
using System.Collections.Generic;
using System.Text;

namespace proj1
{
    class Product
    {
        public int ID;
        public string Name;
        public double Price;
        public int Quantity;

        public double Total()
        {
            return Price * Quantity;
        }
    }

    class Pricing
    {
        public static void ShoppingCart()
        {
            Console.Write("Enter number of products: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Product[] cart = new Product[n];
            double grandTotal = 0;

            for (int i = 0; i < n; i++)
            {
                cart[i] = new Product();

                Console.WriteLine("\nProduct " + (i + 1));

                Console.Write("Enter ID: ");
                cart[i].ID = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Name: ");
                cart[i].Name = Console.ReadLine();

                Console.Write("Enter Price: ");
                cart[i].Price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Quantity: ");
                cart[i].Quantity = Convert.ToInt32(Console.ReadLine());

                grandTotal += cart[i].Total();
            }

            Console.WriteLine("\nShopping Cart");
            Console.WriteLine("ID\tName\tPrice\tQty\tTotal");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(cart[i].ID + "\t" +
                                  cart[i].Name + "\t" +
                                  cart[i].Price + "\t" +
                                  cart[i].Quantity + "\t" +
                                  cart[i].Total());
            }

            Console.WriteLine("\nTotal Cost = " + grandTotal);
        }
    }

    internal class ShoppingCart2705
    {
        public static void Main()
        {
            Pricing.ShoppingCart();
        }
    }
}
