using System;
using System.Diagnostics;

namespace TimeTrackingApp.Domain.Models
{
    public class Working
    {
        public string Title { get; set; }
        public ActivityType Type { get; set; }
        public ActivityTypeWorking WorkingType {get; set;}

        public Working()
        {
            Title = "Working Activity";
            Type = ActivityType.Working;
        }
        public void TimeForWorking(ActivityTypeWorking working, User user)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Press ENTER to stop.");
            string stop = Console.ReadLine();
            if (stop == "")
            {
                stopwatch.Stop();
                TimeSpan time = stopwatch.Elapsed;
                double convertedTime = Convert.ToDouble(time.TotalSeconds);
                if(working == ActivityTypeWorking.WorkFromHome)
                {
                    user.WorkFromHome += convertedTime / 60;
                }
                if (working == ActivityTypeWorking.WorkFromOffice)
                {
                    user.WorkFromOffice += convertedTime / 60;
                }
                user.Working += convertedTime / 60;
                Console.WriteLine($"The time you spent doing this activity {Title}: {Math.Round(convertedTime / 60, 2)}");
                Console.WriteLine("Press any key to go back to the Main Menu.");
                Console.ReadKey();
            }

            
        }

        public void WorkingActivity(User user)
        {
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("Choose working space:\n");
                Console.WriteLine("1. Home");
                Console.WriteLine("2. Office");
                bool validation = int.TryParse(Console.ReadLine(), out int choice);
                if (validation)
                {
                    if (choice == 1)
                    {
                        Console.WriteLine("Working from home");
                        TimeForWorking(ActivityTypeWorking.WorkFromHome, user);
                        flag = false;
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Working from the office");
                        TimeForWorking(ActivityTypeWorking.WorkFromOffice, user);
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("Try again.");
                        Console.WriteLine("Press any key to continue.");
                    }
                }
                else
                {
                    Console.WriteLine("Try again.");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
            }
        }
    }
}
