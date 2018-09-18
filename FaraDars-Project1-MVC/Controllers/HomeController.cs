using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FaraDars_Project1_MVC.Models;

namespace FaraDars_Project1_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public string Registration()
        {
            return "Test From Registartion In HomeController";
        }

        public ActionResult Registration2()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Registration3()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration3(Registration rgs)
        {
            //save to db
            //send email or ..

            if (ModelState.IsValid)
                return View("Thanks", rgs);
            else
                return View();
        }


    }
}