using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Imenik.Authentication;

namespace Imenik.Model
{
    public class LoginModel
    {
        [Required (ErrorMessage = "Obavezan unos")]
        public string KorisnickoIme { get; set; }
        [Required (ErrorMessage = "Obavezan unos")]
        public string Lozinka { get; set; }
    }
}
