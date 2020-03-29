using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HolidayPartyRSVP.Models;

namespace HolidayPartyRSVP.Controllers
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

        public IActionResult Reservation()
        {
            return View();
        }
        public IActionResult BringADish(DishOptions dishOptions)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        //public IActionResult Reservation(Reserve reservation)
        //{
        //    //return View(ReserveConfirm);
        //}


        public IActionResult BringADish()
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
