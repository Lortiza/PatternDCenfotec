using Exercises__5_desing_patttern.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Exercises__5_desing_patttern.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConvertTemperatures(int start, int end, int step)
        {
            ViewData["Start"] = start;
            ViewData["End"] = end;
            ViewData["Step"] = step;
            return View();
        }
    }
}