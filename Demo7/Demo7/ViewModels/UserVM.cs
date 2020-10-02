using Demo7.Entities;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo7.ViewModels
{
    public class UserVM : BaseEntity
    {
		private User user;

		public User User
		{
			get { return user; }
			set 
			{ 
				user = value;
			}
		}

		private INavigationService navigation;
		private double rotationX;

		public double RotationX
		{
			get { return rotationX; }
			set
			{
				rotationX = value;
				OnPropertyChanged("RotationX");
			}
		}
		private double rotationY;

		public double RotationY
		{
			get { return rotationY; }
			set
			{
				rotationY = value;
				OnPropertyChanged("RotationY");
			}
		}
		private double rotation;

		public double Rotation
		{
			get { return rotation; }
			set
			{
				rotation = value;
				OnPropertyChanged("Rotation");
			}
		}

		public RelayCommand Click1
		{
			get
			{
				return new RelayCommand(() =>
				{
					if (this.navigation.CurrentPageKey == Configurations.ViewModelLocator.Pages.Page2.ToString())
					{
						this.navigation.NavigateTo(Configurations.ViewModelLocator.Pages.Page1.ToString());
					}
					else if (this.navigation.CurrentPageKey == Configurations.ViewModelLocator.Pages.Page1.ToString())
					{
						this.navigation.NavigateTo(Configurations.ViewModelLocator.Pages.Page2.ToString());
					}
				});
			}
		}
		public RelayCommand Click2
		{
			get
			{
				return new RelayCommand(() =>
				{
					if (this.navigation.CurrentPageKey == Configurations.ViewModelLocator.Pages.Page2.ToString())
					{
						this.navigation.NavigateTo(Configurations.ViewModelLocator.Pages.Page3.ToString());
					}
					else if (this.navigation.CurrentPageKey == Configurations.ViewModelLocator.Pages.Page1.ToString())
					{
						this.navigation.NavigateTo(Configurations.ViewModelLocator.Pages.Page3.ToString());
					}
				});
			}
		}

		public UserVM(INavigationService navigation)
		{
			this.User = new User() { Id = 100, Firstname = "F10", Lastname = "L10" };
			this.navigation = navigation;
		}
	}
}
