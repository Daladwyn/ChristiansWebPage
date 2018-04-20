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
        // Get GuessingGame
        public ActionResult GuessingGame()
        {
            return View();
        }

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
        public ActionResult FeverCheck()
        {
            ViewBag.Message = "";
            return View();
        }

        [HttpPost]
        public ActionResult FeverCheck(string BodyTemperature)
        {
            bool validTemperature = true;
            ViewBag.Message = "";
            var medicalCheck = new CheckTemperature();
            try
            {
                medicalCheck.recivedTemperature = Convert.ToDouble(Server.HtmlEncode(BodyTemperature));
            }
            catch (FormatException)
            {
                ViewBag.ErrorMessage = "You did not enter a value that can be checked. Please try again.";
                ViewBag.Message = "";
                validTemperature = false;
            }
            if (validTemperature == true)
            {
                medicalCheck = CheckTemperature.TemperatureCheck(medicalCheck);
                ViewBag.Message = medicalCheck.healthStatus;
            }
            medicalCheck.healthStatus = "";
            validTemperature = true;
            return View();
        }

    }
}
