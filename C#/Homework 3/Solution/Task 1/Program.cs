using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            string output = "";

            for(int i = input.Length-1; i >= 0; i--)
            {
                output += input[i];
            }


            Console.WriteLine($"The string in reverse is: {output}");

            Console.ReadLine();

        }
    }
}
