using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHikkhanobishAPI.Models.Shikkhanobish
{
    public class Question
    {
        public int questionID { get; set; }
        public int classID { get; set; }
        public int subjectID { get; set; }
        public int chapterID { get; set; }
        public int topicID { get; set; }
        public string mainQuestion { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string option3 { get; set; }
        public string option4 { get; set; }
        public string opOneImg { get; set; }
        public string opTwoImg { get; set; }
        public string opThreeImg { get; set; }
        public string opFourImg { get; set; }
        public int rightAnswer { get; set; }
        public string quesImages { get; set; }
        public int review { get; set; }
        public string Response { get; set; }
    }
}