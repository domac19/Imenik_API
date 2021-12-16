using System;
using System.ComponentModel.DataAnnotations;

namespace Imenik_API.Model
{
    public class ImenikSifarnikZupanija
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string PuniNaziv { get; set; }

        [Required]
        [StringLength(50)]
        public string SkraceniNaziv { get; set; }

        [Required]
        [StringLength(100)]
        public string PozivniBrojZupanije { get; set; }
        
        public int DrzavaId { get; set; }
        
        public Imenik Sifrarnik { get; set; }
    }
}
