using Demo7.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo7
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<User> users;
        private User currentUser;

        public MainPage()
        {
            InitializeComponent();

            this.UserList.ItemTapped += UserList_ItemTapped;
            this.UserList.ChildRemoved += UserList_ChildRemoved;


            Role role1 = new Role { Id = 1, Name = "role 1" };
            Role role2 = new Role { Id = 2, Name = "role 2" };
            users = new ObservableCollection<User>();
            for (int i = 0; i < 20; i++)
            {
                users.Add(new User { Id = i, Firstname = "F" + i, Lastname = "L" + i, DoB = DateTime.Now, Role = i % 2 == 0 ? role1 : role2 });
            }
            //ObservableCollection<Role> roles = new ObservableCollection<Role>();
            //for (int i = 0; i < 20; i++)
            //{
            //    roles.Add(new Role { Id = i, Name = "N" + i });
            //}
            this.UserList.ItemsSource = users;

            //Task.Factory.StartNew(() =>
            //{
            //    for (int i = 0; i < 2000000; i++)
            //    {
            //        Xamarin.Essentials.MainThread.BeginInvokeOnMainThread(() =>
            //        {
            //            users.Add(new User { Id = i, Firstname = "F" + i, Lastname = "L" + i, DoB = DateTime.Now, Role = i % 2 == 0 ? role1 : role2 });
            //        });
            //    }
            //});
        }

        private void UserList_ChildRemoved(object sender, ElementEventArgs e)
        {
            currentUser.Id = users.Max(x => x.Id) + 1;
            users.Add(currentUser);
        }

        private void UserList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            currentUser = e.Item as User;
            users.Remove(currentUser);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
