using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHikkhanobishAPI.Models.Shikkhanobish
{
    public class shiEmployee
    {
        public int employeeID { get; set; }
        public int employeeType { get; set; }
        public string name { get; set; }
        public string phonenumber { get; set; }
        public string Response { get; set; }
    }
}