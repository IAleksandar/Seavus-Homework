using System;

namespace MinAndMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            float zero = 0;
            float min = 1 / zero;
            float max = -1 / zero;

            Console.WriteLine("Fill up the array:");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                if(min > arr[i])
                {
                    min = arr[i];
                    

                }
                if(arr[i] > max)
                {
                    max = arr[i];
                    
                }
                
            }
            Console.WriteLine($"The minimum is: {min}");
            Console.WriteLine($"The maximum is: {max}");



            Console.ReadLine();


        }
    }
}
