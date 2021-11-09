using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose one of the following options:\n 1.Rock\n 2.Paper\n 3.Scissors");
            int userInputCount = 0;
            int appInputCount = 0;
            int chances = 0;
            double userScoreWins = 0;
            double userScoreLosses = 0;

            bool success = int.TryParse(Console.ReadLine(), out int userInput);
            while (success)
            {
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("The user picked option Rock");
                        break;
                    case 2:
                        Console.WriteLine("The user picked option Paper");
                        break;
                    case 3:
                        Console.WriteLine("The user picked option Scissors");
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }



                int appInput = new Random().Next(1, 3);
                switch (appInput)
                {
                    case 1:
                        Console.WriteLine(" The app picked option Rock");
                        break;
                    case 2:
                        Console.WriteLine("The app picked option Paper");
                        break;
                    case 3:
                        Console.WriteLine("The app picked option Scissors");
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }

                if (userInput == appInput)
                {
                    Console.WriteLine("No one wins");
                    chances++;
                }
                else if (userInput == 1 && appInput == 2)
                {
                    Console.WriteLine("The app wins");
                    appInputCount++;
                    Console.WriteLine(appInputCount);
                    chances++;
                }
                else if (userInput == 1 && appInput == 3)
                {
                    Console.WriteLine("The user wins");
                    userInputCount++;
                    Console.WriteLine(userInputCount);
                    chances++;
                }
                else if (userInput == 2 && appInput == 1)
                {
                    Console.WriteLine("The user wins");
                    userInputCount++;
                    Console.WriteLine(userInputCount);
                    chances++;
                }
                else if (userInput == 2 && appInput == 3)
                {
                    Console.WriteLine("The app wins");
                    appInputCount++;
                    Console.WriteLine(appInputCount);
                    chances++;
                }
                else if (userInput == 3 && appInput == 1)
                {
                    Console.WriteLine("The app wins");
                    appInputCount++;
                    Console.WriteLine(appInputCount);
                    chances++;
                }
                else if (userInput == 3 && appInput == 2)
                {
                    Console.WriteLine("The user wins");
                    userInputCount++;
                    Console.WriteLine(userInputCount);
                    chances++;
                }
                userScoreWins = userInputCount / chances * 100;
                userScoreLosses = 100 - userScoreWins;
                Console.WriteLine($"User has {userInputCount} wins\n App has {appInputCount} wins");
                Console.WriteLine($"User has {userScoreWins}% wins and {userScoreLosses}% losses");

                break;
            }
             Console.ReadLine();
        }
    }
}
