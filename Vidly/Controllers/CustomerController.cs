using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private static readonly List<Customer> Customers = new List<Customer>()
        {
            new Customer() {Name = "John Smith"},
            new Customer() {Name = "Mary Williams"}
        };

        [Route("customers")]
        public ActionResult Index()
        {
            var customers = CustomerController.Customers;

            var customerViewModel = new CustomerViewModel() {Customers = customers};
            var viewModel = customerViewModel;

            return View(viewModel);
        }

        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = !Customers.Where(c=>c.Id == id).Select(c=>c.Name).Any() ? new Customer() { Id = id, Name = $@"No Customer with Id={id}"} : Customers[id];
            return View(customer);
        }
    }
}