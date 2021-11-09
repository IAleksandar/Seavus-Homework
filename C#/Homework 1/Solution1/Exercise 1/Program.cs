using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First number: ");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number: ");
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operation: ");
            string operand = Console.ReadLine();
            if (operand == "+")
            {
                double sum = number1 + number2;
                Console.WriteLine($"The result is: {sum}");
               
            }
            if (operand == "-")
            {
                double sub = number1 - number2;
                Console.WriteLine($"The result is: {sub}");
            }
            if (operand == "*")
            {
                double mul = number1 * number2;
                Console.WriteLine($"The result is: {mul}");
            }
            if (operand == "/")
            {
                double div = number1 / number2;
                Console.WriteLine($"The result is: {div}");
            }

            
            

            Console.ReadLine();
        }
    }
}
