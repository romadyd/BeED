using System.Data.SqlClient;

namespace BeED.Data
{
    public class BaseConnection
    {
        public SqlConnection? connection;

        public BaseConnection(IConfiguration configuration)
        {
            try
            {
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                connection = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
