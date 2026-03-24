
using Microsoft.Data.SqlClient;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connStr = "Server=BHARATH\\SQLEXPRESS; Database=Apr2025Db; Integrated Security=true; TrustServerCertificate=True";

            SqlConnection con = new SqlConnection(connStr);


            string cmdText = "DELETE FROM Students WHERE StudentID=3";
            SqlCommand cmd = new SqlCommand(cmdText, con);  


            con.Open();
            int n = cmd.ExecuteNonQuery();

            Console.WriteLine("Connected to SQL Server");
            Console.WriteLine("No. of Rows affected : " + n);

            con.Close();

            Console.ReadLine();
        }
    }
}
