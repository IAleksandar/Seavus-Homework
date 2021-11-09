using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = {"Ana", "Maja", "Veselka", "Brankica", "Mila" };


            Console.WriteLine("Enter student group: ( there are 1 and 2 )");
            int number = int.Parse(Console.ReadLine());

            if(number == 1)
            {
                Console.WriteLine("The Students in G1 are:");
                for (int i = 0; i < studentsG1.Length; i++)
                {
                    Console.WriteLine(studentsG1[i]);
                }
            }
            else if (number == 2)
            {
                Console.WriteLine("The Students in G2 are:");
                for (int i = 0; i < studentsG2.Length; i++)
                {
                    Console.WriteLine(studentsG2[i]);
                }
            }

            else
            {
                Console.WriteLine("You have entered wrong input!");
            }
                
                
                
                
                
                
                
                
                
            
                
                
                
             Console.ReadLine();
        }
    }
}
