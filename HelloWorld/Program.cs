//namespace in .NET framework, where we have basic utility classes and primitive typster
using System;

namespace HelloWorld
{
    class Program
    {   
        //entry point to app
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the width of your image:  ");
            string widthInput = Console.ReadLine();
            double width = Convert.ToDouble(widthInput);

            Console.WriteLine("Please enter the height of your image:  ");
            string heightInput = Console.ReadLine();
            double height = Convert.ToDouble(heightInput);

            if (width == 8.5 && height == 11.0)
            {
                Console.WriteLine("Your image is a portrait image.");
            }
            else if (width == 11.0 && height == 8.5)
            {
                Console.WriteLine("Your image is a landscape image.");
            }
            else
            {
                Console.WriteLine("Your image is neither landscape or portrait.");
            }

            Console.ReadLine();


        }
    }
}
