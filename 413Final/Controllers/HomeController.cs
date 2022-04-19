using _413Final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _413Final.Controllers
{
    public class HomeController : Controller
    {
        private QuoteContext _context { get; set; }

        public HomeController(QuoteContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            var data = _context.Quotes.OrderBy(q => q.author).ToList();
            return View(data);
        }
        public IActionResult Details(int id)
        {
            ViewBag.id = id;

            Quote quote = _context.Quotes
                .Where(x => x.id == id)
                .Single();
            return View(quote);
        }
        [HttpGet]
        public IActionResult Add()
        {
            Quote quote = new Quote();
            return View("CreateQuote", quote);
        }

        [HttpPost]
        public IActionResult Add(Quote q)
        {
            if (ModelState.IsValid)
            {
                _context.Add(q);
                _context.Update(q);
                _context.SaveChanges();
                return View("Index", q);
            }
            else
            {
                return View("CreateQuote");
            }
        }
       
        public IActionResult Delete( int id)
        {
            var qt = _context.Quotes.Single(x => x.id == id);
            _context.Quotes.Remove(qt);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        //[HttpGet]
        //public IActionResult Edit (Quote qt)
        //{
        //    Quote qts = _context.Quotes.Single(x => x.id == qt.id);
        //    return View("Details", qts);
        //}
        //[HttpPost]
        //public IActionResult Edit (Quote qt)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Update(qt);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        var record = _context.Quotes.Single(x => x.id == qt.id);
        //        return View("Details", qt);
        //    }
                  
        

       
    }
}
