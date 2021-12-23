using System.ComponentModel.DataAnnotations;

namespace Imenik_API.Dto
{
    public class DodatnaAdresaDto
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
    }
}
