using System;

namespace FindStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First number: ");
            short firstNumber = short.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number: ");
            short secondNumber = short.Parse(Console.ReadLine());

            if (firstNumber%2 == 0 && secondNumber % 2 == 0)
            {
                short sum = (short)(firstNumber + secondNumber);
                Console.WriteLine($"The numbers are even. The operation and result are {firstNumber} + {secondNumber} = {sum}.");
            }
            else if (firstNumber%2 != 0 && secondNumber % 2 != 0)
            {
                short mul = (short)(firstNumber * secondNumber);
                Console.WriteLine($"The numbers are odd. The operation and result are {firstNumber} * {secondNumber} = {mul}.");
            }
            else
            {
                short diff = (short)(firstNumber - secondNumber);
                Console.WriteLine($"One of the numbers is odd. The operation and result are {firstNumber} - {secondNumber} = {diff}.");
            }



            Console.ReadLine();
        }
    }
}
