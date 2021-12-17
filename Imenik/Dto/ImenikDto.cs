using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Imenik_API.Model;

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

        [Required]
        [StringLength(255)]
        public string Grad { get; set; }

        [Required]
        [StringLength(255)]
        public string Ulica { get; set; }

        [Required]
        public int KucniBroj { get; set; }

        public int SifarnikZupanijaId { get; set; }

        public int SifarnikDrzavaId { get; set; }
        public List<DodatnaAdresa> DodatneAdrese { get; set; }

        public List<ImenikSifarnikDrzava> Drzave { get; set; }
    }
}
