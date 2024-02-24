using AuthenticatedAPI_Library;
using Microsoft.EntityFrameworkCore;

namespace AuthenticatedAPI_Koushik.Data;

public class AppDataContext(DbContextoptions<AppDataContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }
}

public class DbContextoptions<T>
{
}

public class DbContext
{
    private DbContextoptions<AppDataContext> options;

    public DbContext(DbContextoptions<AppDataContext> options)
    {
        this.options = options;
    }
}