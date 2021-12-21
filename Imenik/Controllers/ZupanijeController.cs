using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Imenik_API.Model;
using Imenik_API.Context;
using System.Linq;
using Imenik_API.Dto;

namespace Imenik_API.Controllers
{
    [Route("api/SifarnikZupanije")]
    public class ZupanijeController : Controller
    {
        private ApiContext _apiContext { get; set; }
        public ZupanijeController(ApiContext apiContext)
        {
            _apiContext = apiContext;
        }

        //GET/api/Sifarnik/ImenikSifarnikZupanija
        [HttpGet]
        public IActionResult GetAllZupanije()
        {
            var drzaveDto = _apiContext.ImenikSifarnikZupanije.ToList().Select(Mapper.Map<ImenikSifarnikZupanija, SifarnikDrzavaDto>);
            return Ok(drzaveDto);
        }
    }
}
