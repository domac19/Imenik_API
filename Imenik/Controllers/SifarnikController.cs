using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imenik_API.Controllers
{
    public class SifarnikController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
