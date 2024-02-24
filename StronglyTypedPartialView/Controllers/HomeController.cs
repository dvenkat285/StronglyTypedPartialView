using StronglyTypedPartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyTypedPartialView.Controllers
{
    public class HomeController : Controller
    {


        List<Product> ProductsList = new List<Product>()
        {
            new Product {id = 1, name = "Shoes", price = 10000.00, picture = "~/images/domino-164_6wVEHfI-unsplash.jpg"},
            new Product {id = 2, name = "sunglass", price = 1000.00, picture = "~/images/giorgio-trovato-K62u25Jk6vo-unsplash.jpg" },
            new Product {id = 3, name = "watch", price = 50000.00, picture = "~/images/rachit-tank-2cFZ_FB08UM-unsplash.jpg"}
        };
        // GET: Home
        public ActionResult Index()
        {
            return View(ProductsList);
        }
    }
}