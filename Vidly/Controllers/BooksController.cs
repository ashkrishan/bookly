using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books/Random
        public ActionResult Random()
        {
            var book = new Book
            { Name = @"C# Principles Advanced" } ;
            // return View(book);
            var customers = new List<Customer>
            {
                new Customer {Name="Jack Black"},
                new Customer {Name = "Mr Tumble"}
            };

            var viewModel = new RandomViewModel
            {
                Book = book,
                Customers = customers
            };

            return View(viewModel);

            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("id: " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("?pageIndex={0}&sortBy={1}", pageIndex, sortBy));

            
              
        }
       
        
        [Route("Books/{year:regex(\\d{4}):range(2004,2030)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(String.Format("{0}/{1}", year, month));
        }

    }
}