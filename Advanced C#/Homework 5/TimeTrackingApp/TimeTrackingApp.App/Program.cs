using System;
using TimeTrackingApp.Domain;
using TimeTrackingApp.Domain.Database;
using TimeTrackingApp.Domain.Models;
using TimeTrackingApp.Services.Implementations;
using TimeTrackingApp.Services.Interfaces;

namespace TimeTrackingApp.App
{
    class Program
    {
        public static void FirstPage()
        {
            Console.Clear();
            Console.WriteLine("Time Tracking App");

            Console.WriteLine("Please choose one of the following options:\n");
            Console.WriteLine("1. Log in\n2. Register\n3. Exit");
            Console.WriteLine("Press 1 to Log in to your account\nPress 2 to create a new account\nPress 3 to exit");
            bool flag = true;
            while (flag)
            {
                bool validationFirstPageChoice = int.TryParse(Console.ReadLine(), out int firstPageChoice);
                if (validationFirstPageChoice)
                {
                    if (firstPageChoice == 1)
                    {
                        if (_userService.LogIn() < 1)
                        {
                            FirstPage();
                        }
                        else
                        {
                            FirstPage();
                            flag = false;
                        }
                    }
                    else if (firstPageChoice == 2)
                    {
                        _userService.Register();
                        Console.ReadKey();
                        FirstPage();
                        flag = false;
                    }
                    else if (firstPageChoice == 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error bad input !\nTry Again.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error bad input !\nTry Again.");
                    Console.ResetColor();
                }
            }
        }
        public static IUserService<User> _userService = new UserService<User>();
        static void Main(string[] args)
        {
            _userService.AddUser(new User("Aleksandar", "Ivanovski", 26, "Aleksandar123", "Aleksandar123", ActivityType.Exercising));
            _userService.AddUser(new User("Elena", "Betinska", 22, "Elena123", "Elena123", ActivityType.Reading));
            _userService.AddUser(new User("Viktor", "Stojkov", 26, "Viktor123", "Viktor123", ActivityType.Working));
            _userService.AddUser(new User("Mila", "Velkovska", 22, "Mila123", "Mila123", ActivityType.OtherHobbies));
            _userService.AddUser(new User("Marija", "Mladenovska", 22, "Marija123", "Marija123", ActivityType.Reading));
            _userService.AddUser(new User("Danilo", "Borozan", 23, "Danilo123", "Danilo123", ActivityType.Exercising));

            FirstPage();
        }
    }
}
