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
                new Tweet(){ CreationDate = "", Identifiant = "", Text = "", UserId = "", UserName = "", UserPseudo = "" },
                new Tweet(){ CreationDate = "", Identifiant = "", Text = "", UserId = "", UserName = "", UserPseudo = "" },
                new Tweet(){ CreationDate = "", Identifiant = "", Text = "", UserId = "", UserName = "", UserPseudo = "" },
                new Tweet(){ CreationDate = "", Identifiant = "", Text = "", UserId = "", UserName = "", UserPseudo = "" },
                new Tweet(){ CreationDate = "", Identifiant = "", Text = "", UserId = "", UserName = "", UserPseudo = "" },
                new Tweet(){ CreationDate = "", Identifiant = "", Text = "", UserId = "", UserName = "", UserPseudo = "" },
                new Tweet(){ CreationDate = "", Identifiant = "", Text = "", UserId = "", UserName = "", UserPseudo = "" },
                new Tweet(){ CreationDate = "", Identifiant = "", Text = "", UserId = "", UserName = "", UserPseudo = "" }
            };
        }
    }
}
