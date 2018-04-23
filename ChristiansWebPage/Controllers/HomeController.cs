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
            Session["NumberToBeGuessed"] = GuessingGameModel.GenerateANumber();
            return View();
        }
        // Post GuessingGame 
        [HttpPost]
        public ActionResult GuessingGame(string GuessANumber)
        {
            int preDeterminedNumber = 0;
            int guessedNumber = 0;
            List<int> listOfGuesses = new List<int>();
            preDeterminedNumber = Convert.ToInt32(Session["NumberToBeGuessed"]);
            try
            {
                guessedNumber = Convert.ToInt32(GuessANumber);
            }
            catch (ArgumentException)
            {
                Session["Result"] = "You did type a strange number, try again!";
            }
            catch (FormatException)
            {
                Session["Result"] = "You did type a strange number, try again!";
            }
            if (guessedNumber < preDeterminedNumber)
            {
                Session["Result"] = "Your guessed number was to low";
            }
            else if (guessedNumber == preDeterminedNumber)
            {
                Session["Result"] = "Your guessed number was spot on!! Good Guess!";
                Session["NumberToBeGuessed"] = GuessingGameModel.GenerateANumber();
                listOfGuesses.Clear();
                Session["GuessedValues"] = listOfGuesses;
            }
            else if (guessedNumber > preDeterminedNumber)
            {
                Session["Result"] = "Your guessed number was to great";
            }
            if (Session["GuessedValues"] != null)
            {
                listOfGuesses = (List<int>)Session["GuessedValues"];
            }
            listOfGuesses.Add(guessedNumber);
            Session["GuessedValues"] = listOfGuesses;
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
