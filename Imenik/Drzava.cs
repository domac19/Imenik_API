using Imenik_API.Context;
using Imenik_API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Imenik_API
{
    public partial class Drzava
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var dbContext = new ApiContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApiContext>>()))
            {
                if (dbContext.ImenikSifarnikDrzave.Any())
                {
                    return;
                }
                dbContext.ImenikSifarnikDrzave.AddRange(
                        new ImenikSifarnikDrzava 
                        { Id = 1, 
                          PuniNaziv = "Republika Hrvatska", 
                          SkraceniNaziv = "RH", 
                          Oznaka = "EU" },

                        new ImenikSifarnikDrzava 
                        { Id = 2, 
                          PuniNaziv = "Kraljevina Danska", 
                          SkraceniNaziv = "KD", 
                          Oznaka = "EU" },
                        
                        new ImenikSifarnikDrzava 
                        { Id = 3, 
                          PuniNaziv = "Republika Italija", 
                          SkraceniNaziv = "RI", 
                          Oznaka = "EU" },
                        
                        new ImenikSifarnikDrzava 
                        { Id = 4, 
                          PuniNaziv = "Ujedinjeno Kraljevstvo", 
                          SkraceniNaziv = "UK", 
                          Oznaka = "" });

                dbContext.SaveChanges();
            }
        }
    }
}
