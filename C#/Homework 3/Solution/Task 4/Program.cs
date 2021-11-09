using System;

namespace Task_4
{
    class Program
    {
        static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
        static int Sub(int number1, int number2)
        {

            return number1 - number2;
        }
        static int Division(int number1, int number2)
        {

            return number1 / number2;
        }
        static int Mul(int number1, int number2)
        {

            return number1 * number2;
        }
        static void Calculator(string operand, int number1, int number2)
        {

            switch (operand)
            {
                case "+":
                    Console.Write("The sum is: ");
                    Console.Write(Sum(number1, number2));
                    break;
                case "-":
                    Console.Write("The sub is: ");
                    Console.Write(Sub(number1, number2));
                    break;
                case "/":
                    Console.Write("The div is: ");
                    Console.Write(Division(number1, number2));
                    break;
                case "*":
                    Console.Write("The mul is: ");
                    Console.Write(Mul(number1, number2));
                    break;
                default:
                    Console.WriteLine("Wrong input!");
                    break;
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number 1:");
            string n1 = Console.ReadLine();
            int number1;
            bool success1 = int.TryParse(n1, out number1);
            Console.WriteLine("Enter number 2:");
            string n2 = Console.ReadLine();
            int number2;
            bool success2 = int.TryParse(n2, out number2);


            if(success1 && success2)
            {
                Console.WriteLine("Enter operand: ");
                string operand = Console.ReadLine();
                Calculator(operand, number1, number2);
            }

            Console.ReadLine();
        }
    }
}
