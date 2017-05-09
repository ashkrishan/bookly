using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;


namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {



        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Customer
        public ActionResult Index()
        {                     
            return View(_context.Customers.ToList());
        }


        //[Route("Customers/Details/{id}")] //Not needed as dynamic route is already defined in route config 
        public ActionResult Details(int id)
        {
            
            var getCustomer = (from cust in _context.Customers
                               where cust.Id == id
                               select cust).FirstOrDefault();

            if (getCustomer == null)
                return HttpNotFound();
            
            return View(getCustomer);

        }
    }
}