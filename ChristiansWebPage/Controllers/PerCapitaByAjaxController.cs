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

        // GET: PerCapitaByAjax
        public ActionResult Index()
        {
            return View();
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
            return View("Index");
        }

        [HttpPost]// This Action Filters out the entered text.
        public ActionResult FilterPerCapitaByAjax(string searchFilter)
        {
            PerCapitaByAjax.FilterAPeopleList(searchFilter);
            return View("Index");
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
            return View("Index");
        }

        [HttpPost] //Add a person to existing list
        public ActionResult AddPerCapitaByAjax(string FirstName, string LastName, string MobilePhoneNumber, string City)
        {
            if (ModelState.IsValid)
            {
                bool addPost = true;
                Session["WrongUserInput"] = "";
                PerCapitaByAjax AddAPerson = new PerCapitaByAjax();
                if (PerCapitaByAjax.CheckNameInput(FirstName)) //if first name is entierly of letters then add it
                {
                    AddAPerson.FirstName = FirstName;
                }
                else
                {
                    Session["WrongUserInput"] = Session["WrongUserInput"] + "You typed " + FirstName + " as a first name which is deemed to not be a first name.";
                    addPost = false;
                }
                if (PerCapitaByAjax.CheckNameInput(LastName))//if last name is entierly of letters then add it
                {
                    AddAPerson.LastName = LastName;
                }
                else
                {
                    Session["WrongUserInput"] = Session["WrongUserInput"] + "You typed " + LastName + " as a last name which is deemed to not be a last name.";
                    addPost = false;
                }
                AddAPerson.MobilePhoneNumber = CheckMobilePhoneNumber(MobilePhoneNumber); //check if mobile number is numbers or separators.
                if (AddAPerson.MobilePhoneNumber == "Letters instead of Numbers")
                {
                    Session["WrongMobilenumber"] = "You have typed a incorrect mobilenumber.";
                    AddAPerson.MobilePhoneNumber = "";
                    addPost = false;
                }
                if (PerCapitaByAjax.CheckNameInput(City))//if city is entierly of letters then add it
                {
                    AddAPerson.City = City;
                }
                else
                {
                    Session["WrongUserInput"] = Session["WrongUserInput"] + "You typed " + City + " as a city which is deemed to not be a city name.";
                    addPost = false;
                }
                if (addPost == true)//if all entered data is correct then add the data to list/database
                {
                    PerCapitaByAjax.peopleList.Add(AddAPerson);
                }
                return View("Index");
            }
            else
            {
                Session["WrongUserInput"] = "You have entered one or more incorrect details.";
                return View("Index");
            }
        }

        public ActionResult PeopleRowRender(int id)
        {
            PerCapitaByAjax personToList = PerCapitaByAjax.peopleList.SingleOrDefault(Item => Item.Id == id);
            return PartialView("_TableRowOfPeople", personToList);
        }

        public ActionResult EditPerCapitaByAjax(int id)
        {
            PerCapitaByAjax personToList = PerCapitaByAjax.peopleList.SingleOrDefault(Item => Item.Id == id);

            return PartialView("_EditPerCapitaByAjax", personToList);

        }

        public ActionResult UpdatePerCapitaByAjax(PerCapitaByAjax editedPerson)
        {
            if (ModelState.IsValid)
            {
                for (int i = 0; i < PerCapitaByAjax.peopleList.Count; i++)
                {
                    if (PerCapitaByAjax.peopleList[i].Id == editedPerson.Id)
                    {
                        PerCapitaByAjax.peopleList[i].FirstName = editedPerson.FirstName;
                        PerCapitaByAjax.peopleList[i].LastName = editedPerson.LastName;
                        PerCapitaByAjax.peopleList[i].MobilePhoneNumber = editedPerson.MobilePhoneNumber;
                        PerCapitaByAjax.peopleList[i].City = editedPerson.City;
                    }
                }
                return PartialView("_TableRowOfPeople", editedPerson);
            }
            else
            {
                return new HttpStatusCodeResult(400);
            }
        }

        /// <summary>
        /// Function that handles entered letters as a mobile number
        /// </summary>
        /// <paramname></param>
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