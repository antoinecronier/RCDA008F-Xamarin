using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            this.btn1.Clicked += Btn1_Clicked;
            this.btn2.Clicked += Btn2_Clicked;
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
            //Navigation.PushModalAsync(new Page3());
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }
}