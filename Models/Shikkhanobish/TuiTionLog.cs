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
    }
}