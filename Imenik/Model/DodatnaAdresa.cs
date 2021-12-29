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

        [ForeignKey("ImenikSifarnikZupanija")]
        [Display(Name = "SifarnikZupanijaId")]
        public int SifarnikZupanijaId { get; set; }

        [ForeignKey("ImenikSifarnikDrzava")]
        [Display(Name = "SifarnikDrzavaId")]
        public int SifarnikDrzavaId { get; set; }

        public ImenikSifarnikDrzava Drzave { get; set; }

        public ImenikSifarnikZupanija Zupanije { get; set; }

        [ForeignKey("Imenik")]
        [Display(Name = "ImenikId")]
        public int ImenikId { get; set; }

        public Imenik Imenici { get; set; }
    }
}
