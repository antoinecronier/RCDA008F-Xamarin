using System;
using System.Collections.Generic;
using System.Text;

namespace Demo7.Entities
{
    public class User : BaseEntity
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { 
                id = value;
                OnPropertyChanged("Id");
            }
        }

        private string firstname;

        public string Firstname
        {
            get { return firstname; }
            set { 
                firstname = value;
                OnPropertyChanged("Firstname");
            }
        }

        private string lastname;

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public DateTime DoB { get; set; }
        public Role Role { get; set; }
        public int Age
        {
            get { return (DateTime.Now - this.DoB).Days / 365; }
        }

    }
}
