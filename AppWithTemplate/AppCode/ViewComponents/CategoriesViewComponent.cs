using AppWithTemplate.Models.DataContext;
using AppWithTemplate.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AppWithTemplate.AppCode.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        readonly OrganiDbContext context;
        public CategoriesViewComponent(OrganiDbContext db)
        {
            this.context = db;
        }

        public IViewComponentResult Invoke()
        {
            List<Category> categories = context.Categories.ToList();
            //ViewBag.Categories = categories;

            return View(categories);
        }
    }
}
