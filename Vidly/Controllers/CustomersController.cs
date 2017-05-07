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
        
        private readonly List<Customer> _customers = new List<Customer>

            {
                new Customer {Id=1, Name = "Mr Jack Brown"},
                new Customer {Id=2, Name = "Miss Jane Smith"},
                new Customer {Id=3,Name = "Lord Zack Smith"}
            };


        // GET: Customer
        public ActionResult Index()
        {


            var viewModel = new CustomersViewModel
            {
                Customers = _customers
            };
            
            return View(viewModel);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            
            var getCustomer = (from cust in _customers
                               where cust.Id == id
                               select cust).FirstOrDefault();

            if (getCustomer == null)
                return HttpNotFound();
            
            return View(getCustomer);

        }
    }
}