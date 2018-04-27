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
     
        [HttpPost] //This action sorts the data based on which column to sort on
        public ActionResult SortAPeopleList(string sortOnColumn)
        {
            if(sortOnColumn == "FirstName")
            {
                PerCapitaModel.SortAPeopleListOnFirstName();
            }else if(sortOnColumn == "LastName")
            {
                PerCapitaModel.SortAPeopleListOnLastName();
            }else if(sortOnColumn == "City")
            {
                PerCapitaModel.SortAPeopleListOnCity();
            }
            return View("Index", PerCapitaModel.peopleList);
        }

        [HttpPost]// This Action Filters out the entered text.
        public ActionResult FilterPerCapita(string searchFilter)
        {
            List<PerCapitaModel> FilteredPeopleList = new List<PerCapitaModel>();
            FilteredPeopleList = PerCapitaModel.FilterAPeopleList(searchFilter);
            return View("Index", FilteredPeopleList);
        }
        //This action removes the corresponding object in the data

        [HttpGet] 
        public ActionResult DeletePerCapita(int id)
        {
            for (int i = 0; i < PerCapitaModel.peopleList.Count; i++)
            {
                PerCapitaModel deleteAPerson = new PerCapitaModel();
                deleteAPerson = PerCapitaModel.peopleList[i];
                if (deleteAPerson.Id == id)
                {
                    PerCapitaModel.peopleList.Remove(deleteAPerson);
                }
            }
            return View("Index", PerCapitaModel.peopleList);
        }

        [HttpPost] //Add a person to existing list
        public ActionResult AddPerCapita(string FirstName, string LastName, string MobilePhoneNumber, string City)
        {
            Session["WrongMobilenumber"] = "";
            PerCapitaModel AddAPerson = new PerCapitaModel();
            AddAPerson.FirstName = FirstName;
            AddAPerson.LastName = LastName;
            AddAPerson.MobilePhoneNumber = CheckMobilePhoneNumber(MobilePhoneNumber);
            if (AddAPerson.MobilePhoneNumber == "Letters instead of Numbers")
            {
                Session["WrongMobilenumber"] = "You have typed a incorrect mobilenumber.";
                AddAPerson.MobilePhoneNumber = "";
            }
            AddAPerson.City = City;
            PerCapitaModel.peopleList.Add(AddAPerson);
            return View("Index", PerCapitaModel.peopleList);
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