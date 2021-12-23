using Imenik_API.Model;
using System.ComponentModel.DataAnnotations;

namespace Imenik_API.Dto
{
    public class SifarnikZupanijaDto
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

        public Imenik Imenik { get; set; }
    }
}
