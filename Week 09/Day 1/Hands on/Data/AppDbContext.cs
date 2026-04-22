using Microsoft.EntityFrameworkCore;
using ContactManagement.Models;

namespace ContactManagement.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Contact> Contacts { get; set; }
    public DbSet<UserInfo> Users { get; set; }
}