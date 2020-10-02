using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Demo7.Entities
{
    public abstract class BaseEntity : INotifyPropertyChanged
    {
		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string name)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(name));
			}
		}
	}
}
