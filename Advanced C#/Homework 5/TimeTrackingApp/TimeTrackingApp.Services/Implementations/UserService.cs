using TimeTrackingApp.Domain.Models;
using TimeTrackingApp.Services.Interfaces;
using TimeTrackingApp.Domain.Database;
using System;
using TimeTrackingApp.Services.Helpers;
using System.Diagnostics;
using TimeTrackingApp.Domain;

namespace TimeTrackingApp.Services.Implementations
{
    public class UserService<T> : IUserService<T> where T : User
    {
        public Reading reading;
        public Exercising exercising;
        public Working working;
        public OtherHobbies otherHobbies;
        private IDatabase<T> _database;
        public UserService()
        {
            _database = new Database<T>();
            reading = new Reading();
            exercising = new Exercising();
            working = new Working();
            otherHobbies = new OtherHobbies();
        }

        public void AddUser(T user)
        {
            _database.InsertUser(user);
        }
        public T ChangeFirstName (T user)
        {
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("Enter new first name:");
                string newFirstName = Console.ReadLine();
                user.FirstName = newFirstName;

                if (ValidationHelper.ValidateFirstNameLastName(user) == true)
                {
                    flag = false;
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    return user;   
                }
                else
                {
                    Console.WriteLine("Press any key to try again.");
                    Console.ReadKey();
                }
            }
            return null;
        }
        public T ChangeLastName (T user)
        {
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("Enter new last name:");
                string newLastName = Console.ReadLine();
                user.LastName = newLastName;

                if (ValidationHelper.ValidateFirstNameLastName(user) == true)
                {
                    flag = false;
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    return user;   
                }
                else
                {
                    Console.WriteLine("Press any key to try again.");
                    Console.ReadKey();
                }
            }
            return null;
        }

        //public T ChangeFristAndLastName(T user)
        //{
        //    bool flag = true;
        //    while (flag)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Enter new first name:");
        //        string newFirstName = Console.ReadLine();
        //        Console.WriteLine("Enter new last name:");
        //        string newLastName = Console.ReadLine();
        //        user.FirstName = newFirstName;
        //        user.LastName = newLastName;
        //        if (ValidationHelper.ValidateFirstNameLastName(user) == true)
        //        {
        //            flag = false;
        //            return user;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Press any key to try again.");
        //            Console.ReadKey();
        //        }
        //    }
        //    return null;
        //}

        public T ChangePassword(T user)
        {
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("Enter new password:");
                string newPassword = Console.ReadLine();
                user.Password = newPassword;
                if (ValidationHelper.ValidatePassword(user) == true)
                {
                    flag = false;
                    return user;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Password is not strong !");
                    Console.ResetColor();
                    Console.WriteLine("Press any key to try again.");
                    Console.ReadKey();
                }
            }
            return null;
        }

        public T DeactivateAccount(T userInput)
        {
            User user = null;
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                user = _database.RemoveUser(userInput);
                if (user == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("User does not exits");
                    Console.ResetColor();
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("User account deactivated");
                    Console.ResetColor();
                    user.ActiveAcc = false; 
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    flag = false;
                    return (T)user;
                }
            }
            return (T)user;
        }

        public int LogIn()
        {
            User user = null;
            int i = 4;
            while (i > 0)
            {
                Console.Clear();
                Console.WriteLine("Enter log in information\n");
                Console.WriteLine("Enter username:");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password:");
                string password = Console.ReadLine();
                user = _database.CheckUser(username, password);
                if (user != null)
                {
                    bool menuflag = true;
                    while (menuflag)
                    {
                        if (user.ActiveAcc == false)    
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Your acc was deactivated, do you like to activate it again ?");
                            Console.ResetColor();
                            Console.WriteLine("1. Yes \n2. No");
                            bool activate = int.TryParse(Console.ReadLine(), out int activateAcc); 
                            if (activate) 
                            {
                                if(activateAcc == 1) 
                                { 
                                    _database.ActivateAccount(user); 
                                } 
                                else if (activateAcc == 2) 
                                { 
                                    break; 
                                } 
                            } 
                        } 
                        Console.Clear();
                        user.GetInfo();
                        Console.WriteLine("Welcome to the main menu !");
                        Console.WriteLine("Choose one of the following options:");
                        Console.WriteLine("1. Acount Managment");
                        //Console.WriteLine("1. Deactivate account");
                        //Console.WriteLine("2. Change password");
                        //Console.WriteLine("3. Change first and last name");
                        Console.WriteLine("2. Log out");
                        Console.WriteLine("3. Track");
                        Console.WriteLine("4. Statistics");
                        bool validation = int.TryParse(Console.ReadLine(), out int menuChoice);
                        if (validation)
                        {
                            //if (menuChoice == 1)
                            //{
                            //    DeactivateAccount((T)user);
                            //    menuflag = false;
                            //    return 1;
                            //}
                            //else if (menuChoice == 2)
                            //{
                            //    _database.UpdateUser(ChangePassword((T)user));
                            //    menuflag = false;
                            //    return 2;
                            //}
                            //else if (menuChoice == 3)
                            //{
                            //    _database.UpdateUser(ChangeFristAndLastName((T)user));
                            //    menuflag = false;
                            //    return 3;
                            //}
                            if (menuChoice == 1)
                            {
                                //LogOut();
                                //menuflag = false;
                                //return 9;
                                Console.WriteLine("Choose option: \n1. Change Password \n2. Change First Name \n3. Change Last Name \n4. Deactive Acount \n5. Back");
                                bool Am = int.TryParse(Console.ReadLine(), out int AmOption);
                                if (Am)
                                {
                                    if(AmOption == 1)
                                    {
                                        _database.UpdateUser(ChangePassword((T)user));
                                        menuflag = false;
                                        return 1;
                                    }
                                    else if(AmOption == 2)
                                    {
                                        _database.UpdateUser(ChangeFirstName((T)user));
                                        menuflag = false;
                                        return 2;
                                    }
                                    else if(AmOption == 3)
                                    {
                                        _database.UpdateUser(ChangeLastName((T)user));
                                        menuflag = false;
                                        return 3;
                                    }
                                    else if (AmOption == 4)
                                    {
                                        DeactivateAccount((T)user);
                                        menuflag = false;
                                        return 4;
                                    }
                                    else if(AmOption == 5)
                                    {
                                        menuChoice = 1;
                                    }
                                }
                            }
                            else if (menuChoice == 2)
                            {
                                LogOut();
                                menuflag = false;
                                return 9;
                            }
                            else if (menuChoice == 3)
                            {
                                Track((T)user);
                                menuflag = true;
                            }
                            else if (menuChoice == 4)
                            {
                                Statistics((T)user);
                                menuflag = true;
                            }
                            else
                            {
                                Console.ForegroundColor= ConsoleColor.Red;
                                Console.WriteLine("Try again !");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Try again !");
                            Console.ResetColor();
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect username or password !");
                    Console.ResetColor();
                    Console.WriteLine($"Press any key to enter login information again !\nYou have [{i - 1}] attempts left.");
                    if (i == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("No more attempts left. Goodbye");
                    }
                    Console.ReadKey();
                }
                i--;
            }
            return 0;
        }

        public int LogOut()
        {
            Console.Clear();
            Console.WriteLine("Logging out");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            return 9;
        }

        public void Register()
        {
            bool flag = true;
            while (flag)
            {

                Console.Clear();
                Console.WriteLine("Create a new account.");
                Console.WriteLine("Enter first name:");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter last name:");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter username:");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password:");
                string password = Console.ReadLine();
                Console.WriteLine("Enter age:");
                bool ageValidatorSuccess = int.TryParse(Console.ReadLine(), out int age);
                User newUser = new User(firstName, lastName, age, username, password, ActivityType.OtherHobbies);
                if (ageValidatorSuccess && ValidationHelper.ValidateUsername(newUser) && ValidationHelper.ValidatePassword(newUser) && ValidationHelper.ValidateFirstNameLastName(newUser) && ValidationHelper.ValidateAge(newUser))
                {
                    _database.InsertUser((T)newUser);
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Try again.");
                    Console.WriteLine(ValidationHelper.ValidateUsername(newUser));
                    Console.WriteLine(ValidationHelper.ValidatePassword(newUser));
                    Console.WriteLine(ValidationHelper.ValidateFirstNameLastName(newUser));
                    Console.WriteLine(ValidationHelper.ValidateAge(newUser));
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
            }
        }
        public void Statistics(T user)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to statistics for {user.FirstName} {user.LastName}\n");
            Console.WriteLine("Choose option:");
            Console.WriteLine("1. Reading \n2. Exercising \n3.Working \n4.Other hobbies \n5.Global \n6.Back");
            bool success = int.TryParse(Console.ReadLine(), out int option);
            if (success)
            {
                if(option == 1)
                {
                    Console.WriteLine($"Total reading in hours: {Math.Round(user.Reading, 2)/60} hours.");
                    Console.WriteLine($"Average of all activities records:{Math.Round((user.Reading + user.Exercising + user.Working + user.OtherHobbies) / 4, 2)} min ");
                    Console.WriteLine($"Total number of pages: {reading.Pages}");
                    Console.WriteLine($"Favourite activity type: {user.FavouriteType}");
                    Console.WriteLine("Press any key to go to the Main Menu.");
                    Console.ReadKey();
                }
               else if (option == 2)
                {
                    Console.WriteLine($"Total exercising in hours: {Math.Round(user.Exercising, 2) / 60} hours.");
                    Console.WriteLine($"Average of all activities records:{Math.Round((user.Reading + user.Exercising + user.Working + user.OtherHobbies) / 4, 2)} min ");
                    Console.WriteLine($"Favourite activity type: {user.FavouriteType}");
                    Console.WriteLine("Press any key to go to the Main Menu.");
                    Console.ReadKey();
                }
                else if (option == 3)
                {
                    Console.WriteLine($"Total working in hours: {Math.Round(user.Working, 2) / 60} hours.");
                    Console.WriteLine($"Average of all activities records:{Math.Round((user.Reading + user.Exercising + user.Working + user.OtherHobbies) / 4, 2)} min ");
                    Console.WriteLine($"Time working from home: {Math.Round(user.WorkFromHome, 2) / 60} hours.");
                    Console.WriteLine($"Time working from the office: {Math.Round(user.WorkFromOffice, 2) / 60} hours.");
                    Console.WriteLine("Press any key to go to the Main Menu.");
                    Console.ReadKey();
                }
                else if (option == 4)
                {
                    Console.WriteLine($"Total other hobies in hours: {Math.Round(user.OtherHobbies, 2) / 60} hours.");
                    Console.WriteLine("List of your hobies:");
                    foreach(string hobie in user.ListOfOtherHobies)
                    {
                        Console.WriteLine(hobie);
                    }
                    Console.WriteLine("Press any key to go to the Main Menu.");
                    Console.ReadKey();
                }
                else if (option == 5)
                {
                    Console.WriteLine($"Global total time of all activities: {Math.Round(user.Reading / 60, 2) + Math.Round(user.Exercising / 60, 2) + Math.Round(user.Working / 60, 2) + Math.Round(user.OtherHobbies / 60, 2)} hours.\n");
                    Console.WriteLine($"{user.FirstName}'s favourite activity is : {user.FavouriteType}");

                    Console.WriteLine("Press any key to go to the Main Menu.");
                    Console.ReadKey();
                }
                else if (option == 6)
                {
                    return;    
                }

            }
                
            Console.WriteLine("Press any key to go to the Main Menu.");
            Console.ReadKey();
        }
        public void Track(T user)
        {
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("Choose activity:\n");
                Console.WriteLine("1. Reading");
                Console.WriteLine("2. Exercising");
                Console.WriteLine("3. Working");
                Console.WriteLine("4. Other hobbies");
                Console.WriteLine("5. Back");
                bool activityValidation = int.TryParse(Console.ReadLine(), out int activityChoice);
                if (activityValidation)
                {
                    if (activityChoice == 1)
                    {
                        reading.ReadingActivity();
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        Console.WriteLine("Press ENTER to stop.");
                        string stop = Console.ReadLine();
                        if (stop == "")
                        {
                            stopwatch.Stop();
                            TimeSpan time = stopwatch.Elapsed;
                            double convertedTime = Convert.ToDouble(time.TotalSeconds);
                            user.Reading += convertedTime / 60;
                            Console.WriteLine($"Time spent on this activity: {Math.Round(convertedTime / 60, 2)} min.");
                            Console.WriteLine("Press any key to go back to the Main Menu.");
                            Console.ReadKey();
                            flag = false;
                        }
                    }
                    else if (activityChoice == 2)
                    {
                        exercising.ExercisingActivity();
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        Console.WriteLine("Press ENTER to stop.");
                        string stop = Console.ReadLine();
                        if (stop == "")
                        {
                            stopwatch.Stop();
                            TimeSpan time = stopwatch.Elapsed;
                            double convertedTime = Convert.ToDouble(time.TotalSeconds);
                            user.Exercising += convertedTime / 60;
                            Console.WriteLine($"Time spent on this activity: {Math.Round(convertedTime / 60, 2)} min.");
                            Console.WriteLine("Press any key to go back to the Main Menu.");
                            Console.ReadKey();
                            flag = false;
                        }
                    }
                    else if (activityChoice == 3)
                    {
                        working.WorkingActivity(user);
                        flag = false;
                    }
                    else if (activityChoice == 4)
                    {
                        otherHobbies.OtherHobiesActivity(user);
                        flag = false;  
                    }
                    else if(activityChoice == 5)
                    {
                        break;
                    }
                }
            }
        }
    }
}
