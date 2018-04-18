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


    }
}
