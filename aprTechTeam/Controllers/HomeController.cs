using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aprTechTeam.Models;

namespace aprTechTeam.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edgar()
        {
            return View();
        }

        public IActionResult Raul()
        {
            return View();
        }

        public IActionResult Danny()
        {
            return View();
        }

        public IActionResult Kevin()
        {
            return View();
        }

        public IActionResult Tamiris()
        {
            return View();
        }

      
        public IActionResult Contact()
        {
            ViewData["Message"] = "Connect with your Technology Support Team";

            return View();
        }

        public IActionResult Privacy()
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
