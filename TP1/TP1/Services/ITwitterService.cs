using System;
using System.Collections.Generic;
using System.Text;
using TP1.Models;

namespace TP1.Services
{
    public interface ITwitterService
    {
        bool Authenticate(string login, string password);

        List<Tweet> GetTweets();
    }
}
