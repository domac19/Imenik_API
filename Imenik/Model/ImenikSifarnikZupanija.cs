using System;
namespace Imenik_API.Model
{
    public class ImenikSifarnikZupanija
    {
        public int Id { get; set; }
        public string PuniNaziv { get; set; }
        public string SkraceniNaziv { get; set; }
        public string PozivniBrojZupanije { get; set; }
        public int DrzavaId { get; set; }
        public Imenik Sifrarnik { get; set; }
    }
}
