using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHikkhanobishAPI.Models.Shikkhanobish
{
    public class dataentryOperatorTask
    {
        public int userID { get; set; }
        public string taskID { get; set; }
        public int chapterID { get; set; }
        public string MCQNumbers { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public string date { get; set; }
        public string Response { get; set; }

    }
}