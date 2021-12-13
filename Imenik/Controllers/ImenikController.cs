﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Imenik_API.Model;
using Imenik_API.Services;
using Microsoft.AspNetCore.Authorization;

namespace Imenik_API.Controllers
{
    [Route("api/Imenik")]
    [ApiController]
    public class ImenikController : ControllerBase
    {
        public ImenikController()
        {

        }
        //GET/api/Imenik
        [HttpGet]
        public ActionResult<List<Imenik>> GetAll() => ImenikService.GetAll();

        [Authorize]
        //GET/api/Imenik/1
        [HttpGet("{id}")]
        public ActionResult<Imenik> Get(int id)
        {
            var sifrarnik = ImenikService.Get(id);

            if (sifrarnik == null)
                return NotFound();

            return sifrarnik;
        }

        [Authorize]
        //PUT/api/Imenik/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, Imenik sifrarnik)
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
        public IActionResult Create(Imenik sifrarnik)
        {
            ImenikService.Add(sifrarnik);
            return CreatedAtAction(nameof(Create), new { id = sifrarnik.Id, name = sifrarnik.Ime }, sifrarnik);
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
