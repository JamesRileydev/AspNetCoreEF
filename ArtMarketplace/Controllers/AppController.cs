using ArtMarketplace.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ArtMarketplace.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {

            return View();
        }

       [HttpPost("contact")]
        public IActionResult Contact(ContactInfo contactInfo)
        {

            return View();
        }

        [HttpGet("about")]
        public IActionResult About()
        {
            ViewBag.Title = "About";

            return View();
        }
    }
}
