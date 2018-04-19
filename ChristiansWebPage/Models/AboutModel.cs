using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChristiansWebPage.Models
{
    public class AboutModel
    {
        public int CvId { get; set; }
        public string CvType { get; set; }
        public string CvName { get; set; }
        public string CvDescription { get; set; }
        public int CvStartYear { get; set; }
        public int CvStartMonth { get; set; }
        public int CvStartDay { get; set; }
        public int CvEndYear { get; set; }
        public int CvEndMonth { get; set; }
        public int CvEndDay { get; set; }
    }
}