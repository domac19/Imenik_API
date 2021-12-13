using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Imenik_API.Model;
using Imenik_API.Authentication;

namespace Imenik_API.Context
{
    public class ApiContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Imenik> Sifrarnici { get; set; }
        public DbSet<Drzava> Drzave { get; set; }
        public DbSet<Zupanija> Zupanije { get; set; }
        public DbSet<DodatnaAdresa> DodatnaAdresa { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        { 
        }
    }
}
