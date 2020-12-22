using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleMVC.Models;
using SimpleMVC.Services;

namespace SimpleMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PersonManager _personMgr;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _personMgr = new PersonManager();
        }

        public IActionResult Index()
        {
            var date = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss");
            return View();
        }

        public IActionResult People()
        {
            //Call some Business logic to fetch data
            var people = _personMgr.GetPeople();
            return View(people);
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
