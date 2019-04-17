//namespace in .NET framework, where we have basic utility classes and primitive typster
using System;

namespace HelloWorld
{
    class Program
    {   
        static void Main(string[] args)
        {
            float constVariable = variables();
            Console.WriteLine("variables method: {0}",constVariable);
            Console.WriteLine();

            typeConversion();
            Console.WriteLine();

            strings();
            Console.WriteLine();


            Console.ReadLine();
        }

        //const variables should always be used for values that should remain the same
        public static float variables()
        {
            const float Pi = 3.14f;
            return Pi;
        }

        public static void typeConversion()
        {
            try
            {
                string trueOrFalse = "Hi";
                bool didStringSayTrueOrFalse = Convert.ToBoolean(trueOrFalse);
                Console.WriteLine("typeConversion Method: " +didStringSayTrueOrFalse);
            }
            catch (Exception)
            {
                Console.WriteLine("typeConversion Method:  The string could not be converted into a boolean");
            }
        }

        public static void strings()
        {   
            Console.WriteLine("strings Method:");
            string firstName = "Rose";
            string lastName  = "Smith";

            string fullName = firstName + " " + lastName;

            //String.Format
            string myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine("string.format: " +myFullName);

            //String.Join
            string[] names = new string[3] {"Bill", "Suzy", "Tony"};
            string formatedNames = string.Join(",", names);
            Console.WriteLine("string.Join: " +formatedNames);

            //Verbatim String
            string text = "Hi Linda\nPlease see my email with the following link to paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            
            string verbatimText = @"Hi Linda
            Please see my email with the following link to paths
            c:\folder1\folder2
            c:\folder3\folder4";
            
            Console.WriteLine("verbatimText: " +verbatimText);
            Console.ReadLine();

        }
    }

}
