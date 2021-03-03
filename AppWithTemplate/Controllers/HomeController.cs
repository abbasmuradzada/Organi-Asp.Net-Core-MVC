using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AppWithTemplate.Models;
using AppWithTemplate.Models.DataContext;
using AppWithTemplate.Models.Entity;

namespace AppWithTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly OrganiDbContext db;

        //constructor injection
        public HomeController(ILogger<HomeController> logger,OrganiDbContext db)
        {
            _logger = logger;
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(Message message)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Message = "Melumatlar duzgun qeyd edilmeyib";
                return View(message);
            }

            db.Messages.Add(message);

            db.SaveChanges();

            ViewBag.Message = "Melumat Gonderildi";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
