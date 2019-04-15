//namespace in .NET framework, where we have basic utility classes and primitive typster
using System;

namespace HelloWorld
{
    class Program
    {   
        static void Main(string[] args)
        {
            int counter = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    counter += 1;
                    //Console.WriteLine(i);
                }
            }
            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}
