using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Imenik.Model;
using Imenik.Authentication;

namespace Imenik.Context
{
    public class ApiContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Model.Imenik> Sifrarnici { get; set; }
        public DbSet<Drzava> Drzave { get; set; }
        public DbSet<Zupanija> Zupanije { get; set; }
        public DbSet<DodatnaAdresa> DodatnaAdresa { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        { 
        }
    }
}
