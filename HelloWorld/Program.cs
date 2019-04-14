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

            string input = Console.ReadLine();

            int firstNumber = Convert.ToInt32(input);

            Console.WriteLine("Please enter another number: ");

            string secondInput = Console.ReadLine();

            int secondNumber = Convert.ToInt32(secondInput);

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("The maximum of the two numbers is: {0}",firstNumber);
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine("The maximum of the two numbers is: {0}",secondNumber);
            }
            else if (firstNumber == secondNumber)
            {
                Console.WriteLine(string.Format("Your numbers {0} and {1} are equal", firstNumber, secondNumber));
            }
            
            Console.ReadLine();
        }
    }
}
