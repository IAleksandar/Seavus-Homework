using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeTrackingApp.Domain.Models;

namespace TimeTrackingApp.Services.Helpers
{
    public static class ValidationHelper
    {
        public static bool ValidateUsername(User user)
        {

            if (user.Username.Length < 5)
            {
                Console.WriteLine("Username should not be shorter than 5 characters.");
                return false;
            }
            else
            {
                Console.WriteLine("The Username is correct !");
                return true;
            }
        }
        public static bool ValidatePassword(User user)
        {
            if (user.Password.Length < 5)
            {
                Console.WriteLine("Password should not be shorter than 6 characters.");
                return false;
            }
            else
            {
                if (user.Password.Any(char.IsUpper) && user.Password.Any(char.IsDigit))
                {
                    Console.WriteLine("The Password is correct !");
                    return true;
                }
                else
                {
                    Console.WriteLine("Password must contain at least one number and at least one capital letter and.");
                    return false;
                }
            }
        }
        public static bool ValidateFirstNameLastName(User user)
        {
            if (user.FirstName.Length < 2 && user.LastName.Length < 2)
            {
                Console.WriteLine("First Name and Last Name should not be shorter than 2 characters.");
                return false;
            }
            else
            {
                bool firstNameNumber = user.FirstName.Any(char.IsDigit);
                bool lastNameNumber = user.LastName.Any(char.IsDigit);
                bool firstNameSymbol = user.FirstName.Any(char.IsSymbol);
                bool lastNameSymbol = user.LastName.Any(char.IsSymbol);
                if (firstNameNumber || lastNameNumber || firstNameSymbol || lastNameSymbol)
                {
                    Console.WriteLine("First and last name must not contain numbers or symbols.");
                    return false;
                }
                else
                {
                    Console.WriteLine("First and last name are correct !");
                    return true;
                }
            }
        }
        public static bool ValidateAge(User user)
        {
            {
                if (user.Age < 18 || user.Age > 120)
                {
                    Console.WriteLine("Age should not be less than 18 years or over 120.");
                    return false;
                }
                else
                {
                    Console.WriteLine("Age is correct !");
                    return true;
                }

            }

        }
    }
}
