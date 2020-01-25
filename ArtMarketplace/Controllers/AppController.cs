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
            throw new InvalidOperationException();
            return View();
        }
    }
}
