using AuthenticatedAPI_Library;
using Microsoft.EntityFrameworkCore;

namespace AuthenticatedAPI_Koushik.Data;

public class AppDataContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    
    public AppDataContext(DbContextOptions<AppDataContext> options)
        : base(options)
        {}
}