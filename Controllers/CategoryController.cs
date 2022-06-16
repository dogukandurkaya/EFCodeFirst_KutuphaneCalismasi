using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EF_CodeFirst.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EF_CodeFirst.Models.Context;

namespace Controllers
{
    public class CategoryController : Controller
    {
        public readonly Library6Context _context;
        public CategoryController(Library6Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var kategori = _context.Categories.Find(id);
            return View(kategori);
        }

        public IActionResult Edit(int id)
        {
            var kategori = _context.Categories.Find(id);
            return View(kategori);
        }

        [HttpPost]
        public IActionResult Edit(Category kategori)
        {
            if (!ModelState.IsValid)
            {
                return View(kategori);
            }
            _context.Update(kategori);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var kategori = _context.Categories.Find(id);
            return View(kategori);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var silinecekKategoriTuru = _context.Categories.Find(id);
            silinecekKategoriTuru.IsDeleted = true;
            _context.Update(silinecekKategoriTuru);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}