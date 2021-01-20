using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        [HandleError(View="SOError",ExceptionType =typeof(StackOverflowException))]
        public ActionResult Index()
        {
            //throw new StackOverflowException();
            return View();
        }
        [ActionName("Angsuman")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View("About");
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Having trouble? Contact US.";
            return View();
        }
        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.TheMessage = "Thanks!! We will get back to you.";
            return View();
        }
        
        public ActionResult Foo()
        {
            return View("About");
        }

        public ActionResult Serial(string letterCase)
        {
            string serial = "ASPNETMVCV5ATM";
            if(letterCase == "lower")
            {
                return Content(serial.ToLower());
            }
            else
            {
                //return Content(serial);
                //return Json(new { name = "serial", value = serial }, JsonRequestBehavior.AllowGet);
                return RedirectToAction("Index");
            }        
        }
    }
}