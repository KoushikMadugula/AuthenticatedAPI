using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AuthenticatedAPI_Koushik.Data;

public class AppSecurityContext : IdentityDbContext<IdentityUser>
{
    public  AppSecurityContext(DbContextOptions<AppSecurityContext> options)
     : base(options)
     {}
}