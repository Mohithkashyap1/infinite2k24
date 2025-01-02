using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movies.Models;

namespace Movies.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie

        private MovieDb db = new MovieDb();
        // 1. Index: Display all movies
        public ActionResult Index()
        {
            var movies = db.Movies.ToList();
            return View(movies);
        }
        // 2. Create: Display the Create form
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }
        // 3. Edit: Display the Edit form
        public ActionResult Edit(int id)
        {
            var movie = db.Movies.Find(id);
            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }
        // 4. Delete: Confirm Delete
        public ActionResult Delete(int id)
        {
            var movie = db.Movies.Find(id);
            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var movie = db.Movies.Find(id);
            if (movie != null)
            {
                db.Movies.Remove(movie);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        // 5. Movies Released in a Specific Year
        public ActionResult MoviesByYear(int year)
        {
            var movies = db.Movies
                           .Where(m => m.DateOfRelease.Year == year)
                           .ToList();
            return View(movies);
        }
        /*
        public ActionResult Index()
        {
            return View();
        }
        */
    }
}