using AutoMapper;
using System;
using Imenik_API.Dto;
using Microsoft.AspNetCore.Mvc;
using Imenik_API.Model;
using Microsoft.AspNetCore.Authorization;
using Imenik_API.Context;
using System.Linq;
using System.Data.Entity;

namespace Imenik_API.Controllers
{
    [Route("api/Imenik")]
    [ApiController]
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
            var imenikDto = _apiContext.Imenici.Include(d => d.DodatneAdrese).ToList().Select(Mapper.Map<Imenik, ImenikDto>);
            return Ok(imenikDto);
        }

        //GET/api/Imenik/1
        [HttpGet("{id}")]
        public ImenikDto GetImenik(int id)
        {
            var imenik = _apiContext.Imenici.SingleOrDefault(i => i.Id == id); 

            if (imenik == null)
                throw new Exception();

             return Mapper.Map<Imenik, ImenikDto>(imenik); 
        }
        [Authorize]
        //PUT/api/Imenik/5
        [HttpPut("{id}")]
        public void UpdateImenik(int id, [FromBody] ImenikDto imenikDto)
        {
            if (id != imenikDto.Id)
                throw new Exception();

            var contactExist = _apiContext.Imenici.SingleOrDefault(i => i.Id == id);

            if (contactExist == null)
                throw new Exception();

            Mapper.Map(imenikDto, contactExist);

            _apiContext.SaveChanges();
        }

        [Authorize]
        //POST/api/Imenik
        [HttpPost]
        public ImenikDto CreateImenik([FromBody] ImenikDto imenikDto)
        {
            var sifarnik = Mapper.Map<ImenikDto, Imenik>(imenikDto);

            _apiContext.Imenici.Add(sifarnik);
            _apiContext.SaveChanges();

            imenikDto.Id = sifarnik.Id;

            return imenikDto;
        }

        [Authorize]
        //DELETE/api/Imenik/5
        [HttpDelete("{id}")]
        public void DeleteSifrarnik(int id)
        {
            var imenik = _apiContext.Imenici.SingleOrDefault(i => i.Id == id);

            if (imenik == null)
                throw new Exception();

            _apiContext.Imenici.Remove(imenik);
            _apiContext.SaveChanges();
        }
    }
}
