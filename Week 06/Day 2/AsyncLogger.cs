
using Microsoft.Data.SqlClient;

namespace ConsoleApp41
{
    class Program
    {
        static void Main()
        {
            // Windows Authentication
            string connStr = "Server=BHARATH\\SQLEXPRESS; Database=BookDb; Integrated Security=true; TrustServerCertificate=True";
            string cmdText = "SELECT Count(*) FROM Emp";

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(cmdText, conn);

            conn.Open();
            Console.WriteLine("Database connected successfully...!");

            // unboxing object into int 
            // ExecuteScalar()  return the data  as object type 
            int empCount = (int)cmd.ExecuteScalar();    // Returns Single Value

            Console.WriteLine("Employee Count : " + empCount);
            conn.Close();


            Console.ReadLine(); // Waiting the command prompt 

        }
    }
}

