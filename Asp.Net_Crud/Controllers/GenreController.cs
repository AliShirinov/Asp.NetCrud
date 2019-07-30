using ASPNetCrudApp.Data;
using ASPNetCrudApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ASPNetCrudApp.Controllers
{
    public class GenreController : Controller
    {
        // GET: Genre

        private readonly BookDbContext db;

        public GenreController()
        {
            db = new BookDbContext();
        }

        public async Task<ActionResult> Index()
        {
            List<Genre> genres = await db.Genres.ToListAsync();
            return View(genres);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Add(Genre genre)
        {
            if (ModelState.IsValid)
            {
                Genre new_genre = new Genre()
                {
                    Name = genre.Name
                };
                db.Genres.Add(new_genre);
                await db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));

            }
            else
            {
                return View(genre);
            }
        }

        public async Task<ActionResult> Delete(int? id)
        {
            if (id==null)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
               Genre genre = await db.Genres.Where(g => g.Id == id).FirstOrDefaultAsync();
                db.Genres.Remove(genre);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
        }

    }
}