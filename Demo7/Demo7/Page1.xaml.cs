using Demo7.ViewModels;
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

            var vm = new UserVM();
            vm.User = new Entities.User() { Id = 1, Firstname = "F1", Lastname = "L1" };
            
            this.BindingContext = vm;

            //Task.Factory.StartNew(() => { Redo(MyAction, vm); });
        }

        public Action<UserVM> MyAction = new Action<UserVM>((vm) =>
        {
            while (true)
            {

                Task.Delay(TimeSpan.FromSeconds(2)).Wait();
                vm.User.Id += 1;
                vm.User.Firstname += "1";
                vm.User.Lastname += "1";
                //vm.User = new Entities.User() { Id = 10, Firstname = "yololo" };
            }

        });

        public void Redo(Action<UserVM> action, UserVM item)
        {
            try
            {
                action.Invoke(item);
            }
            catch (Exception)
            {
                action.Invoke(item);
            }
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