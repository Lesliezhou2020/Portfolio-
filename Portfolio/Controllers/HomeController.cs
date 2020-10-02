using Microsoft.AspNetCore.Mvc;
using System;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]

        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpGet("/projects")]
        public ViewResult Projects()
        {
            return View("Projects");
        }

        [HttpGet("/contact")]

        public ViewResult Contact()
        {
            return View("Contact");
        }

        [HttpPost("/post")]

        public RedirectToActionResult Post(string name, string email, string message)
        {
            Console.WriteLine("good");
            return  RedirectToAction("Index");
        }

        
    }


}