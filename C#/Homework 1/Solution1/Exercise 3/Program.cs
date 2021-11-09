using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the First Number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Second Number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int temp;
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            Console.WriteLine("After swapping:");


            Console.WriteLine($"First Number: {firstNumber}");
            Console.WriteLine($"Second Number: {secondNumber}");


            Console.ReadLine();
        }
    }
}
