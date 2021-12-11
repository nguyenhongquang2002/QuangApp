using QuangApp.Data;
using QuangApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuangApp.Controllers
{
    public class HomeController : Controller
    {
        private MyDBContext myDBContext = new MyDBContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Apple()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Store(string name )
        {
            var student = new Student()
            {
                Name = name               
            };
            myDBContext.Students.Add(student);
            myDBContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}