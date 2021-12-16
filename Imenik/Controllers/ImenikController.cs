using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Imenik_API.Model;
using Microsoft.AspNetCore.Authorization;
using Imenik_API.Context;
using System.Linq;
using System.Net;

namespace Imenik_API.Controllers
{
    [Route("api/Imenik")]
    public class ImenikController : Controller
    {
        private ApiContext _apiContext { get; set; }
        public ImenikController(ApiContext apiContext)
        {
            _apiContext = apiContext;
        }
        //GET/api/Imenik
        [HttpGet]
        public IActionResult GetAllImenik()
        {
            var sifarnik = _apiContext.Sifrarnici.ToList();
            return Ok(sifarnik);
        }
        
        [Authorize]
        //GET/api/Imenik/1
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var sifrarnik = _apiContext.Sifrarnici.SingleOrDefault(i => i.Id == id);

            if (sifrarnik == null)
                return NotFound();

            return Ok(sifrarnik);
        }

        [Authorize]
        //PUT/api/Imenik/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, Imenik sifrarnik)
        {
            if (id != sifrarnik.Id)
                return BadRequest();

            var contactExist = _apiContext.Sifrarnici.SingleOrDefault(i => i.Id == id);

            if (contactExist == null)
                return NotFound();

            _apiContext.Sifrarnici.Update(sifrarnik);

            return NoContent();
        }

        [Authorize]
        //POST/api/Imenik
        [HttpPost]
        public IActionResult Create(Imenik sifrarnik)
        {
            _apiContext.Sifrarnici.Add(sifrarnik);
            return CreatedAtAction(nameof(Create), new { id = sifrarnik.Id, name = sifrarnik.Ime }, sifrarnik);
        }

        [Authorize]
        //DELETE/api/Imenik/5
        [HttpDelete("{id}")]
        public void DeleteSifrarnik(int id)
        {
            var sifarnik = _apiContext.Sifrarnici.SingleOrDefault(i => i.Id == id);

            if (sifarnik == null)
                throw new Exception();

            _apiContext.Sifrarnici.Remove(sifarnik);
            _apiContext.SaveChanges();
        }
    }
}
