using System;
using System.Collections.Generic;
using System.Text;

namespace TP1.Models
{
    public class Tweet
    {
        public string Identifiant { get; set; }
        public string CreationDate { get; set; }
        public string Text { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
        public string UserPseudo { get; set; }
    }
}
