using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHikkhanobishAPI.Models.Shikkhanobish
{
    public class Notification
    {
        public string notificationID { get; set; }
        public int userId { get; set; }
        public int userType { get; set; }
        public int notificationType { get; set; }
        public string description { get; set; }
        public string refID { get; set; }
        public string notificationDate { get; set; }
        public string Response { get; set; }

    }
}