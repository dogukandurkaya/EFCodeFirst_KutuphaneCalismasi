using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EF_CodeFirst.Models.Context;
using EF_CodeFirst.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Controllers
{
    public class BookController : Controller
    {
        public readonly Library6Context _context;
        public BookController(Library6Context context)
        {
            _context = context;
        }

        public IActionResult Index(int id)
        {
            return View(_context.Books.ToList());
        }

        public IActionResult Create()
        {
            ViewData["Category"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            ViewData["Author"] = new SelectList(_context.Authors, "AuthorId", "AuthorName");
            ViewData["Publisher"] = new SelectList(_context.Publishers, "PublisherId", "PublisherName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book kitap)
        {
            _context.Add(kitap);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var kitap = _context.Books
            .Include(k => k.Category) 
            .Include(k => k.Author) 
            .Include(k => k.Publisher)
            .First(sk => sk.BookId == id); 
            return View(kitap);
        }

        public IActionResult Edit(int id)
        {
             ViewData["Category"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            ViewData["Author"] = new SelectList(_context.Authors, "AuthorId", "AuthorName");
            ViewData["Publisher"] = new SelectList(_context.Publishers, "PublisherId", "PublisherName");
            var kitap = _context.Books.Find(id);
            return View(kitap);
        }

        [HttpPost]
        public IActionResult Edit(Book kitap)
        {
            if (!ModelState.IsValid)
            {
                return View(kitap);
            }
            _context.Update(kitap);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var kitap = _context.Books.Find(id);
            return View(kitap);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var silinecekKitap = _context.Books.Find(id);
            silinecekKitap.IsDeleted = true;
            _context.Update(silinecekKitap);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}