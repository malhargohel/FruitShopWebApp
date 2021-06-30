using CURDOperationWithImageUploadCore5_Demo.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Helpers;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{


        public class HomeController : Controller
        {
            private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment webHostEnvironment;
        private IConfiguration configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration _configuration, IWebHostEnvironment hostEnvironment
            )
            {
            configuration = _configuration;
                _logger = logger;
            webHostEnvironment = hostEnvironment;
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

        [HttpGet]    
        public IActionResult Contact()
            {
                return View();
            }
        
        [HttpPost]
        public ActionResult Contact(ContactToEmail contacttoemail, IFormFile[] attachments)
        {
            var body = "Name: " + contacttoemail.Name + "<br>Email: " + contacttoemail.Email + "<br>Message: " + contacttoemail.Message + "<br>";
            var mailHelper = new MailHelper(configuration);
            List<string> fileNames = null;
            if (attachments != null && attachments.Length > 0)
            {
                fileNames = new List<string>();
                foreach (IFormFile attachment in attachments)
                {
                    var path = Path.Combine(webHostEnvironment.WebRootPath, "uploads", attachment.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        attachment.CopyToAsync(stream);
                    }
                    fileNames.Add(path);
                }
            }
            if (mailHelper.Send(contacttoemail.Email, configuration["Gmail:Username"], contacttoemail.Subject, body, fileNames))
            {
                ViewBag.msg = "Sent Mail Successfully";
            }
            else
            {
                ViewBag.msg = "Failed";
            }
            return View("Sent", new ContactToEmail());


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

