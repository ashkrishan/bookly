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

        private readonly List<Book> _books = new List<Book>
        {
            new Book {Id = 1, Name=@"C# Advanced"},
            new Book {Id=2, Name="Design Patterns"}
        };


        // GET: Books
        public ActionResult Index()
        {
            var viewModel = new BooksViewModel
            {
                Books = _books
            };
            
            return View(viewModel);
        }

        [Route("Books/Details/{id}")]
        public ActionResult Details(int id)
        {
            var GetBooks = (from book in _books
                            where book.Id == id
                            select book).FirstOrDefault();

            if (GetBooks == null)
                return HttpNotFound(@"Book with this id doesn't exist");
            return View(GetBooks);

        }
    }
}