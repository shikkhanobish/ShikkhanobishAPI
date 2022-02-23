using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHikkhanobishAPI.Models.Shikkhanobish
{
    public class TuiTionLog
    {
        public string tuitionLogID { get; set; }
        public string studentName { get; set; }
        public string subjectname { get; set; }
        public int subjectID { get; set; }
        public string description { get; set; }
        public string date { get; set; }
        public int studentID { get; set; }
        public int tuitionLogStatus { get; set; }
        public int chapterID { get; set; }
        public string chapterName { get; set; }
        public int pendingTeacherID { get; set; }
        public string Response { get; set; }
        public int isTextOrVideo { get; set; }
        public string img1 { get; set; }
        public string img2 { get; set; }
        public string img3 { get; set; }
        public string img4 { get; set; }
        public int approval { get; set; }
        public string teacherID { get; set; }
        public string teacherName { get; set; }
        public string ansText { get; set; }
        public string ansImg { get; set; }
        public string ansVideo { get; set; }
        public string startingDate { get; set; }
    }
}