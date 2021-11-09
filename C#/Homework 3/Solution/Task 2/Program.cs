using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split('.');

            for (int i = 0; i <= words.Length-1; i++)
            {
                Console.WriteLine(words[i]);
            }

            Console.ReadLine();
        }
    }
}
