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
        
        [Display(Name = "ImenikSifarnikDrzava")]
        public int DrzavaId { get; set; }

        [ForeignKey("DrzavaId")]
        public ImenikSifarnikDrzava Drzave { get; set; }
        
    }
}
