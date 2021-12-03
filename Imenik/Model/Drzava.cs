using System;
using System.Collections.Generic;
namespace Imenik.Model
{
    public class Drzava
    {
        public int Id { get; set; }
        public string PuniNaziv { get; set; }
        public string SkraceniNaziv { get; set; }
        public string Oznaka { get; set; }
        public List<Zupanija> Zupanije { get; set; } = new List<Zupanija> { new Zupanija { Id = 1, PuniNaziv = "Grad Zagreb", SkraceniNaziv = "GZ", PozivniBrojZupanije = "+385", DrzavaId = 1 },
                                                                            new Zupanija { Id = 2, PuniNaziv = "Opcina Copenhagen", SkraceniNaziv = "OC", PozivniBrojZupanije = "+312", DrzavaId = 2},
                                                                            new Zupanija { Id = 3, PuniNaziv = "Sicilija", SkraceniNaziv = "SC", PozivniBrojZupanije = "+320", DrzavaId = 3 },
                                                                            new Zupanija { Id = 4, PuniNaziv = "England", SkraceniNaziv = "EN", PozivniBrojZupanije = "+011", DrzavaId = 4}};
    }
}
