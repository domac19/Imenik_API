using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imenik_API.Model
{
    public class Imenik
    {
        [Key]
        [Required]
        public int Id { get; set; }
        
        public string Ime { get; set; }
        
        public string Prezime { get; set; }
        
        public string Email { get; set; }
        
        public int Kontakt { get; set; }
        
        public DateTime DatumRodenja { get; set; }
        
        public string Grad { get; set; }
        
        public string Ulica { get; set; }
        
        public int KucniBroj { get; set; }
        
        public int SifarnikZupanijaId { get; set; }
        
        public int SifarnikDrzavaId { get; set; }

        public List<Drzava> Drzave { get; set; } = new List<Drzava> { new Drzava { Id = 1, PuniNaziv = "Republika Hrvatska", SkraceniNaziv = "RH", Oznaka = "EU" },
                                                                      new Drzava { Id = 2, PuniNaziv = "Kraljevina Danska", SkraceniNaziv = "KD", Oznaka = "EU" },
                                                                      new Drzava { Id = 3, PuniNaziv = "Republika Italija", SkraceniNaziv = "RI", Oznaka = "EU" },
                                                                      new Drzava { Id = 4, PuniNaziv = "Ujedinjeno Kraljevstvo", SkraceniNaziv = "UK", Oznaka = "" }};
        public List<DodatnaAdresa> DodatneAdrese { get; set; }
    }
}
