using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Imenik.Model;

namespace Imenik.Services
{
    public static class ImenikService
    {
        static List<Model.Imenik> Sifrarniks { get; }
        static int nextId = 3;
        static ImenikService()
        {
            Sifrarniks = new List<Model.Imenik>
        {
            new Model.Imenik { Id = 1, 
                            Ime = "Domagoj", 
                            Prezime = "Licitar", 
                            Email = "licitar.domagoj@gmail.com", 
                            Kontakt = 12345, 
                            DatumRodenja = new DateTime(), 
                            Grad = "Petrinja", 
                            Ulica = "Artura Turkulina", 
                            KucniBroj = 28, 
                            SifarnikZupanijaId = 10, 
                            SifarnikDrzavaId = 1 },
            new Model.Imenik { Id = 2,
                            Ime = "Pero",
                            Prezime = "Perić",
                            Email = "peric123@gmail.com",
                            Kontakt = 51388,
                            DatumRodenja = new DateTime(),
                            Grad = "Osijek",
                            Ulica = "Mate Lovraka",
                            KucniBroj = 44,
                            SifarnikZupanijaId = 5,
                            SifarnikDrzavaId = 1 },
            new Model.Imenik { Id = 3,
                            Ime = "Luka",
                            Prezime = "Radić",
                            Email = "radicluk1@gmail.com",
                            Kontakt = 99142,
                            DatumRodenja = new DateTime(),
                            Grad = "Popovača",
                            Ulica = "Luke Lukovića",
                            KucniBroj = 32,
                            SifarnikZupanijaId = 10,
                            SifarnikDrzavaId = 1 },
            new Model.Imenik { Id = 4,
                            Ime = "Hrvoje",
                            Prezime = "Hrlić",
                            Email = "hhrlic122@gmail.com",
                            Kontakt = 84127,
                            DatumRodenja = new DateTime(),
                            Grad = "Zagreb",
                            Ulica = "Stjepana Radića",
                            KucniBroj = 12,
                            SifarnikZupanijaId = 1,
                            SifarnikDrzavaId = 1 }
                };
        }

        public static List<Model.Imenik> GetAll() => Sifrarniks;

        public static Model.Imenik? Get(int id) => Sifrarniks.FirstOrDefault(p => p.Id == id);

        public static void Add(Model.Imenik sifrarnik)
        {
            sifrarnik.Id = nextId++;
            Sifrarniks.Add(sifrarnik);
        }

        public static void Delete(int id)
        {
            var sifrarnik = Get(id);
            if (sifrarnik is null)
                return;

            Sifrarniks.Remove(sifrarnik);
        }

        public static void Update(Model.Imenik sifrarnik)
        {
            var index = Sifrarniks.FindIndex(p => p.Id == sifrarnik.Id);
            if (index == -1)
                return;

            Sifrarniks[index] = sifrarnik;
        }
    }
}
