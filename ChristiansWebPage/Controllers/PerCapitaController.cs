using ChristiansWebPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace ChristiansWebPage.Controllers
{
    public class PerCapitaController : Controller
    {
        // GET: PerCapita
        public ActionResult Index()
        {

            

            return View(PerCapitaModel.peopleList);
        }

        [HttpPost]
        public ActionResult Index(string filter)
        {
            return View();
        }

        public ActionResult DeletePerCapita([Bind(Include = "FirstName, LastName, MobilePhoneNumber, Cities")] PerCapitaModel peopleRow)
        {
            return View();
        }

        public ActionResult AddPerCapita()
        {
            string firstName = Request.Form["FirstName"];
            string lastName = Request.Form["LastName"];
            int mobilePhonenumber = Convert.ToInt32(Request.Form["MobilePhoneNumber"]);
            string city = Request.Form["Cities"];
            PerCapitaModel AddAPerson = new PerCapitaModel();
            AddAPerson.FirstName = firstName;
            AddAPerson.LastName = lastName;
            AddAPerson.MobilePhoneNumber = mobilePhonenumber;
            AddAPerson.Cities = city;
            PerCapitaModel.peopleList.Add(AddAPerson);

            return View("Index", PerCapitaModel.peopleList);
            
        }


    }
}
