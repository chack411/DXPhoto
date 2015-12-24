using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace DXPhoto.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
#if DNX451
            ViewBag.ServerName = Environment.MachineName;
#else
            ViewBag.ServerName = "";
#endif
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
