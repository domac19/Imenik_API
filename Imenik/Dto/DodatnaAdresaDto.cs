using System.ComponentModel.DataAnnotations;

namespace Imenik_API.Dto
{
    public class DodatnaAdresaDto
    {
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
        public string Kontakt { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        public int SifarnikZupanijaId { get; set; }

        public int SifarnikDrzavaId { get; set; }

        public int ImenikId { get; set; }
    }
}
