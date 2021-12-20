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