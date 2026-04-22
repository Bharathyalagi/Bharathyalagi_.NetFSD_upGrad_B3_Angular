using Dapper;
using Microsoft.Data.SqlClient;
using WebApplication24.Models;

public class ProductRepository : IProductRepository
{
    private readonly string _connStr;

    public ProductRepository(IConfiguration config)
    {
        _connStr = config.GetConnectionString("DefaultConnection")!;
    }

    private SqlConnection GetConnection()
    {
        return new SqlConnection(_connStr);
    }

    public IEnumerable<Product> GetAll()
    {
        using var db = GetConnection();
        return db.Query<Product>("SELECT * FROM Products");
    }

    public Product GetById(int id)
    {
        using var db = GetConnection();
        return db.QueryFirstOrDefault<Product>(
            "SELECT * FROM Products WHERE Id=@Id",
            new { Id = id });
    }

    public void Add(Product product)
    {
        using var db = GetConnection();
        db.Execute(
            "INSERT INTO Products (Name, Price, Category) VALUES (@Name,@Price,@Category)",
            product);
    }

    public void Update(Product product)
    {
        using var db = GetConnection();
        db.Execute(
            "UPDATE Products SET Name=@Name, Price=@Price, Category=@Category WHERE Id=@Id",
            product);
    }

    public void Delete(int id)
    {
        using var db = GetConnection();
        db.Execute(
            "DELETE FROM Products WHERE Id=@Id",
            new { Id = id });
    }
}