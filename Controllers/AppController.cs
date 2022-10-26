using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            
            //throw new InvalidProgramException("Bad things happend to good developers");
            return View();
        }

        [HttpGet("contact")]

        public IActionResult Contact()
        {
            //throw new InvalidOperationException("Bad things happend to good developers");

            return View();
        }

        [HttpPost("contact")]

        public IActionResult Contact(object model)
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";

            return View();
        }


    }
}
