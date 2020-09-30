using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tp4.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tweet : ContentView
    {
        public Tweet()
        {
            InitializeComponent();
        }

        public Tweet LoadData(Entities.Tweet tweet)
        {
            this.author.Text = tweet.User.Login;
            this.content.Text = tweet.Data;
            this.email.Text = tweet.User.Email;
            this.timeposted.Text = ComputeTime(tweet.CreatedAt);
            return this;
        }

        private string ComputeTime(DateTime createdAt)
        {
            StringBuilder result = new StringBuilder();

            var temp = DateTime.Now - createdAt;
            if (temp.TotalSeconds <= 999)
            {
                result.Append(Convert.ToInt32(temp.TotalSeconds));
                result.Append("s");
            }
            else if (temp.TotalMinutes <= 999)
            {
                result.Append(Convert.ToInt32(temp.TotalHours));
                result.Append("m");
            }
            else if (temp.TotalDays <= 999)
            {
                result.Append(Convert.ToInt32(temp.TotalDays));
                result.Append("d");
            }
            else
            {
                result.Append(Convert.ToInt32(temp.TotalDays / 365));
                result.Append("y");
            }

            return result.ToString();
        }
    }
}