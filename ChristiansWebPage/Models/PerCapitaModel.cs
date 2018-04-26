using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace ChristiansWebPage.Models
{
    public class PerCapitaModel
    {
        static int IdCount = 0;

        public int Id { get; set; }

        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Display(Name = "Mobile")]
        public string MobilePhoneNumber { get; set; }
        public string City { get; set; }

        public PerCapitaModel()
        {
            Id = IdCount++;
        }

        static PerCapitaModel ppl1 = new PerCapitaModel { FirstName = "Erik", LastName = "Persson", MobilePhoneNumber = "0701234567", City = "Stockholm" };
        static PerCapitaModel ppl2 = new PerCapitaModel { FirstName = "Pär", LastName = "Johansson", MobilePhoneNumber = "0701234567", City = "Stockholm" };
        static PerCapitaModel ppl3 = new PerCapitaModel { FirstName = "Johan", LastName = "Nilsson", MobilePhoneNumber = "0701234567", City = "Malmö" };
        static PerCapitaModel ppl4 = new PerCapitaModel { FirstName = "Nils", LastName = "Petersson", MobilePhoneNumber = "0701234567", City = "Göteborg" };
        static PerCapitaModel ppl5 = new PerCapitaModel { FirstName = "Tim", LastName = "Eriksson", MobilePhoneNumber = "0701234567", City = "Malmö" };
        static PerCapitaModel ppl6 = new PerCapitaModel { FirstName = "Karl", LastName = "Karlsson", MobilePhoneNumber = "0701234567", City = "Göteborg" };
        static PerCapitaModel ppl7 = new PerCapitaModel { FirstName = "Eva", LastName = "Persson", MobilePhoneNumber = "0701234567", City = "Helsingborg" };
        static PerCapitaModel ppl8 = new PerCapitaModel { FirstName = "Anna", LastName = "Johansson", MobilePhoneNumber = "0701234567", City = "Göteborg" };
        static PerCapitaModel ppl9 = new PerCapitaModel { FirstName = "Mia", LastName = "Persson", MobilePhoneNumber = "07012345672", City = "Malmö" };
        static PerCapitaModel ppl10 = new PerCapitaModel { FirstName = "Fred", LastName = "Nilsson", MobilePhoneNumber = "070123457", City = "Stockholm" };
        static PerCapitaModel ppl11 = new PerCapitaModel { FirstName = "Tore", LastName = "Karlsson", MobilePhoneNumber = "0701234567", City = "Uppsala" };
        static PerCapitaModel ppl12 = new PerCapitaModel { FirstName = "Tuva", LastName = "Eriksson", MobilePhoneNumber = "0701234567", City = "Stockholm" };
        static PerCapitaModel ppl13 = new PerCapitaModel { FirstName = "Nisse", LastName = "Johansson", MobilePhoneNumber = "0701234567", City = "Lund" };
        static PerCapitaModel ppl14 = new PerCapitaModel { FirstName = "Sam", LastName = "Andersson", MobilePhoneNumber = "0701234567", City = "Växjö" };
        static PerCapitaModel ppl15 = new PerCapitaModel { FirstName = "Joar", LastName = "Toresson", MobilePhoneNumber = "0701234567", City = "Lund" };
        static PerCapitaModel ppl16 = new PerCapitaModel { FirstName = "Ulf", LastName = "Eriksson", MobilePhoneNumber = "0701234567", City = "Växjö" };
        static PerCapitaModel ppl17 = new PerCapitaModel { FirstName = "Lisa", LastName = "Johansson", MobilePhoneNumber = "0701234567", City = "Stockholm" };
        static PerCapitaModel ppl18 = new PerCapitaModel { FirstName = "Disa", LastName = "Persson", MobilePhoneNumber = "0701234567", City = "Stockholm" };

        public static List<PerCapitaModel> peopleList = new List<PerCapitaModel>() { ppl1, ppl2, ppl3, ppl4, ppl5, ppl6, ppl7, ppl8, ppl9, ppl10, ppl11, ppl12, ppl13, ppl14, ppl15, ppl16, ppl17, ppl18 };

        //public List<PerCapitaModel> DeleteFromPerCapita(int Id)
        //{
        //    return peopleList;
        //}
    }
}