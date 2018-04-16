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
        // Get to About section
        public ActionResult About()
        {
            var model = new AboutModel();
            model.FirstName = "Christian";
            model.LastName = "Levin";
            

            //ViewBag.Message("Here is the Curiculum Vitae of Christian:");
            //ViewBag.Message("Jobb experience:");
            //ViewBag.Message("Education:");
            //ViewBag.Message("Courses:");
            return View(model);
        }

        // Get to Contact section
        public ActionResult Contact()
        {
            ViewBag.Message("Here is the contact details to Christian:");
            return View();
        }

        //Get to Projects section
        public ActionResult Projects()
        {
            ViewBag.Message("Here is the collection of projects that Christian have created:");
            //ViewBag.Message("CommandoPromt Calculator");
            //ViewBag.Message("CommandoPromt Golf Game");
            //ViewBag.Message("CommandoPromt ArenaFighter");
            //ViewBag.Message("Christians Simple Homepage");
            //ViewBag.Message("Christians homepage with Bootstrap");
            //ViewBag.Message("Christians Sokuban Game");
            //ViewBag.Message("Christian have dabbled in other programming languages aswell including: Assembler, (Turbo)Pascal, C, C++, and PLC.");
            return View();
        }      


        // GET: Home
        public ActionResult Index()
        {
            return View();
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
