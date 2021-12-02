using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Imenik.Model;
using Imenik.Authentication;

namespace Imenik.Context
{
    public class ApiContext : IdentityDbContext<ApplicationUser>
    {
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        { 
        }
        public DbSet<Sifrarnik> Sifrarnici { get; set; }
        public DbSet<Drzava> Drzave { get; set; }
        public DbSet<Zupanija> Zupanije { get; set; }        
    }
}
