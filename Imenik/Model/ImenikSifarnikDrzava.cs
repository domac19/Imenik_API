using System;
using System.Collections.Generic;
namespace Imenik_API.Model
{
    public class ImenikSifarnikDrzava
    {
        public int Id { get; set; }
        public string PuniNaziv { get; set; }
        public string SkraceniNaziv { get; set; }
        public string Oznaka { get; set; }
        public List<ImenikSifarnikZupanija> Zupanije { get; set; }/* = new List<Zupanija> { new Zupanija { Id = 6, PuniNaziv = "Grad Zagreb", SkraceniNaziv = "GZ", PozivniBrojZupanije = "+385", DrzavaId = 1 },
                                                                            new Zupanija { Id = 7, PuniNaziv = "Opcina Copenhagen", SkraceniNaziv = "OC", PozivniBrojZupanije = "+312", DrzavaId = 2},
                                                                            new Zupanija { Id = 8, PuniNaziv = "Sicilija", SkraceniNaziv = "SC", PozivniBrojZupanije = "+320", DrzavaId = 3 },
                                                                            new Zupanija { Id = 9, PuniNaziv = "England", SkraceniNaziv = "EN", PozivniBrojZupanije = "+011", DrzavaId = 4}};*/
    }
}
