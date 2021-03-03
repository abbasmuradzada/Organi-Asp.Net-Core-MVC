using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppWithTemplate.Models.DataContext;
using AppWithTemplate.Models.Entity;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.Extensions.Hosting;

namespace AppWithTemplate.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PostsController : Controller
    {
        private readonly OrganiDbContext db;
        private readonly IHostEnvironment env;

        
        public PostsController(OrganiDbContext context, IHostEnvironment env)
        {
            db = context;
            this.env = env;
        }

        // GET: Admin/Posts
        public async Task<IActionResult> Index()
        {
            return View(await db.Posts.ToListAsync());
        }

        // GET: Admin/Posts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await db.Posts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // GET: Admin/Posts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Posts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Body,Image,PostDate")] Post post, IFormFile myFile)
        {
            if (myFile == null)
            {
                ModelState.AddModelError("Image", "Fayl uygun deyil");
            }
            if (ModelState.IsValid)
            {
                string extension = Path.GetExtension(myFile.FileName);
                post.Image = $"{DateTime.Now:yyyyMMddHHmmss} - {Guid.NewGuid()}{extension}";

                string phisicalPath = Path.Combine(env.ContentRootPath,
                    "wwwroot",
                    "uploads",
                    "images",
                    post.Image);
                
                using (FileStream fs = new FileStream(phisicalPath, FileMode.Create, FileAccess.Write))
                {
                    await myFile.CopyToAsync(fs);
                }
                db.Add(post);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }

        // GET: Admin/Posts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await db.Posts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }

        // POST: Admin/Posts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Body,Image,PostDate")] Post post)
        {
            if (id != post.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(post);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostExists(post.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }

        // GET: Admin/Posts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await db.Posts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: Admin/Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var post = await db.Posts.FindAsync(id);
            db.Posts.Remove(post);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostExists(int id)
        {
            return db.Posts.Any(e => e.Id == id);
        }
    }
}
