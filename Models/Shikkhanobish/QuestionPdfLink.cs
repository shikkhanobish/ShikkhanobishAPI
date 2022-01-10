using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHikkhanobishAPI.Models.Shikkhanobish
{
    public class QuestionPdfLink
    {
        public int chapterID { get; set; }
        public string link { get; set; }
        public int noOfQues { get; set; }
        public string Response { get; set; }
    }
}