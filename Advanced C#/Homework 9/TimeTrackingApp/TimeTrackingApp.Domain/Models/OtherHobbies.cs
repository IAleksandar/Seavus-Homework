using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace TimeTrackingApp.Domain.Models
{
    public class OtherHobbies
    {
        public string Title { get; set; }
        public ActivityType Type { get; set; }

        public OtherHobbies()
        {
            Title = "Other hobbies";
            Type = ActivityType.OtherHobbies;
        }
        public void TimeForOtherHobbies(User user)
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
                user.OtherHobbies += convertedTime / 60;
                Console.WriteLine($"Time spent on this activity: {Math.Round(convertedTime / 60, 2)} min.");
                Console.WriteLine("Press any key to go back to the Main Menu.");
                Console.ReadKey();
            }
        }
        public void OtherHobiesActivity(User user)
        {
            List<string> ListOfHobbies = new List<string>();
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("What is your hobie ?");
                string hobie = Console.ReadLine();
                if (hobie == "")
                {
                    flag = false;
                }
                ListOfHobbies.Add(hobie);

            }

            List<string> NewList = ListOfHobbies.Distinct().ToList();
            user.ListOfOtherHobies = NewList;
            TimeForOtherHobbies(user);
        }
    }
}
