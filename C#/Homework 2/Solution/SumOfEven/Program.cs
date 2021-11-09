using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Enter integer no.{i+1}:");
                int number = int.Parse(Console.ReadLine());
                int[] arr = new int[6];
                arr[i] = number;
                if(arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }

            }
            Console.WriteLine($"The result is: {sum}");


            Console.ReadLine();
        }
    }
}
