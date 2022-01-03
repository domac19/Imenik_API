using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imenik_API.Model
{
    public class ImenikSifarnikZupanija
    {
        [Key]
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

        [ForeignKey(nameof(ImenikSifarnikDrzava))]
        public int DrzavaId { get; set; }

        public ImenikSifarnikDrzava Drzava { get; set; }
        
    }
}
