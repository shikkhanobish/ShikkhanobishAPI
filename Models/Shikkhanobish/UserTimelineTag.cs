﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHikkhanobishAPI.Models.Shikkhanobish
{
    public class UserTimelineTag
    {
        public int userID { get; set; }
        public int tagID { get; set; }
        public string Response { get; set; }
    }
}