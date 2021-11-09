using System;

namespace Task_5
{
    class Program
    {
        static int AgeCalculator(int date)
        {
            int result;

            DateTime currentDateTime = DateTime.Now;
            int year = currentDateTime.Year;
            result = year - date;
            return result;


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a years: ");
            string input = Console.ReadLine();
            int date;
            bool success = int.TryParse(input, out date);
            if (success)
            {
                Console.WriteLine(AgeCalculator(date));
            }

            Console.ReadLine();
        }
    }
}
