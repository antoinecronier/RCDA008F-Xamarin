using Demo7.Entities;
using Demo7.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Demo7.Data
{
    public class Demo7DbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public Demo7DbContext() : base()
        {
            if (this.Database.EnsureCreated())
            {
                Role role1 = new Role { Name = "role 1" };
                Role role2 = new Role { Name = "role 2" };
                var users = new List<User>();
                for (int i = 0; i < 20; i++)
                {
                    users.Add(new User { Firstname = "F" + i, Lastname = "L" + i, DoB = DateTime.Now, Role = i % 2 == 0 ? role1 : role2 });
                }
                this.Users.AddRange(users);
                this.SaveChanges();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = DependencyService.Get<IFileHelper>().GetLocalFilePath("MyDb.db3");
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Code fluent API
        }
    }
}
