using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imenik_API.Dto
{
    public class ImenikDto
    {
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

        public DodatnaAdresaDto DodatneAdrese { get; set; }

        [Display(Name = "SifarnikZupanijaId")]
        public int SifarnikZupanijaId { get; set; }

        [Display(Name = "SifarnikDrzavaId")]
        public int SifarnikDrzavaId { get; set; }
        
    }
}
