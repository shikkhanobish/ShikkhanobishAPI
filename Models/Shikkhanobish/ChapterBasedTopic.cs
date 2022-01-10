using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHikkhanobishAPI.Models.Shikkhanobish
{
    public class ChapterBasedTopic
    {
        public int chapterID { get; set; }
        public int topicID { get; set; }
        public string Response { get; set; }
    }
}