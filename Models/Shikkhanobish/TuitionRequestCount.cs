using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHikkhanobishAPI.Models.Shikkhanobish
{
    public class TuitionRequestCount
    {
        public int teacherID { get; set; }
        public string tuitionID { get; set; }
        public string Response { get; set; }
    }
}