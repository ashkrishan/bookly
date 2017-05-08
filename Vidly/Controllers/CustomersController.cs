using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        
        private readonly List<Customer> _customers;

        private IEnumerable<Customer> GetCustomers()
        {
            //return new List<Customer>();
            return new List<Customer>
            {
                new Customer {Id=1, Name = "Mr Jack Brown"},
                new Customer {Id=2, Name = "Miss Jane Smith"},
                new Customer {Id=3,Name = "Lord Zack Smith"}
            };

        }

        // GET: Customer
        public ActionResult Index()
        {
            var customers = GetCustomers();
            
            return View(customers);
        }

        //[Route("Customers/Details/{id}")] //Not needed as dynamic route is already defined in route config 
        public ActionResult Details(int id)
        {
            
            var getCustomer = (from cust in GetCustomers()
                               where cust.Id == id
                               select cust).FirstOrDefault();

            if (getCustomer == null)
                return HttpNotFound();
            
            return View(getCustomer);

        }
    }
}