using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 3");
            int number = int.Parse(Console.ReadLine());


            switch (number)
            {
                case 1:
                        Console.WriteLine("You got a new car!");
                        break;
                case 2:
                        Console.WriteLine("You got a new plane!");
                        break;
                case 3:
                        Console.WriteLine("You got a new bike!");
                        break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
            
            //kako se pravi za string koga ke vnesam da pecati poraka "Wrong input" ?
            //ne znam da napravam validacija so switch...




            Console.ReadLine();
        }
    }
}
