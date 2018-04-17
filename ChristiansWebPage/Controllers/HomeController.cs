using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChristiansWebPage.Models;

namespace ChristiansWebPage.Controllers
{
    public class HomeController : Controller
    {
        // Get Home
        public ActionResult Index()
        {

            return View();
        }

        // Get to About section
        public ActionResult About()
        {
            //var model = new AboutModel();
            //model.ObjectName = "Support-Tekniker";
            //model.ObjectDescription = "Working in a support management environment as a first contact support-technician.";
            //return View(model);
            return Content("aboutPage");
        }

        // Get to Contact section
        public ActionResult Contact()
        {
            //ViewBag.Message("Here is the contact details to Christian:");
            //return View();
            return Content("Contact page");
        }

        //Get to Projects section
        public ActionResult Projects()
        {
            //ViewBag.Message("Here is the collection of projects that Christian have created:");

            //return View();
            return Content("projects Page");
        }      


       

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //// GET: Home/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Home/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Home/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Home/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Home/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Home/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
