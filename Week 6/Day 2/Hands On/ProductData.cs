using Microsoft.Data.SqlClient;
using System.Collections.Generic;

public class ProductData
{
    private string connectionString = "Server=BHARATH\\SQLEXPRESS;Database=BookDB;Integrated Security=true;TrustServerCertificate=True";

    public void InsertProduct(Product product)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("sp_InsertProduct", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
            cmd.Parameters.AddWithValue("@Category", product.Category);
            cmd.Parameters.AddWithValue("@Price", product.Price);

            con.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public List<Product> GetAllProducts()
    {
        List<Product> list = new List<Product>();

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("sp_GetAllProducts", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Product
                {
                    ProductId = (int)reader["ProductId"],
                    ProductName = reader["ProductName"].ToString() ?? "",
                    Category = reader["Category"].ToString() ?? "",
                    Price = (decimal)reader["Price"]
                });
            }
        }

        return list;
    }

    public void UpdateProduct(Product product)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("sp_UpdateProduct", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ProductId", product.ProductId);
            cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
            cmd.Parameters.AddWithValue("@Category", product.Category);
            cmd.Parameters.AddWithValue("@Price", product.Price);

            con.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public void DeleteProduct(int id)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("sp_DeleteProduct", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ProductId", id);

            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}