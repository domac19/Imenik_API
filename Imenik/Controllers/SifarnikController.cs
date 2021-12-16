﻿using System;
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
    [Route("api/Sifarnik")]
    public class SifarnikController : Controller
    {
        private ApiContext _apiContext { get; set; }
        public SifarnikController(ApiContext apiContext)
        {
            _apiContext = apiContext;
        }
        //GET/api/Sifarnik
        [HttpGet]
        public IActionResult GetAllSifarnik()
        {
            var sifarnik = _apiContext.Sifrarnici.ToList();
            return Ok(sifarnik);
        }
    }
}
