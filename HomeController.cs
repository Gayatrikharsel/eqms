using System.Diagnostics;
using EMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Signup()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult SlotBooking()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult EquipmentList()
        {
            return View();
        }

        public IActionResult PaymentPricing()
        {
            return View();
        }
        public IActionResult faq()
        {
            return View();
        }
        public IActionResult TermsConditions()
        {
            return View();
        }
        public IActionResult PrivacyPolicy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
