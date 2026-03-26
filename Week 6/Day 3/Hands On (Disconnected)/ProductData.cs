using Microsoft.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

public class ProductData
{
    private string connectionString = "Server=BHARATH\\SQLEXPRESS;Database=BookDB;Integrated Security=true;TrustServerCertificate=True";

    public DataTable GetAllProducts()
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Products", con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }

    public void InsertProduct(Product product)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Products", con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            DataRow row = dt.NewRow();
            row["ProductName"] = product.ProductName;
            row["Category"] = product.Category;
            row["Price"] = product.Price;

            dt.Rows.Add(row);

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(dt);
        }
    }

    public void UpdateProduct(Product product)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Products", con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                if ((int)row["ProductId"] == product.ProductId)
                {
                    row["ProductName"] = product.ProductName;
                    row["Category"] = product.Category;
                    row["Price"] = product.Price;
                }
            }

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(dt);
        }
    }

    public void DeleteProduct(int id)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Products", con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                if ((int)row["ProductId"] == id)
                {
                    row.Delete();
                }
            }

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(dt);
        }
    }
}