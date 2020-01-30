using ArtMarketplace.Services;
using ArtMarketplace.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ArtMarketplace.Controllers
{
    public class AppController : Controller
    {
        private NullMailService _mailService;

        public AppController(NullMailService mailService)
        {
            _mailService = mailService;
        }

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
                _mailService.SendMail("jamesriley.dev@gmail.com", vm.Subject, $"From: {vm.Name} - {vm.Email}, Message: {vm.Message}");

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
