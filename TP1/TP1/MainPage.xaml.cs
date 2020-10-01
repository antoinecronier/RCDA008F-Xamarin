using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Services;
using TP1.Views;
using Xamarin.Forms;

namespace TP1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private const string LOGIN_ERROR = "Login invalide, doit contenir au moins 3 caractères";
        private const string PASSWORD_ERROR = "Password invalide, doit contenir au moins 6 caractères";
        private const string AUTH_FAILED = "Authentication failed";
        private const string INTERNET_FAILED = "No internet connection";

        private ITwitterService twitterService;

        public MainPage()
        {
            this.twitterService = new TwitterService();
            InitializeComponent();
            this.TwitterConnect.Clicked += TwitterConnect_Clicked;
            this.LoadTweets(this.StacklayoutTweets);
        }

        private void LoadTweets(StackLayout stacklayoutTweets)
        {
            foreach (var item in twitterService.GetTweets())
            {
                stacklayoutTweets.Children.Add(new TweetView().LoadData(item));
            }
        }

        private void TwitterConnect_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Clicked");
            var testLogin = true;
            var testPassword = true;
            var testAuth = true;
            var testInternet = true;

            StringBuilder builder = new StringBuilder();

            if (this.TwitterLogin.Text == null || this.TwitterLogin.Text.Length < 3)
            {
                testLogin = false;
                builder.Append(LOGIN_ERROR);
            }

            if (string.IsNullOrEmpty(this.TwitterPassword.Text) || this.TwitterPassword.Text.Length < 6)
            {
                testPassword = false;
                if (!testLogin)
                {
                    builder.Append("\n");
                }
                builder.Append(PASSWORD_ERROR);
            }

            if (testLogin && testPassword)
            {
                if (Xamarin.Essentials.Connectivity.NetworkAccess == Xamarin.Essentials.NetworkAccess.Internet)
                {
                    if (this.twitterService.Authenticate(this.TwitterLogin.Text, this.TwitterPassword.Text))
                    {
                        this.ListTweets.IsVisible = !this.ListTweets.IsVisible;
                        this.ConnectionForm.IsVisible = false;
                        this.ErrorsLabel.IsVisible = false;
                    }
                    else
                    {
                        if (!testLogin || !testPassword)
                        {
                            builder.Append("\n");
                        }
                        builder.Append(AUTH_FAILED);
                        testAuth = false;
                    }
                }
                else
                {
                    if (!testLogin || !testPassword || !testAuth)
                    {
                        builder.Append("\n");
                    }
                    builder.Append(INTERNET_FAILED);
                    testInternet = false;
                }
            }

            if (!testLogin || !testPassword || !testAuth || ! testInternet)
            {
                this.ErrorsLabel.Text = builder.ToString();
                this.ErrorsLabel.IsVisible = true;
            }
        }
    }
}
