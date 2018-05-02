using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace ChristiansWebPage.Models
{
    public class PerCapitaByAjax
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

        public PerCapitaByAjax()
        {
            Id = IdCount++;
        }

        static PerCapitaByAjax ppl1 = new PerCapitaByAjax { FirstName = "Erik", LastName = "Persson", MobilePhoneNumber = "0701234567", City = "Stockholm" };
        static PerCapitaByAjax ppl2 = new PerCapitaByAjax { FirstName = "Pär", LastName = "Johansson", MobilePhoneNumber = "0701234567", City = "Stockholm" };
        static PerCapitaByAjax ppl3 = new PerCapitaByAjax { FirstName = "Johan", LastName = "Nilsson", MobilePhoneNumber = "0701234567", City = "Malmö" };
        static PerCapitaByAjax ppl4 = new PerCapitaByAjax { FirstName = "Nils", LastName = "Petersson", MobilePhoneNumber = "0701234567", City = "Göteborg" };
        static PerCapitaByAjax ppl5 = new PerCapitaByAjax { FirstName = "Tim", LastName = "Eriksson", MobilePhoneNumber = "0701234567", City = "Malmö" };
        static PerCapitaByAjax ppl6 = new PerCapitaByAjax { FirstName = "Karl", LastName = "Karlsson", MobilePhoneNumber = "0701234567", City = "Göteborg" };
        static PerCapitaByAjax ppl7 = new PerCapitaByAjax { FirstName = "Eva", LastName = "Persson", MobilePhoneNumber = "0701234567", City = "Helsingborg" };
        static PerCapitaByAjax ppl8 = new PerCapitaByAjax { FirstName = "Anna", LastName = "Johansson", MobilePhoneNumber = "0701234567", City = "Göteborg" };
        static PerCapitaByAjax ppl9 = new PerCapitaByAjax { FirstName = "Mia", LastName = "Persson", MobilePhoneNumber = "07012345672", City = "Malmö" };
        static PerCapitaByAjax ppl10 = new PerCapitaByAjax { FirstName = "Fred", LastName = "Nilsson", MobilePhoneNumber = "070123457", City = "Stockholm" };
        static PerCapitaByAjax ppl11 = new PerCapitaByAjax { FirstName = "Tore", LastName = "Karlsson", MobilePhoneNumber = "0701234567", City = "Uppsala" };
        static PerCapitaByAjax ppl12 = new PerCapitaByAjax { FirstName = "Tuva", LastName = "Eriksson", MobilePhoneNumber = "0701234567", City = "Stockholm" };
        static PerCapitaByAjax ppl13 = new PerCapitaByAjax { FirstName = "Nisse", LastName = "Johansson", MobilePhoneNumber = "0701234567", City = "Lund" };
        static PerCapitaByAjax ppl14 = new PerCapitaByAjax { FirstName = "Sam", LastName = "Andersson", MobilePhoneNumber = "0701234567", City = "Växjö" };
        static PerCapitaByAjax ppl15 = new PerCapitaByAjax { FirstName = "Joar", LastName = "Toresson", MobilePhoneNumber = "0701234567", City = "Lund" };
        static PerCapitaByAjax ppl16 = new PerCapitaByAjax { FirstName = "Ulf", LastName = "Eriksson", MobilePhoneNumber = "0701234567", City = "Växjö" };
        static PerCapitaByAjax ppl17 = new PerCapitaByAjax { FirstName = "Lisa", LastName = "Johansson", MobilePhoneNumber = "0701234567", City = "Stockholm" };
        static PerCapitaByAjax ppl18 = new PerCapitaByAjax { FirstName = "Disa", LastName = "Persson", MobilePhoneNumber = "0701234567", City = "Stockholm" };

        public static List<PerCapitaByAjax> peopleList = new List<PerCapitaByAjax>() { ppl1, ppl2, ppl3, ppl4, ppl5, ppl6, ppl7, ppl8, ppl9, ppl10, ppl11, ppl12, ppl13, ppl14, ppl15, ppl16, ppl17, ppl18 };
        public static List<PerCapitaByAjax> backupOfPeopleList = peopleList;

        public static List<PerCapitaByAjax> FilterAPeopleList(string searchString)
        {
            List<PerCapitaByAjax> newPeopleList = new List<PerCapitaByAjax>();
            if (searchString == "")
            {
                peopleList = backupOfPeopleList;
            }
            else
            {
                for (int i = 0; i < peopleList.Count; i++)
                {
                    searchString = searchString.ToLower();
                    if (peopleList[i].FirstName.ToLower() == searchString)
                    {
                        newPeopleList.Add(peopleList[i]);
                    }
                    else if (peopleList[i].LastName.ToLower() == searchString)
                    {
                        newPeopleList.Add(peopleList[i]);
                    }
                    else if (peopleList[i].City.ToLower() == searchString)
                    {
                        newPeopleList.Add(peopleList[i]);
                    }

                }
                peopleList = newPeopleList;
            }
            return newPeopleList;
        }

        public static List<PerCapitaByAjax> SortAPeopleListOnFirstName()
        {
            peopleList.Sort((x, y) => x.FirstName.CompareTo(y.FirstName));
            return peopleList;
        }
        public static List<PerCapitaByAjax> SortAPeopleListOnLastName()
        {
            peopleList.Sort((x, y) => x.LastName.CompareTo(y.LastName));
            return peopleList;
        }
        public static List<PerCapitaByAjax> SortAPeopleListOnCity()
        {
            peopleList.Sort((x, y) => x.City.CompareTo(y.City));
            return peopleList;
        }

    }
}