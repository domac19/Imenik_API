using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Imenik.Model
{
    public class Imenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public int Kontakt { get; set; }
        public DateTime DatumRodenja { get; set; }
        public string Grad { get; set; }
        public string Ulica { get; set; }
        public int KucniBroj { get; set; }
        public int SifarnikZupanijaId { get; set; }
        public int SifarnikDrzavaId { get; set; }
    }
}
