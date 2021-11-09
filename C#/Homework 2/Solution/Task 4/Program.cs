using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter the number of elements:");
            int numberOfElements = int.Parse(Console.ReadLine());
            int[] arr = new int[numberOfElements];
            int counter = 0;

            for (int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine($"Enter the {i + 1} element: ");
                arr[i] = int.Parse(Console.ReadLine());
                for (int j = 1; j < numberOfElements; j++)
                {
                    if (arr[i] == arr[j] && arr[i] == 3)
                    {
                        counter = counter + 1;
                    }
                }
            }

            Console.WriteLine($"{counter} times there are threes next to each other.");







            Console.ReadLine();
        }
    }
}
