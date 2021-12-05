using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHikkhanobishAPI.Models.Shikkhanobish
{
    public class StudentMCQAns
    {
        public string sMCQAnsID { get; set; }
        public int studentID { get; set; }
        public string questionID { get; set; }
        public int isRight { get; set; }
        public string ansDate { get; set; }
        public string Response { get; set; }
    }
}