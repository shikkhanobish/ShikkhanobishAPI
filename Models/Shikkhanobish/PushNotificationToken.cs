using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHikkhanobishAPI.Models.Shikkhanobish
{
    public class PushNotificationToken
    {
        public int pushNtID { get; set; }
        public int userID { get; set; }
        public int userType { get; set; }
        public string token { get; set; }
        public string Response { get; set; }
    }
}