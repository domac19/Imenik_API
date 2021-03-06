using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Imenik_API.Model;
using Imenik_API.Context;
using System.Linq;
using Imenik_API.Dto;

namespace Imenik_API.Controllers
{
    [Route("api/SifarnikDrzave")]
    public class DrzaveController : Controller
    {
        private ApiContext _apiContext { get; set; }
        public DrzaveController(ApiContext apiContext)
        {
            _apiContext = apiContext;
        }

        //GET/api/Sifarnik/ImenikSifarnikDrzave
        [HttpGet]
        public IActionResult GetAllDrzave()
        {
            var drzaveDto = _apiContext.ImenikSifarnikDrzave.ToList().Select(Mapper.Map<ImenikSifarnikDrzava, SifarnikDrzavaDto>);
            return Ok(drzaveDto);
        }
    }
}