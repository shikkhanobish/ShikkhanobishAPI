using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHikkhanobishAPI.Models.Shikkhanobish
{
    public class StudentEvaluation
    {
        public string evaluationID { get; set; }
        public int studentID { get; set; }
        public int classID { get; set; }
        public int subjectID { get; set; }
        public int chapterID { get; set; }
        public int accuracy { get; set; }
        public double speed { get; set; }
        public int numberOFAns { get; set; }
        public int correctAns { get; set; }
        public string Response { get; set; }
    }
}