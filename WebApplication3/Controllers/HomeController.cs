using CURDOperationWithImageUploadCore5_Demo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Controllers
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

            public IActionResult Privacy()
            {
                return View();
            }

            public IActionResult FreshProduce()
            {
                return View();
            }

            public IActionResult Specials()
            {
                return View();
            }

            public IActionResult Location()
            {
                return View();
            }

            public IActionResult Contact()
            {
                return View();
            }

            public IActionResult Shop()
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




    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext db;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            db = context;
        }

        public IActionResult Index()
        {
            var speaker = db.Speakers.ToList();
            return View(speaker);
        }

        public IActionResult LogIn()
        {
            var LogIn = db.Speakers.ToList();
            return View(LogIn);
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

