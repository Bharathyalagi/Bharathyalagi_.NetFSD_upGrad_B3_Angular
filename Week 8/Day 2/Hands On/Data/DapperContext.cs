using Microsoft.Data.SqlClient;
using System.Data;

namespace WebApplication8._2.Data;

public class DapperContext
{
    private readonly string _connStr;

    public DapperContext(IConfiguration config)
    {
        _connStr = config.GetConnectionString("DefaultConnection")!;
    }

    public IDbConnection CreateConnection()
    {
        return new SqlConnection(_connStr);
    }
}