using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ChristiansWebPage.Models;
using ChristiansWebPage.Controllers;

namespace ChristiansWebPage.Models
{
    public class CheckTemperature
    {
        public double recivedTemperature = 0;
        public string healthStatus = "";


        static public CheckTemperature TemperatureCheck(CheckTemperature medicalJournal)
        {
            if (medicalJournal.recivedTemperature >= 38)
            {
                medicalJournal.healthStatus = "You are feverish! ";
            }
            else if (medicalJournal.recivedTemperature <= 35)
            {
                medicalJournal.healthStatus = "You have Hypothemia!";
            }
            else
            {
                medicalJournal.healthStatus = "You are not feverish!";
            }
            return medicalJournal;
        }



    }

    
}