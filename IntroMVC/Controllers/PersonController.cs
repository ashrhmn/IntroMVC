using IntroMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroMVC.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            ViewBag.FirstName = "Ashik";
            ViewBag.LastName = "Rahman";
            return View();
        }

        public ActionResult List()
        {
            List<Person> persons = new List<Person>();
            for(int i = 0; i < 10; i++)
            {
                persons.Add(new Person
                {
                    Id = i,
                    Name = "Ashik"
                });
            }
            return View(persons);
        }
    }
}