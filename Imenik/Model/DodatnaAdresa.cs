using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imenik_API.Model
{
    public class DodatnaAdresa
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Grad { get; set; }

        [Required]
        [StringLength(255)]
        public string Ulica { get; set; }

        [Required]
        public int KucniBroj { get; set; }

        [Required]
        public int Kontakt { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [Display(Name = "SifarnikZupanijaId")]
        public int SifarnikZupanijaId { get; set; }

        [Display(Name = "SifarnikDrzavaId")]
        public int SifarnikDrzavaId { get; set; }

        [ForeignKey("ImenikSifarnikDrzava")]
        public ImenikSifarnikDrzava Drzave { get; set; }

        
        [ForeignKey("ImenikSifarnikZupanija")]
        public ImenikSifarnikZupanija Zupanije { get; set; }

        [Display(Name = "ImenikId")]
        public int ImenikId { get; set; }

        [ForeignKey("Imenik")]
        public Imenik Imenici { get; set; }
    }
}
