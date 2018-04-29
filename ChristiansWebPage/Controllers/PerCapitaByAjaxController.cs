using ChristiansWebPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace ChristiansWebPage.Controllers
{
    public class PerCapitaByAjaxController : Controller
    {
       
        // GET: PerCapita
        public ActionResult Index()
        {
            return View(PerCapitaByAjax.peopleList);
        }

        [HttpPost] //This action sorts the data based on which column to sort on
        public ActionResult SortAPeopleList(string sortOnColumn)
        {
            if (sortOnColumn == "FirstName")
            {
                PerCapitaByAjax.SortAPeopleListOnFirstName();
            }
            else if (sortOnColumn == "LastName")
            {
                PerCapitaByAjax.SortAPeopleListOnLastName();
            }
            else if (sortOnColumn == "City")
            {
                PerCapitaByAjax.SortAPeopleListOnCity();
            }
            return View("Index", PerCapitaByAjax.peopleList);
        }

        [HttpPost]// This Action Filters out the entered text.
        public ActionResult FilterPerCapita(string searchFilter)
        {
            List<PerCapitaByAjax> FilteredPeopleList = new List<PerCapitaByAjax>();
            FilteredPeopleList = PerCapitaByAjax.FilterAPeopleList(searchFilter);
            return View("Index", FilteredPeopleList);
        }
        //This action removes the corresponding object in the data

        [HttpGet]
        public ActionResult DeletePerCapitaByAjax(int id)
        {
            for (int i = 0; i < PerCapitaByAjax.peopleList.Count; i++)
            {
                PerCapitaByAjax deleteAPerson = new PerCapitaByAjax();
                deleteAPerson = PerCapitaByAjax.peopleList[i];
                if (deleteAPerson.Id == id)
                {
                    PerCapitaByAjax.peopleList.Remove(deleteAPerson);
                }
            }
            return View("Index", PerCapitaByAjax.peopleList);
        }

        [HttpPost] //Add a person to existing list
        public ActionResult AddPerCapitaByAjax(string FirstName, string LastName, string MobilePhoneNumber, string City)
        {
            Session["WrongMobilenumber"] = "";
            PerCapitaByAjax AddAPerson = new PerCapitaByAjax();
            AddAPerson.FirstName = FirstName;
            AddAPerson.LastName = LastName;
            AddAPerson.MobilePhoneNumber = CheckMobilePhoneNumber(MobilePhoneNumber);
            if (AddAPerson.MobilePhoneNumber == "Letters instead of Numbers")
            {
                Session["WrongMobilenumber"] = "You have typed a incorrect mobilenumber.";
                AddAPerson.MobilePhoneNumber = "";
            }
            AddAPerson.City = City;
            PerCapitaByAjax.peopleList.Add(AddAPerson);
            return View("Index", PerCapitaByAjax.peopleList);
        }

        /// <summary>
        /// Function that handles entered letters as a mobile number
        /// </summary>
        /// <param name="MobilePhoneNumber is the input string from user"></param>
        /// <returns></returns>
        private string CheckMobilePhoneNumber(string MobilePhoneNumber)
        {
            char cMPND;//checkMobilePhoneNumberDigit
            string checkedMobilePhoneNumber = "";
            for (int i = 0; i < MobilePhoneNumber.Length; i++)
            {
                cMPND = MobilePhoneNumber[i];
                if (Char.IsDigit(cMPND))//if checkMobilePhoneNumberDigit is a digit
                {
                    checkedMobilePhoneNumber += cMPND;
                }
                else if (Char.IsLetter(cMPND)) //if checkMobilePhoneNumberDigit is a letter
                {
                    checkedMobilePhoneNumber = "Letters instead of Numbers";
                }
                else if (Char.IsSeparator(cMPND))//if checkMobilePhoneNumberDigit is a separator
                {
                    checkedMobilePhoneNumber += cMPND;
                }
                else if (Char.IsWhiteSpace(cMPND))//if checkMobilePhoneNumberDigit is a whiteSpace
                {
                }
            }
            return checkedMobilePhoneNumber;
        }
    }
}