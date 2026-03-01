using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ValidationPractice.Models;

namespace ValidationPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ValidationForm()
        {
            return View (new ValidationFormModel());
        }

        [HttpPost]
        public IActionResult ValidationForm(ValidationFormModel obj) 
        {
            if (ModelState.IsValid) 
            {
                return RedirectToAction("Index"); 
            }
            return View(obj);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
