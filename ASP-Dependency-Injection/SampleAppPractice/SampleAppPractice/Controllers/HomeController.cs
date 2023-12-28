using Microsoft.AspNetCore.Mvc;
using SampleAppPractice.Models;

namespace SampleAppPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMessanger _messanger;

        public HomeController(IMessanger messanger)
        {
            _messanger = messanger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string message)
        {
            _messanger.SendMessage(message, "admin@example.com");

            return View();
        }
    }
}
