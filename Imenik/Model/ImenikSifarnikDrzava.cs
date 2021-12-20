using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Imenik_API.Model
{
    public class ImenikSifarnikDrzava
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
        [StringLength(20)]
        public string Oznaka { get; set; }
        
    }
}
