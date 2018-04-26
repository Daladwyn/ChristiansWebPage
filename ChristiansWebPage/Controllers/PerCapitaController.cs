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
        // POST: PerCapita
        [HttpPost]
        public ActionResult Index(string filter)
        {
            return View(PerCapitaModel.peopleList);
        }

        public ActionResult DeletePerCapita(int Id)
        {
            for (int i = 0; i < PerCapitaModel.peopleList.Count; i++)
            {
                PerCapitaModel deleteAPerson = new PerCapitaModel();
                deleteAPerson = PerCapitaModel.peopleList[i];
                if (deleteAPerson.Id == Id)
                {
                    PerCapitaModel.peopleList.Remove(deleteAPerson);
                }
            }
            return View("Index",PerCapitaModel.peopleList);
        }

        [HttpPost]
        public ActionResult AddPerCapita(string FirstName, string LastName, string MobilePhoneNumber, string City)
        {
            PerCapitaModel AddAPerson = new PerCapitaModel();
            AddAPerson.FirstName = FirstName;
            AddAPerson.LastName = LastName;
            
            AddAPerson.MobilePhoneNumber = CheckMobilePhoneNumber(MobilePhoneNumber);
            if (AddAPerson.MobilePhoneNumber == "Letters instead of Numbers")
            {
                Session["WrongMobilenumber"] = "You have typed a incorrect mobilenumber.";
            }
            AddAPerson.City = City;
            PerCapitaModel.peopleList.Add(AddAPerson);

            return View("Index", PerCapitaModel.peopleList);
        }

        private string CheckMobilePhoneNumber(string MobilePhoneNumber)
        {
            char cMPND;
            string checkedMobilePhoneNumber = "";
            for (int i = 0; i < MobilePhoneNumber.Length; i++)
            {
                cMPND = MobilePhoneNumber[i];
                if (Char.IsDigit(cMPND))
                {
                    checkedMobilePhoneNumber += cMPND;
                }else if (Char.IsLetter(cMPND))
                {
                    checkedMobilePhoneNumber = "Letters instead of Numbers";
                }else if (Char.IsSeparator(cMPND))
                {
                    checkedMobilePhoneNumber += cMPND;
                }
                else if (Char.IsWhiteSpace(cMPND))
                {
                    checkedMobilePhoneNumber += cMPND;
                }
            }
            return checkedMobilePhoneNumber;
        }
    }
}