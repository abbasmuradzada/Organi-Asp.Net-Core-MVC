using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppWithTemplate.Models.DataContext;
using AppWithTemplate.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppWithTemplate.Controllers
{
    public class ShopController : Controller
    {
        readonly OrganiDbContext db;
        public ShopController(OrganiDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            //var products = db.Products
            //    .Include(p=>p.Images)
            //    .Include(p=>p.Category)
            //    .Where(p => p.DeletedDate == null)
            //    .Take(10);

            return View(null);
        }
    }
}