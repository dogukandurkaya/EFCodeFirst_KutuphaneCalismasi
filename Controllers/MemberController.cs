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
    public class MemberController : Controller
    {
        public readonly Library6Context _context;
        public MemberController(Library6Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Members.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Member uye)
        {
            _context.Add(uye);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var uye = _context.Members.Find(id);
            return View(uye);
        }

        public IActionResult Edit(int id)
        {
            var uye = _context.Members.Find(id);
            return View(uye);
        }

        [HttpPost]
        public IActionResult Edit(Member uye)
        {
            if (!ModelState.IsValid)
            {
                return View(uye);
            }
            _context.Update(uye);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var uye = _context.Members.Find(id);
            return View(uye);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var silinecekUye = _context.Members.Find(id);
            silinecekUye.IsDeleted = true;
            _context.Update(silinecekUye);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}