//namespace in .NET framework, where we have basic utility classes and primitive typster
using System;

namespace HelloWorld
{
    class Program
    {   
        //entry point to app
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");

            int userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber > 0 && userNumber < 11)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            Console.ReadLine();
        }

    }
}
