using System;
using System.Collections.Generic;
using System.Text;

namespace Demo7.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DoB { get; set; }
        public Role Role { get; set; }
        public int Age
        {
            get { return (DateTime.Now - this.DoB).Days / 365; }
        }

    }
}
