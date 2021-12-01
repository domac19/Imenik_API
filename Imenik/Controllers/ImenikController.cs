using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Imenik.Model;

namespace Imenik.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImenikController : ControllerBase
    {
        private readonly ILogger<ImenikController> _logger;
        public ImenikController(ILogger<ImenikController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<Drzava> GetDrzava()
        {
            var rng = new Random();
            return Enumerable.Range(1, 1).Select(index => new Drzava
            {
                Id = 1,
                PuniNaziv = "Južnoafrička republika",
                SkraceniNaziv = "JAR",
                Oznaka = 1
            })
            .ToArray();
        }
    }
}
