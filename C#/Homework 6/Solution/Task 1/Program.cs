using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void PrintNumbers(IEnumerable collection)
        {
            foreach(int element in collection)
            {
                Console.WriteLine(element);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of numbers in queue: ");
            bool success = int.TryParse(Console.ReadLine(), out int number);

            Queue<int> numberQueue = new Queue<int>();

            while (success)
            {
                for(int i = 0; i < number; i++)
                {
                    Console.WriteLine($"Enter {i+1} element: ");
                    bool success2 = int.TryParse(Console.ReadLine(), out int element);
                    numberQueue.Enqueue(element);
                }
                PrintNumbers(numberQueue);
                break;
            }
            

            Console.ReadLine();
        }
    }
}
