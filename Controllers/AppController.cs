using DutchTreat.Data;
using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        private readonly DutchContext _context;

        public AppController(IMailService mailService/**/, DutchContext context)
        {
            _mailService = mailService;
            //_context = context;
        }
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

        public IActionResult Contact(ContactViewModel model)
        {
            if(ModelState.IsValid)
            {
                //Send Email
                //_logger.LogInformation($"To: {to} Subject: {subject} Body: {body}");
                _mailService.SendMessage("Ayama@kmpg.com",model.Subject, model.Message/*"From: {model.Name} - {model.Email}, Message: {model.Message}"*/);
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();

            }
            else
            {
                //Show the errors
            }

            return View();

        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";

            return View();
        }

        /**/public IActionResult Shop()
        {
            
            var result =from p in _context.Products
                        orderby p.Category
                        select p;

            return View(result.ToList());
        }

    }
}
