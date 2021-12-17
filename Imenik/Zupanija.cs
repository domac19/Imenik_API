using Imenik_API.Context;
using Imenik_API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Imenik_API
{
    public partial class Zupanija
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var dbContext = new ApiContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApiContext>>()))
            {
                if (dbContext.ImenikSifarnikZupanije.Any())
                {
                    return;
                }
                dbContext.ImenikSifarnikZupanije.AddRange(

                            new ImenikSifarnikZupanija
                                { Id = 6, 
                                  PuniNaziv = "Grad Zagreb", 
                                  SkraceniNaziv = "GZ", 
                                  PozivniBrojZupanije = "+385", 
                                  DrzavaId = 1 },

                            new ImenikSifarnikZupanija 
                                { Id = 7, 
                                  PuniNaziv = "Opcina Copenhagen", 
                                  SkraceniNaziv = "OC", 
                                  PozivniBrojZupanije = "+312", 
                                  DrzavaId = 2 },

                            new ImenikSifarnikZupanija 
                                { Id = 8, 
                                  PuniNaziv = "Sicilija", 
                                  SkraceniNaziv = "SC", 
                                  PozivniBrojZupanije = "+320", 
                                  DrzavaId = 3 },

                            new ImenikSifarnikZupanija
                            {
                                Id = 9,
                                PuniNaziv = "England",
                                SkraceniNaziv = "EN",
                                PozivniBrojZupanije = "+011",
                                DrzavaId = 4
                            });
                
                dbContext.SaveChanges();
            }
        }
    }
}
