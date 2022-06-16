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
    public class PublisherController : Controller
    {
        public readonly Library6Context _context;
        public PublisherController(Library6Context context)
        {
            _context = context;
        }
       
        public IActionResult Index()
        {
            return View(_context.Publishers.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Publisher yayinevi)
        {
            _context.Add(yayinevi);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var yayinevi = _context.Publishers.Find(id);
            return View(yayinevi);
        }

         public IActionResult Edit(int id)
        {
            var yayinevi = _context.Publishers.Find(id);
            return View(yayinevi);
        }

        [HttpPost]
        public IActionResult Edit(Publisher yayinevi)
        {
            if (!ModelState.IsValid)
            {
                return View(yayinevi);
            }
            _context.Update(yayinevi);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var yayinevi = _context.Publishers.Find(id);
            return View(yayinevi);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var silinecekYayinevi = _context.Publishers.Find(id);
            silinecekYayinevi.IsDeleted = true;
            _context.Update(silinecekYayinevi);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

     
    }
}