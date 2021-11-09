using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Third number: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Fourth number: ");
            double fourthNumber = double.Parse(Console.ReadLine());
            double average = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
            Console.WriteLine($"The average of {firstNumber}, {secondNumber}, {thirdNumber}, {fourthNumber} is: {average} ");
            

            Console.ReadLine();


        }
    }
}
