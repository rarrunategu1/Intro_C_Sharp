//namespace in .NET framework, where we have basic utility classes and primitive typster
using System;

namespace HelloWorld
{
    class Program
    {   
        static void Main(string[] args)
        {   
            var random = new Random();
            int secretNumber = 0;
            
            for (int numberLength = 1; numberLength < 2; numberLength++)
            {
                secretNumber += (random.Next(1, 10));
                Console.WriteLine("Secret number is {0}",secretNumber);
                Console.WriteLine();
            }

            int guessTries = 4;

            while (guessTries > 0)
            {
            
                Console.WriteLine("Guess the secret number: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                guessTries--;

                Console.WriteLine();

                if (guess == secretNumber)
                {
                    Console.WriteLine("You won");
                    Console.ReadLine();
                    break;
                }
                else if (guess != secretNumber)
                {
                    Console.WriteLine("You have {0} more guesses", guessTries);  
                    
                    if (guessTries <  1 && guess != secretNumber)
                    {
                        Console.WriteLine("You lost");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
