using IntroMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            String[] productNames = new String[]{ "Mango","Pine-Apple", "Apple", "Banana", "Date", "Grapes", "Orange", "Guava", "Strawberry", "Chocolate" };
            List<Product> products = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                products.Add(new Product
                {
                    Id = i,
                    Name = productNames[i]
                });
            }
            return View(products);
        }
    }
}