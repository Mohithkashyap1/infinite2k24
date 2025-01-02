using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Controllers;


namespace Application.Controllers
{
    public class CodeController : Controller
    {
        // GET: Code
        private northwindEntities db = new northwindEntities(); 
                                                                
        // Action 1: Get all customers residing in Germany
        public ActionResult CustomersInGermany()
        {
            var customers = db.Customers
                              .Where(c => c.Country == "Germany")
                              .ToList();
            return View(customers);
        }
        // Action 2: Get customer details with orderId == 10248
        public ActionResult CustomerDetailsWithOrder()
        {
            var customerDetails = (from o in db.Orders
                                   where o.OrderID == 10248
                                   join c in db.Customers on o.CustomerID equals c.CustomerID
                                   select c).FirstOrDefault();
            return View(customerDetails);
        }

        /*
        public ActionResult Index()
        {
            return View();
        }
        */
    }
}