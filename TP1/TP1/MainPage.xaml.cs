using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public MainPage()
        {
            InitializeComponent();
            this.TwitterConnect.Clicked += TwitterConnect_Clicked;
        }

        private void TwitterConnect_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Clicked");
            var testLogin = true;
            var testPassword = true;
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

            if (!testLogin || !testPassword)
            {
                this.ErrorsLabel.Text = builder.ToString();
                this.ErrorsLabel.IsVisible = true;
            }

            if (testLogin && testPassword)
            {
                this.ListTweets.IsVisible = !this.ListTweets.IsVisible;
                this.ConnectionForm.IsVisible = false;
                this.ErrorsLabel.IsVisible = false;
            }
        }
    }
}
