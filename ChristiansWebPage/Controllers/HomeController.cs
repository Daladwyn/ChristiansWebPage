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
            return View();
        }

        // Get to Contact section
        public ActionResult Contact()
        {
            return View();
        }

        //Get to Projects section
        public ActionResult Projects()
        {
            return View();
        }

        //Get healthcheck section
        [HttpGet]
        public ActionResult Healthcheck()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Healthcheck(string BodyTemperature)
        {
            return RedirectToAction(CheckTemperature(BodyTemperature));
        }


        //checking the recieved temperature
        private string CheckTemperature(string BodyTemperature)
        {
            var medicalCheck = new CheckTemperatureModel();
            medicalCheck.recivedTemperature = Convert.ToDouble(Server.HtmlEncode(BodyTemperature));
            //string healthStatus = "";
            string ViewName = "CheckTemperature";

            if (medicalCheck.recivedTemperature > 38)
            {
                ViewBag.Message = "You are feverish! ";
            }
            else
            {
                ViewBag.Message = "You are not feverish!";
            }
            ViewBag.Message = "sick";
            //return Content(ViewBag);
            return View(ViewName, ViewBag);
              //  medicalCheck);
            //return (BodyTemperature);
        }

    }
}
