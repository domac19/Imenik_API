using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imenik.Controllers
{
    public class ImenikController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
