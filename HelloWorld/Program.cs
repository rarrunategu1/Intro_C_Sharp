//namespace in .NET framework, where we have basic utility classes and primitive typster
using System;

namespace HelloWorld
{
    class Program
    {   

        public static long factorialize(int number)
        {   
           long factorial = 1;
            
           while (number > 1)
           {
                factorial *= number;
                number--;
           }
           return factorial;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to factorialize:  ");

            int number = Convert.ToInt32(Console.ReadLine());
           
            long result = factorialize(number);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
