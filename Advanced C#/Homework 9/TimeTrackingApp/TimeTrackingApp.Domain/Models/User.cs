using System;
using System.Collections.Generic;

namespace TimeTrackingApp.Domain.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public double Reading { get; set; }
        public double Exercising { get; set; }
        public double Working { get; set; }
        public double WorkFromHome { get; set; }
        public double WorkFromOffice { get; set; }
        public double OtherHobbies { get; set; }
        public List<string> ListOfOtherHobies { get; set; }
        public ActivityType FavouriteType { get; set; }
        public bool ActiveAcc { get; set; }
        public User(string firstName, string lastName, int age, string username, string password, ActivityType favType)
        {
            ActiveAcc = true;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Username = username;
            Password = password;
            Reading = 0;
            Exercising = 0;
            Working = 0;
            OtherHobbies = 0;
            FavouriteType = favType;
        }
        public override void GetInfo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Login successful!");
            Console.ResetColor();
        }
    }
}
