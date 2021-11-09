using System;

namespace Task_3
{
    class Program
    {
       static int Sum(int number)
        {

            int sum = 0;

                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }

                return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();
            int number;
            bool success = int.TryParse(input, out number);
            while (success)
            {
                Console.Write("The sum is: ");
                Console.Write(Sum(number));
                break;
            }

            Console.ReadLine();
        }
    }
}
