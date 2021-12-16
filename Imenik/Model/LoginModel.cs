using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Imenik_API.Authentication;

namespace Imenik_API.Model
{
    public class LoginModel
    {
        [Required (ErrorMessage = "Obavezan unos")]
        public string KorisnickoIme { get; set; }
        
        [Required (ErrorMessage = "Obavezan unos")]
        public string Lozinka { get; set; }
    }
}
