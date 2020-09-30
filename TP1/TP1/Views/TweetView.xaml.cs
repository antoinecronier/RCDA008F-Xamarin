using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetView : ContentView
    {
        public TweetView()
        {
            InitializeComponent();
        }

        public TweetView LoadData(Tweet item)
        {
            this.Author.Text = item.UserName;
            this.Data.Text = item.Text;
            this.Email.Text = item.UserId;
            this.LastUpdate.Text = item.CreationDate;

            return this;
        }
    }
}