using System;
using System.Collections.Generic;
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
        public string Kontakt { get; set; }
        
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

        public List<DodatnaAdresa> DodatneAdrese { get; set; }

        [ForeignKey(nameof(ImenikSifarnikZupanija))]
        public int SifarnikZupanijaId { get; set; }

        [ForeignKey(nameof(ImenikSifarnikDrzava))]
        public int SifarnikDrzavaId { get; set; }
        
        public ImenikSifarnikDrzava Drzava { get; set; }
        
        public ImenikSifarnikZupanija Zupanija { get; set; }
    }
}
