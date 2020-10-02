using CommonServiceLocator;
using Demo7.ViewModels;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo7.Configurations
{
    public class ViewModelLocator
    {
        public enum Pages
        {
            Page1,
            Page2,
            Page3,
            ListViewPage
        }

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<INavigationService>(() =>
            {
                var navigationService = NavigationService.Instance;
                navigationService.Configure(Pages.Page1.ToString(), typeof(Page1));
                navigationService.Configure(Pages.Page2.ToString(), typeof(Page2));
                navigationService.Configure(Pages.Page3.ToString(), typeof(Page3));
                navigationService.Configure(Pages.ListViewPage.ToString(), typeof(ListViewPage));
                return navigationService;
            });

            //SimpleIoc.Default.Register<ITwitterService>(() =>
            //{
            //    return new TwitterService();
            //});

            SimpleIoc.Default.Register<UserVM>();
        }

        public UserVM UserViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<UserVM>();
            }
        }
    }
}
