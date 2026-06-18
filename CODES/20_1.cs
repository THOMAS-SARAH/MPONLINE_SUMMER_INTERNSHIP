using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}

class Program
{
    static void Main()
    {
        List<Item> cart = new List<Item>();

        string conStr = @"Server=.;Database=ShoppingDB;Trusted_Connection=True;";

        using (SqlConnection con = new SqlConnection(conStr))
        {
            con.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT Id, Name, Price FROM Items", con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cart.Add(new Item
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Name = dr["Name"].ToString(),
                    Price = Convert.ToDouble(dr["Price"])
                });
            }
        }

        // Total Price
        Console.WriteLine("Total Price = " + cart.Sum(x => x.Price));

        // Discount 10%
        var discounted = cart.Select(x => new
        {
            x.Name,
            DiscountPrice = x.Price * 0.9
        });

        // Filter Price > 1000
        var filtered = cart.Where(x => x.Price > 1000);

        Console.WriteLine("\nFiltered Items:");
        foreach (var item in filtered)
            Console.WriteLine(item.Name + " " + item.Price);
    }
}
