using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RandomViewModel
    {
        public Book Book { get; set; }
        public List<Customer> Customers { get; set; }

    }
}