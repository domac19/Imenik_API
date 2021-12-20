using AutoMapper;
using System;
using Imenik_API.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Imenik_API.Model;
using Microsoft.AspNetCore.Authorization;
using Imenik_API.Context;
using System.Linq;
using System.Net;
using System.Data.Entity;

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

            var sifarnikDto = sifarnik.ToList().Select(Mapper.Map<Imenik, ImenikDto>);
            return Ok(sifarnikDto);
        }
        
        [Authorize]
        //GET/api/Imenik/1
        [HttpGet("{id}")]
        public ImenikDto GetImenik(int id)
        {
            var sifrarnik = _apiContext.Sifrarnici.SingleOrDefault(i => i.Id == id);

            if (sifrarnik == null)
                throw new Exception();

            return Mapper.Map<Imenik, ImenikDto>(sifrarnik);
        }

        [Authorize]
        //PUT/api/Imenik/5
        [HttpPut("{id}")]
        public void UpdateImenik(int id, ImenikDto sifrarnikDto)
        {
            if (id != sifrarnikDto.Id)
                throw new Exception();

            var contactExist = _apiContext.Sifrarnici.SingleOrDefault(i => i.Id == id);

            if (contactExist == null)
                throw new Exception();

            Mapper.Map(sifrarnikDto, contactExist);

            _apiContext.SaveChanges();
        }

        [Authorize]
        //POST/api/Imenik
        [HttpPost]
        public ImenikDto CreateImenik(ImenikDto sifrarnikDto)
        {
            var sifarnik = Mapper.Map<ImenikDto, Imenik>(sifrarnikDto);

            _apiContext.Sifrarnici.Add(sifarnik);
            _apiContext.SaveChanges();

            sifrarnikDto.Id = sifarnik.Id;

            return sifrarnikDto;
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
