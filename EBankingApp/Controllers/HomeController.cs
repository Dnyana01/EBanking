using EBankingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EBankingApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult offer1()
        {
            return View();
        }
        public IActionResult offer2()
        {
            return View();
        }
        public IActionResult offer3()
        {
            return View();
        }
        public IActionResult fdPage()
        {
            return View();
        }
        public IActionResult rdPage()
        {
            return View();
        }
        public IActionResult SipPage()
        {
            return View();
        }

        public IActionResult MyPurpleHomePage()
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
