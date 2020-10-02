using Demo7.Entities;
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
	}
}
