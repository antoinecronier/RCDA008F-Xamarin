using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace Demo4
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private CancellationTokenSource ct;

        public MainPage()
        {
            InitializeComponent();
            this.AwesomeBtn.Clicked += AwesomeBtn_Clicked;
            //this.AwesomeBtn.Focused += AwesomeBtn_Focused;

            ct = new CancellationTokenSource();
            Task.Factory.StartNew(() =>
            {
                while (!ct.IsCancellationRequested)
                {
                    Task.Delay(TimeSpan.FromSeconds(1)).Wait();
                    RandomMove();
                    RandomColor();
                }
            }, ct.Token);
        }

        private void RandomColor()
        {
            Random rand = new Random();
            Xamarin.Essentials.MainThread.BeginInvokeOnMainThread(() =>
            {
                this.AwesomeBtn.BackgroundColor = Color.FromRgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
            });
         }

        //private void AwesomeBtn_Focused(object sender, FocusEventArgs e)
        //{
        //    Task.Factory.StartNew(() =>
        //    {
        //        //for (int i = 0; i < 200; i++)
        //        //{
        //        Task.Delay(TimeSpan.FromMilliseconds(2)).Wait();
        //        RandomMove();
        //        //}
        //    });
        //}

        private void AwesomeBtn_Clicked(object sender, EventArgs e)
        {

            //Task.Factory.StartNew(() =>
            //{
            //    //for (int i = 0; i < 200; i++)
            //    //{
            //        Task.Delay(TimeSpan.FromMilliseconds(2)).Wait();
            //        RandomMove();
            //    //}
            //});
            ct.Cancel();
        }

        private void RandomMove()
        {
            var height = this.Height - this.AwesomeBtn.Height;
            var width = this.Width - this.AwesomeBtn.Width;

            Random rand = new Random();
            Xamarin.Essentials.MainThread.BeginInvokeOnMainThread(() =>
            {
                RelativeLayout.SetYConstraint(this.AwesomeBtn, Constraint.Constant(rand.Next(0, Convert.ToInt32(height))));
                RelativeLayout.SetXConstraint(this.AwesomeBtn, Constraint.Constant(rand.Next(0, Convert.ToInt32(width))));
            });
        }
    }
}
