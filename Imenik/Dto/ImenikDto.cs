using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Imenik_API.Model;

namespace Imenik_API.Dto
{
    public class ImenikDto
    {
        public int Id { get; set; }

        public int SifarnikZupanijaId { get; set; }

        public int SifarnikDrzavaId { get; set; }
        
    }
}
