using Imenik_API.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Imenik_API.Dto
{
    public class SifarnikDrzavaDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string PuniNaziv { get; set; }

        [Required]
        [StringLength(50)]
        public string SkraceniNaziv { get; set; }

        [Required]
        [StringLength(20)]
        public string Oznaka { get; set; }
       
    }
}
