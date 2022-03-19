using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHikkhanobishAPI.Models.Shikkhanobish
{
    public class studentSubjectPurchase
    {
        public int studentID { get; set; }
        public int subjectID { get; set; }
        public int chapterID { get; set; }
        public int topicID { get; set; }
        public string date { get; set; }
        public int isTuitionComplete { get; set; }
        public string Response { get; set; }
    }
}