using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imenik_API.Model
{
    public class Imenik
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Ime { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Prezime { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        public int Kontakt { get; set; }
        
        [Required]
        public DateTime? DatumRodenja { get; set; }

        [Required]
        [StringLength(255)]
        public string Grad { get; set; }

        [Required]
        [StringLength(255)]
        public string Ulica { get; set; }
        
        [Required]
        public int KucniBroj { get; set; }

        public DodatnaAdresa DodatneAdrese { get; set; }

        [Display(Name = "SifarnikZupanijaId")]
        public int SifarnikZupanijaId { get; set; }
        
        [Display(Name = "SifarnikDrzavaId")]
        public int SifarnikDrzavaId { get; set; }
        
        [ForeignKey("ImenikSifarnikDrzava")]
        public ImenikSifarnikDrzava Drzave { get; set; }
        
        [ForeignKey("ImenikSifarnikZupanija")]
        public ImenikSifarnikZupanija Zupanije { get; set; }
    }
}
