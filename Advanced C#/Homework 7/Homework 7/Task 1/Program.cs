using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static string Calculator(int number1, int number2)
        {
            int sum = number1 + number2;
            return $"{number1} + {number2} = {sum}";
        }
        static void Main(string[] args)
        {
            string appPath = @"..\..\..\";
            bool folderExerciseExists = Directory.Exists(appPath + "test");

            string folderPath = appPath + "test";

            if (!folderExerciseExists)
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("Exercise folder was created!");
            }

            string filesPath = appPath + "test";
            bool fileCalculatorExists = File.Exists(filesPath);
            if (!fileCalculatorExists)
            {
                File.Create(filesPath + @"\calculator.txt").Close();
                Console.WriteLine("File calculator.txt was created!");

                string calculationFilePath = folderPath + @"\calculator.txt";
                for (int i = 0; i < 3; i++)
                {
                    Console.ResetColor();
                    Console.WriteLine("Enter the first number: ");
                    bool isFirstNumNumber = int.TryParse(Console.ReadLine(), out int firstNumber);

                    Console.WriteLine("Enter the second number: ");
                    bool isSecondNumNumber = int.TryParse(Console.ReadLine(), out int secondNumber);

                    if (!isFirstNumNumber && !isSecondNumNumber)
                    {
                        Console.WriteLine("Wrong input!");
                    }
                    else
                    {
                        Console.WriteLine(Calculator(firstNumber, secondNumber));

                        using (StreamWriter sw = new StreamWriter(calculationFilePath, true))
                        {
                            String timeStamp = DateTime.Now.ToString();
                            sw.WriteLine(Calculator(firstNumber, secondNumber));
                            sw.WriteLine(timeStamp);
                            Console.WriteLine("The result is in calculator.txt !");
                        }

                    }

                }
            }
            Console.ReadLine();
        }
    }
}