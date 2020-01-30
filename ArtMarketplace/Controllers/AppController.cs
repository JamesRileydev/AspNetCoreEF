using ArtMarketplace.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Contact(ContactViewModel vm)
        {
             if (ModelState.IsValid)
            {
                //Send the email

            }
            else
            {
                //Show errors
            }
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
