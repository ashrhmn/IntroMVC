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
            String[] persons = new String[] { "Ashik","Mortuja" };
            ViewBag.persons = persons;
            return View();
        }
    }
}