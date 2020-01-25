using Microsoft.AspNetCore.Mvc;
using System;

namespace ArtMarketplace.Controllers
{
    public class AppController: Controller
    {
        public AppController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";

            return View();
        }
    }
}
