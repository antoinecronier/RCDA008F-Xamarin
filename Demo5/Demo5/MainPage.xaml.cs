using Demo5.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Demo5
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.MyBtn.Clicked += MyBtn_ClickedOld;
        }

        private async void MyBtn_ClickedNew(object sender, EventArgs e)
        {
            var locales = await TextToSpeech.GetLocalesAsync();

            // Grab the first locale
            var locale = locales.ElementAt(2);

            var settings = new SpeechOptions()
            {
                Volume = .25f,
                Pitch = 1.0f,
                Locale = locale
            };

            Xamarin.Essentials.TextToSpeech.SpeakAsync(this.TxtToRead.Text, settings);
        }

        private async void MyBtn_ClickedOld(object sender, EventArgs e)
        {
            DependencyService.Get<ITextToSpeech>().Speak(this.TxtToRead.Text);
        }
    }
}
