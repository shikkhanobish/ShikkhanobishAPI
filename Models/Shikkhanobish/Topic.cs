using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHikkhanobishAPI.Models.Shikkhanobish
{
    public class Topic
    {
        public int topicID { get; set; }
        public int chapterID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int purchaseRate { get; set; }
        public string Response { get; set; }

    }
}