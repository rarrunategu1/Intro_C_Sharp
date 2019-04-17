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
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("typeConversion Method:  The string could not be converted into a boolean");
                Console.ReadLine();
            }
        }
    }

}
