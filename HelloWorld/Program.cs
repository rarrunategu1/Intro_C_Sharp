//namespace in .NET framework, where we have basic utility classes and primitive typster
using System;

namespace HelloWorld
{
    class Program
    {   
        static void Main(string[] args)
        {
            int sum = 0;

            while (true)
            {
                Console.WriteLine("Please enter a number or ok to exit:  ");
                String userInput = Console.ReadLine();

                if (userInput != "ok")
                {
                    sum += Convert.ToInt32(userInput);
                    continue;
                }
                else
                {
                    Console.WriteLine("The sum of your numbers is {0}.",sum);
                    Console.ReadLine();
                    break;
                }
                

            }
        }
    }
}
