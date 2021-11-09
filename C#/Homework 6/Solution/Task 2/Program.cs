using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_2
{
    class Program
    {
        static void SquareNumbers(List<int> numbersList)
        {
            List<int> squaresNumber = numbersList.Select(x => x * x).ToList();
            Console.WriteLine("The squares of theese numbers are: ");
            foreach(int n in squaresNumber)
            {
                Console.WriteLine(n);
            }
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                {10},
                {9},
                {8},
                {7},
                {6},
                {5},
                {4},
                {3},
                {2},
                {1},
            };

            SquareNumbers(numbers);

            Console.ReadLine();
        }
    }
}
