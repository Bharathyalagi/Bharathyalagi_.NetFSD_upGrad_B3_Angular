using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAccessLayer;

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