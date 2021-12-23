using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Imenik_API.Model;
using Imenik_API.Authentication;

namespace Imenik_API.Context
{
    public class ApiContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Imenik> Imenici { get; set; }
        public DbSet<ImenikSifarnikDrzava> ImenikSifarnikDrzave { get; set; }
        public DbSet<ImenikSifarnikZupanija> ImenikSifarnikZupanije { get; set; }
        public DbSet<DodatnaAdresa> DodatneAdrese { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        { 
        }
    }
}
