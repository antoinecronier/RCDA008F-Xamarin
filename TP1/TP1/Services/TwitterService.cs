using System;
using System.Collections.Generic;
using System.Text;
using TP1.Models;

namespace TP1.Services
{
    public class TwitterService : ITwitterService
    {
        public bool Authenticate(string login, string password)
        {
            bool result = false;

            if (login.Equals("test") && password.Equals("password"))
            {
                result = true;
            }

            return result;
        }

        public List<Tweet> GetTweets()
        {
            return new List<Tweet>()
            {
                new Tweet(){ CreationDate = "20s", Identifiant = "", Text = "a", UserId = "@aze", UserName = "aze", UserPseudo = "" },
                new Tweet(){ CreationDate = "30s", Identifiant = "", Text = "b", UserId = "@eaz", UserName = "eaz", UserPseudo = "" },
                new Tweet(){ CreationDate = "40s", Identifiant = "", Text = "c", UserId = "@eza", UserName = "eza", UserPseudo = "" },
                new Tweet(){ CreationDate = "50s", Identifiant = "", Text = "d", UserId = "@zae", UserName = "zae", UserPseudo = "" },
                new Tweet(){ CreationDate = "60s", Identifiant = "", Text = "e", UserId = "@ezd", UserName = "ezd", UserPseudo = "" },
                new Tweet(){ CreationDate = "70s", Identifiant = "", Text = "f", UserId = "@opi", UserName = "opi", UserPseudo = "" },
                new Tweet(){ CreationDate = "80s", Identifiant = "", Text = "g", UserId = "@mld", UserName = "mld", UserPseudo = "" },
                new Tweet(){ CreationDate = "90s", Identifiant = "", Text = "qsdoijfqopisodpi pqopsodp oqisoipdpo iqspojdpo iqsiopdj oihqspodio qsid iqsohd", UserId = "@test", UserName = "test", UserPseudo = "" }
            };
        }
    }
}
