using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Imenik.Model;
using Imenik.Services;
using Microsoft.AspNetCore.Authorization;

namespace Imenik.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImenikController : ControllerBase
    {
        public ImenikController()
        {
        }

        //GET/api/Imenik
        [HttpGet]
        public ActionResult<List<Sifrarnik>> GetAll() => ImenikService.GetAll();

        [Authorize]
        //GET/api/Imenik/1
        [HttpGet("{id}")]
        public ActionResult<Sifrarnik> Get(int id)
        {
            var sifrarnik = ImenikService.Get(id);

            if (sifrarnik == null)
                return NotFound();

            return sifrarnik;
        }

        [Authorize]
        //PUT/api/Imenik/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, Sifrarnik sifrarnik)
        {
            if (id != sifrarnik.Id)
                return BadRequest();

            var contactExist = ImenikService.Get(id);

            if (contactExist == null)
                return NotFound();

            ImenikService.Update(sifrarnik);

            return NoContent();
        }

        [Authorize]
        //POST/api/Imenik
        [HttpPost]
        public IActionResult Create(Sifrarnik sifrarnik)
        {
            ImenikService.Add(sifrarnik);
            return CreatedAtAction(nameof(Create), new { id = sifrarnik.Id }, sifrarnik);
        }

        [Authorize]
        //DELETE/api/Imenik/5
        [HttpDelete("{id}")]
        public IActionResult DeleteSifrarnik(int id)
        {
            var sifarnik = ImenikService.Get(id);

            if (sifarnik == null)
                return NotFound();

            ImenikService.Delete(id);
            return NoContent();
        }
    }
}
