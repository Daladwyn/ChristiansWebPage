using ChristiansWebPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChristiansWebPage.Controllers
{
    public class PerCapitaController : Controller
    {
        // GET: PerCapita
        public ActionResult Index()
        {
            //PerCapitaModel peopleList = new PerCapitaModel()
            {
              //{ FirstName = "Erik", LastName = "Persson", MobilePhoneNumber = 0701234567, Country = "Sweden" }
            };
            PerCapitaModel ppl1 = new PerCapitaModel { FirstName = "Erik", LastName = "Persson", MobilePhoneNumber = 0701234567, Country = "Sweden" };
            PerCapitaModel ppl2 = new PerCapitaModel { FirstName = "Pär", LastName = "Johansson", MobilePhoneNumber = 0701234567, Country = "Sweden" };

            List<PerCapitaModel> peopleList= new List<PerCapitaModel> { ppl1, ppl2 };


            return View(peopleList);
        }


        static List<PerCapitaModel> peopleList = new List<PerCapitaModel>
        {
        new PerCapitaModel { FirstName = "Erik", LastName = "Persson", MobilePhoneNumber = 0701234567, Country = "Sweden" },
        new PerCapitaModel { FirstName = "Pär", LastName = "Johansson", MobilePhoneNumber = 0701234567, Country = "Sweden" },
        new PerCapitaModel { FirstName = "Johan", LastName = "Nilsson", MobilePhoneNumber = 0701234567, Country = "Denmark" },
        new PerCapitaModel { FirstName = "Nils", LastName = "Petersson", MobilePhoneNumber = 0701234567, Country = "Norway" },
        new PerCapitaModel { FirstName = "Tim", LastName = "Eriksson", MobilePhoneNumber = 0701234567, Country = "Denmark" },
        new PerCapitaModel { FirstName = "Karl", LastName = "Karlsson", MobilePhoneNumber = 0701234567, Country = "Norway" },
        new PerCapitaModel { FirstName = "Eva", LastName = "Persson", MobilePhoneNumber = 0701234567, Country = "Ieland" },
        new PerCapitaModel { FirstName = "Anna", LastName = "Johansson", MobilePhoneNumber = 0701234567, Country = "Norway" },
        new PerCapitaModel { FirstName = "Mia", LastName = "Persson", MobilePhoneNumber = 0701234567, Country = "Denmark" },
        new PerCapitaModel { FirstName = "Fred", LastName = "Nilsson", MobilePhoneNumber = 0701234567, Country = "Sweden" },
        new PerCapitaModel { FirstName = "Tore", LastName = "Karlsson", MobilePhoneNumber = 0701234567, Country = "Germany" },
        new PerCapitaModel { FirstName = "Tuva", LastName = "Eriksson", MobilePhoneNumber = 0701234567, Country = "Sweden" },
        new PerCapitaModel { FirstName = "Nisse", LastName = "Johansson", MobilePhoneNumber = 0701234567, Country = "England" },
        new PerCapitaModel { FirstName = "Sam", LastName = "Andersson", MobilePhoneNumber = 0701234567, Country = "France" },
        new PerCapitaModel { FirstName = "Joar", LastName = "Toresson", MobilePhoneNumber = 0701234567, Country = "England" },
        new PerCapitaModel { FirstName = "Ulf", LastName = "Eriksson", MobilePhoneNumber = 0701234567, Country = "France" },
        new PerCapitaModel { FirstName = "Lisa", LastName = "Johansson", MobilePhoneNumber = 0701234567, Country = "Sweden" },
        new PerCapitaModel { FirstName = "Disa", LastName = "Persson", MobilePhoneNumber = 0701234567, Country = "Sweden" }
        };
    }
}
