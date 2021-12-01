using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Imenik.Model;

namespace Imenik.Context
{
    public class ApiContext : DbContext
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
