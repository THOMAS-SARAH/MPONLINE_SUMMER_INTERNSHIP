using System.Configuration;
using System.Data.SqlClient;

namespace ShipmentTrackingSystem
{
    class Database
    {
        public static SqlConnection GetConnection()
        {
            string con = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            return new SqlConnection(con);
        }
    }
}
