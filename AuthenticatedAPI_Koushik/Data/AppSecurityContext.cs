using Microsoft.AspNetCore.Identity;

namespace AuthenticatedAPI_Koushik.Data;

public class AppSecurityContext : IdentityDbContext<IdentityUser>
{
    public AppSecurityContext(DbContextoptions<AppSecurityContext> options)
    : base(options)
    {}
}

public class IdentityDbContext<T>
{
    private DbContextoptions<AppSecurityContext> options;

    public IdentityDbContext(DbContextoptions<AppSecurityContext> options)
    {
        this.options = options;
    }
}