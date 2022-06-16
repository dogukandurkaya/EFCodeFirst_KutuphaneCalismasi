using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EF_CodeFirst.Models.Context;
using EF_CodeFirst.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Controllers
{
    public class AuthorController : Controller
    {
        public readonly Library6Context _context;
        public AuthorController(Library6Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Authors.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Author author)
        {
            _context.Add(author);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

         public IActionResult Details(int id)
        {
            var yazar = _context.Authors.Find(id);
            return View(yazar);
        }

         public IActionResult Edit(int id)
        {
            var yazar = _context.Authors.Find(id);
            return View(yazar);
        }

        [HttpPost]
        public IActionResult Edit(Author yazar)
        {
            if (!ModelState.IsValid)
            {
                return View(yazar);
            }
            _context.Update(yazar);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

         public IActionResult Delete(int id)
        {
            var yazar = _context.Authors.Find(id);
            return View(yazar);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var silinecekYazar = _context.Authors.Find(id);
            silinecekYazar.IsDeleted = true;
            _context.Update(silinecekYazar);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}