using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHikkhanobishAPI.Models.Shikkhanobish
{
    public class AnswerVote
    {
        public int ansvoteID { get; set; }
        public string answerID { get; set; }
        public int userID { get; set; }
        public int upOrdownVote { get; set; }
        public string Response { get; set; }
    }
}