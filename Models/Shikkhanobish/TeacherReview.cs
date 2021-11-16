using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHikkhanobishAPI.Models.Shikkhanobish
{
    public class TeacherReview
    {
        public string reviewID { get; set; }
        public int teacherID { get; set; }
        public int studentID { get; set; }
        public string review { get; set; }
        public string tuitionID { get; set; }
        public string Response { get; set; }
    }
}