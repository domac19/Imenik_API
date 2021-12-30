using Imenik_API.Context;
using Imenik_API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Imenik_API
{
    public partial class ImenikData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var dbContext = new ApiContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApiContext>>()))
            {
                if (dbContext.Imenici.Any() && dbContext.DodatneAdrese.Any())
                {
                    return;
                }
                dbContext.Imenici.AddRange(
                     new Imenik
                     {
                         Id = 1,
                         Ime = "Domagoj",
                         Prezime = "Licitar",
                         Email = "licitar.domagoj@gmail.com",
                         Kontakt = "12345",
                         DatumRodenja = new DateTime(1996, 03, 19),
                         Grad = "Petrinja",
                         Ulica = "Artura Turkulina",
                         KucniBroj = 28,
                         SifarnikZupanijaId = 10,
                         SifarnikDrzavaId = 1
                     },
                        new Imenik
                        {
                            Id = 2,
                            Ime = "Pero",
                            Prezime = "Perić",
                            Email = "peric123@gmail.com",
                            Kontakt = "51388",
                            DatumRodenja = new DateTime(1969, 04, 07),
                            Grad = "Osijek",
                            Ulica = "Mate Lovraka",
                            KucniBroj = 44,
                            SifarnikZupanijaId = 5,
                            SifarnikDrzavaId = 2
                        },
                        new Imenik
                        {
                            Id = 3,
                            Ime = "Luka",
                            Prezime = "Radić",
                            Email = "radicluk1@gmail.com",
                            Kontakt = "99142",
                            DatumRodenja = new DateTime(1966, 07, 12),
                            Grad = "Popovača",
                            Ulica = "Luke Lukovića",
                            KucniBroj = 32,
                            SifarnikZupanijaId = 10,
                            SifarnikDrzavaId = 3
                        },
                        new Imenik
                        {
                            Id = 4,
                            Ime = "Hrvoje",
                            Prezime = "Hrlić",
                            Email = "hhrlic122@gmail.com",
                            Kontakt = "84127",
                            DatumRodenja = new DateTime(1999, 02, 15),
                            Grad = "Zagreb",
                            Ulica = "Stjepana Radića",
                            KucniBroj = 12,
                            SifarnikZupanijaId = 1,
                            SifarnikDrzavaId = 4
                        });

                dbContext.DodatneAdrese.Add(new DodatnaAdresa
                {
                    Id = 1,
                    Grad = "Zagreb",
                    Ulica = "Augusta Šenoe",
                    KucniBroj = 3,
                    Kontakt = "3851119103",
                    Email = null,
                    SifarnikDrzavaId = 1,
                    SifarnikZupanijaId = 1,
                    ImenikId = 1
                });
                dbContext.SaveChanges();
            }
        }
    }
}
