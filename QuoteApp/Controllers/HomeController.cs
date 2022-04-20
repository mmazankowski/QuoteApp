using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuoteApp.Models;

namespace QuoteApp.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger; 
        //}

        private QuoteDbContext _quoteContext { get; set; }

        private iQuoteRepository _repo { get; set; }

        public HomeController(iQuoteRepository temp, QuoteDbContext someQuote)
        {
            _repo = temp;
            _quoteContext = someQuote; 
        }

        [HttpGet]
        public IActionResult Index()
        {
            var quotes = _quoteContext.Quotes
                .OrderBy(x => x.Author)
                .ToList();

            return View(quotes);
        }

        //[HttpPost]
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public IActionResult QuoteForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult QuoteForm(Quote q)
        {
            _quoteContext.Add(q);
            _quoteContext.SaveChanges();
            return View("Confirmation", q);
        }

        [HttpGet]
        public IActionResult Edit(int quoteid)
        {
            ViewBag.Quotes = _quoteContext.Quotes.ToList();

            var quote = _quoteContext.Quotes.Single(x => x.QuoteId == quoteid);

            return View("QuoteForm", quote);
        }

        [HttpPost]
        public IActionResult Edit(Quote q)
        {
            _quoteContext.Update(q);
            _quoteContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int quoteid)
        {
            var quote = _quoteContext.Quotes.Single(x => x.QuoteId == quoteid);

            return View(quote);
        }

        [HttpPost]
        public IActionResult Delete(Quote q)
        {
            _quoteContext.Quotes.Remove(q);
            _quoteContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
