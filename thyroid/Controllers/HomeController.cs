using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using thyroid.Models;
namespace thyroid.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }     
        
        [HttpPost]
        public ActionResult Index(LoginViewModel l1)
        {
            //if (ModelState.IsValid)
            //{
            //    return ("Thanx", guestResponse);
            //}
            //else
            //{
            //    // there is a validation error
            //    return View();
            //}
            //if (l1.Email == "ali") return View("MenuPage");
            //else 
            TempData["a"] = "index";
            return RedirectToAction("MenuPage");
        }
        public ActionResult MenuPage()
        {            
            if((string)TempData["a"]=="index")            return View();            
            else return RedirectToAction("Index");

        }
        [HttpPost]         
        public ActionResult MenuPage(string btn,Person p1)
        {
            //if (ModelState.IsValid)
            //{
            //    return ("Thanx", guestResponse);
            //}
            //else
            //{
            //    // there is a validation error
            //    return View();
            //}
            //if (l1.Email == "ali") return View("MenuPage");
            //else            
            if (Request.Form["sabt"]!=null) return RedirectToAction("Demographic_V");
            if (Request.Form["showall"] != null) return RedirectToAction("Showall");
            else return RedirectToAction("MenuPage");                      
        }
        public ViewResult Demographic_V()
        {
            return View();
        }

        public ViewResult Initial_V()
        {
            return View();
        }

        public ViewResult Eval_V()
        {
            return View();
        }

        public ViewResult Risk_V()
        {
            return View();
        }

        public ViewResult Etiology_V()
        {
            return View();
        }

        public ViewResult Labdata_V()
        {
            return View();
        }
        public ViewResult Imagedata_V()
        {
            return View();
        }

        public ViewResult Diagnos_V()
        {
            return View();
        }

        public ViewResult Follow_V()
        {
            return View();
        }

        public ViewResult Anomaly_V()
        {
            return View();
        }
    }
}