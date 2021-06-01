using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstResponsiveWebAppKingslee.Models;

namespace FirstResponsiveWebAppKingslee.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FRE = 0;
            ViewBag.FR = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(FirstResponsiveWebApp model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FRE = model.AgeThisYearEnd();
                ViewBag.FR = model.AgeThisYear();
            }
            else
            {
                ViewBag.FRE = 0;
                ViewBag.FR = 0;
            }
            return View(model);
        }
    }
}
