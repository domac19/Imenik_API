using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Imenik.Context;
using Imenik.Authentication;

namespace Imenik.Model
{
    public class RegisterModel
    {
        [Required (ErrorMessage = "Korisničko ime je obavezno")]
        public string KorisnickoIme { get; set; }
        [Required (ErrorMessage = "Lozinka je obavezna")]
        public string Lozinka { get; set; }
    }
}
