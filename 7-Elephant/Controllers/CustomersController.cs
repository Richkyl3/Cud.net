using _7_Elephant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _7_Elephant.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        Entities db = new Entities();
        CustomerIndexData cusIndexData = new CustomerIndexData();
        // GET: Customers
        public ActionResult Index(string email, int? productId)
        {
            cusIndexData.Customers = db.AspNetUsers
            .Select(i => new Customers()
            {
                CustomerEmail = i.Email,
                CustomerName = i.UserName
            }
            ).ToList();

            if (email != null)
            {
                ViewBag.selectedEmail = email;
                var phones = from phone in db.Phones
                             join order in db.Orders
                             on phone.product_id equals order.product_id
                             where order.user_email == email
                             select phone;
                cusIndexData.Phones = phones.Distinct();
            }

            if (productId != null)
            {
                cusIndexData.Orders = from order in db.Orders
                                      where order.user_email == email
                                      && order.product_id == productId
                                      select order;
            }

            return View(cusIndexData);
        }
    }
}