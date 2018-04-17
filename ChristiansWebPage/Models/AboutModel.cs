using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChristiansWebPage.Models
{
    public class AboutModel
    {
        public int AboutObjectID { get; set; }
        public string ObjectType { get; set; }
        public string ObjectName { get; set; }
        public string ObjectDescription { get; set; }
        public int StartYear { get; set; }
        public int StartMonth { get; set; }
        public int StartDay { get; set; }
        public int EndYear { get; set; }
        public int EndMonth { get; set; }
        public int EndDay { get; set; }
    }
}