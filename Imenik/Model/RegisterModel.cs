using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Imenik_API.Context;
using Imenik_API.Authentication;

namespace Imenik_API.Model
{
    public class RegisterModel
    {
        [Required (ErrorMessage = "Korisničko ime je obavezno")]
        public string KorisnickoIme { get; set; }
        
        [Required (ErrorMessage = "Lozinka je obavezna")]
        public string Lozinka { get; set; }
    }
}
