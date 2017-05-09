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


        private IEnumerable<Book> AllBooks
        {
            get
            {
                return new List<Book>
            {
            new Book {Id = 1, Name=@"C# Advanced"},
            new Book {Id=2, Name="Design Patterns"}
            };
            }
        }

        // GET: Books
        public ActionResult Index()
        {
            var books = AllBooks;
            return View(books);
        }



        public ActionResult Details(int id)
        {
            var GetBook = (from book in AllBooks
                           where book.Id == id
                           select book).FirstOrDefault();

            if (GetBook == null)
                return HttpNotFound(@"Book with this id doesn't exist");
            return View(GetBook);

        }
    }
}