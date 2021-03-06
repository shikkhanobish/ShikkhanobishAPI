using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHikkhanobishAPI.Models.Shikkhanobish
{
    public class CreativeQuestion
    {
        public string cQuestionID { get; set; }
        public int classID { get; set; }
        public int subjectID { get; set; }
        public int chapterID { get; set; }
        public int topicID { get; set; }
        public string mainQuestion { get; set; }
        public string firstQuestion { get; set; }
        public string secondQuestion { get; set; }
        public string thirdQuestion { get; set; }
        public string forthQuestion { get; set; }
        public string firstqsImg { get; set; }
        public string secodqsImg { get; set; }
        public string thirdqsImg { get; set; }
        public string forthqsImg { get; set; }
        public string firstqsAns { get; set; }
        public string secondqsAns { get; set; }
        public string thirqsAns { get; set; }
        public string forthqsAns { get; set; }
        public string firstqsAnsImg { get; set; }
        public string secondqsAnsImg { get; set; }
        public string thirqsAnsImg { get; set; }
        public string forthqsAnsImg { get; set; }
        public int review { get; set; }
        public string Response { get; set; }
    }
}