using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetsPage : ContentPage
    {
        public TweetsPage()
        {
            InitializeComponent();
            this.ListViewTweets.ItemsSource = new TwitterService().GetTweets();
        }
    }
}