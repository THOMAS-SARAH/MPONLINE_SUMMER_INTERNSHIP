using System;
using System.Data.SqlClient;

namespace ShipmentTrackingSystem
{
    class Queries
    {

        //1
        public static void SalesBySalesmanCategory()
        {
            SqlConnection con = Database.GetConnection();

            string sql = @"SELECT SalesmanName,CategoryName,SUM(Amount) TotalSales
                           FROM Sales
                           JOIN Salesman
                           ON Sales.SalesmanID=Salesman.SalesmanID
                           JOIN Category
                           ON Sales.CategoryID=Category.CategoryID
                           GROUP BY SalesmanName,CategoryName";

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine(dr["SalesmanName"] + "\t" +
                                  dr["CategoryName"] + "\t" +
                                  dr["TotalSales"]);
            }

            con.Close();
        }


        //2
        public static void MonthlySales()
        {
            SqlConnection con = Database.GetConnection();

            string sql = @"SELECT SalesmanName,
                           MONTH(SaleDate) Month,
                           SUM(Amount) TotalSales
                           FROM Sales
                           JOIN Salesman
                           ON Sales.SalesmanID=Salesman.SalesmanID
                           GROUP BY SalesmanName,MONTH(SaleDate)";

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine(dr["SalesmanName"] + "\t" +
                                  dr["Month"] + "\t" +
                                  dr["TotalSales"]);
            }

            con.Close();
        }


        //3
        public static void ShipmentStatus()
        {
            SqlConnection con = Database.GetConnection();

            string sql = "SELECT ShipmentID,Status FROM Shipment";

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine(dr["ShipmentID"] + "\t" + dr["Status"]);
            }

            con.Close();
        }


        //4
        public static void DeliveredOnDay()
        {
            Console.Write("Enter Date (yyyy-mm-dd): ");

            string date = Console.ReadLine();

            SqlConnection con = Database.GetConnection();

            string sql = "SELECT * FROM Shipment WHERE DeliveryDate=@d";

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@d", date);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine(dr["ShipmentID"] + "\t" +
                                  dr["Source"] + "\t" +
                                  dr["Destination"]);
            }

            con.Close();
        }


        //5
        public static void AverageTransit()
        {
            SqlConnection con = Database.GetConnection();

            string sql = @"SELECT VehicleName,
                           AVG(DATEDIFF(day,DispatchDate,DeliveryDate)) AvgDays
                           FROM Shipment
                           JOIN Vehicle
                           ON Shipment.VehicleID=Vehicle.VehicleID
                           GROUP BY VehicleName";

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine(dr["VehicleName"] + "\t" +
                                  dr["AvgDays"]);
            }

            con.Close();
        }


        //6
        public static void InTransit()
        {
            SqlConnection con = Database.GetConnection();

            string sql = "SELECT * FROM Shipment WHERE Status='In Transit'";

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine(dr["ShipmentID"] + "\t" +
                                  dr["Source"] + "\t" +
                                  dr["Destination"]);
            }

            con.Close();
        }


        //7
        public static void RouteHistory()
        {
            Console.Write("Enter Shipment ID : ");

            int id = Convert.ToInt32(Console.ReadLine());

            SqlConnection con = Database.GetConnection();

            string sql = @"SELECT Location,UpdateTime
                           FROM RouteHistory
                           WHERE ShipmentID=@id
                           ORDER BY UpdateTime";

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine(dr["Location"] + "\t" +
                                  dr["UpdateTime"]);
            }

            con.Close();
        }

    }
}
