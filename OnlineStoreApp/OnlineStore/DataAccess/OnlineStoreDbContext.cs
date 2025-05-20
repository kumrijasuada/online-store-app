using Microsoft.EntityFrameworkCore;
using OnlineStore.Application.Models;

namespace OnlineStore.DataAccess;

public class OnlineStoreDbContext : DbContext
{
    public OnlineStoreDbContext() : base()
    {}

    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-SCU8G2F\SQLEXPRESS;Initial Catalog=OnlineStoreDb;Trusted_Connection=True;TrustServerCertificate=true;");
    }
}
