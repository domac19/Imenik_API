using System;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Imenik_API.Model;
using Microsoft.AspNetCore.Authorization;
using Imenik_API.Context;
using System.Linq;
using System.Net;
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
        public IActionResult GetAllDrzave()
        {
            var sifarnikDrzave = _apiContext.ImenikSifarnikZupanije.ToList();

            var drzaveDto = sifarnikDrzave.ToList().Select(Mapper.Map<ImenikSifarnikZupanija, SifarnikDrzavaDto>);
            return Ok(sifarnikDrzave);
        }
    }
}
