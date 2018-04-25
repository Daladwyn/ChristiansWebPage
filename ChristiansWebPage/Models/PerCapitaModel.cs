using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace ChristiansWebPage.Models
{
    public class PerCapitaModel
    {
        public int Id { get; set; }

        [Display(Name="First name")]
        public string FirstName { get; set; }
        [Display(Name ="Last name")]
        public string LastName { get; set; }
        [Display(Name ="Mobile")]
        public int MobilePhoneNumber { get; set; }
        public string Cities { get; set; }

        static PerCapitaModel ppl1 = new PerCapitaModel { Id = 1, FirstName = "Erik", LastName = "Persson", MobilePhoneNumber = 0701234567, Cities = "Stockholm" };
        static PerCapitaModel ppl2 = new PerCapitaModel { Id = 2, FirstName = "Pär", LastName = "Johansson", MobilePhoneNumber = 0701234567, Cities = "Stockholm" };
        static PerCapitaModel ppl3 = new PerCapitaModel { Id = 3, FirstName = "Johan", LastName = "Nilsson", MobilePhoneNumber = 0701234567, Cities = "Malmö" };
        static PerCapitaModel ppl4 = new PerCapitaModel { Id = 4, FirstName = "Nils", LastName = "Petersson", MobilePhoneNumber = 0701234567, Cities = "Göteborg" };
        static PerCapitaModel ppl5 = new PerCapitaModel { Id = 5, FirstName = "Tim", LastName = "Eriksson", MobilePhoneNumber = 0701234567, Cities = "Malmö" };
        static PerCapitaModel ppl6 = new PerCapitaModel { Id = 6, FirstName = "Karl", LastName = "Karlsson", MobilePhoneNumber = 0701234567, Cities = "Göteborg" };
        static PerCapitaModel ppl7 = new PerCapitaModel { Id = 7, FirstName = "Eva", LastName = "Persson", MobilePhoneNumber = 0701234567, Cities = "Helsingborg" };
        static PerCapitaModel ppl8 = new PerCapitaModel { Id = 8, FirstName = "Anna", LastName = "Johansson", MobilePhoneNumber = 0701234567, Cities = "Göteborg" };
        static PerCapitaModel ppl9 = new PerCapitaModel { Id = 9, FirstName = "Mia", LastName = "Persson", MobilePhoneNumber = 0701234567, Cities = "Malmö" };
        static PerCapitaModel ppl10 = new PerCapitaModel { Id = 10, FirstName = "Fred", LastName = "Nilsson", MobilePhoneNumber = 0701234567, Cities = "Stockholm" };
        static PerCapitaModel ppl11 = new PerCapitaModel { Id = 11, FirstName = "Tore", LastName = "Karlsson", MobilePhoneNumber = 0701234567, Cities = "Uppsala" };
        static PerCapitaModel ppl12 = new PerCapitaModel { Id = 12, FirstName = "Tuva", LastName = "Eriksson", MobilePhoneNumber = 0701234567, Cities = "Stockholm" };
        static PerCapitaModel ppl13 = new PerCapitaModel { Id = 13, FirstName = "Nisse", LastName = "Johansson", MobilePhoneNumber = 0701234567, Cities = "Lund" };
        static PerCapitaModel ppl14 = new PerCapitaModel { Id = 14, FirstName = "Sam", LastName = "Andersson", MobilePhoneNumber = 0701234567, Cities = "Växjö" };
        static PerCapitaModel ppl15 = new PerCapitaModel { Id = 15, FirstName = "Joar", LastName = "Toresson", MobilePhoneNumber = 0701234567, Cities = "Lund" };
        static PerCapitaModel ppl16 = new PerCapitaModel { Id = 16, FirstName = "Ulf", LastName = "Eriksson", MobilePhoneNumber = 0701234567, Cities = "Växjö" };
        static PerCapitaModel ppl17 = new PerCapitaModel { Id = 17, FirstName = "Lisa", LastName = "Johansson", MobilePhoneNumber = 0701234567, Cities = "Stockholm" };
        static PerCapitaModel ppl18 = new PerCapitaModel { Id = 18, FirstName = "Disa", LastName = "Persson", MobilePhoneNumber = 0701234567, Cities = "Stockholm" };

        public static List<PerCapitaModel> peopleList = new List<PerCapitaModel> { ppl1, ppl2, ppl3, ppl4, ppl5, ppl6, ppl7, ppl8, ppl9, ppl10, ppl11, ppl12, ppl13, ppl14, ppl15, ppl16, ppl17, ppl18 };


    }
}