//namespace in .NET framework, where we have basic utility classes and primitive typster
using System;

namespace HelloWorld
{
    class Program
    {   
        static void Main(string[] args)
        {
            float constVariable = variables();
            Console.WriteLine("variables method: ");
            Console.WriteLine("Pi value is great to store in a const variable so that the value is not changed by accident");
            Console.WriteLine(constVariable);
            Console.WriteLine();

            typeConversion();
            Console.WriteLine();

            strings();
            Console.WriteLine();

            arrays();
            Console.WriteLine();

            operators();
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
            string trueOrFalse = "Hi";
            
            Console.WriteLine("typeConversion Method: ");

            Console.WriteLine("Converting a string to a boolean value- ");
            try
            {
                bool didStringSayTrueOrFalse = Convert.ToBoolean(trueOrFalse);
                Console.WriteLine("We can convert the string '{0}' to a boolean value", trueOrFalse);
                Console.WriteLine(didStringSayTrueOrFalse);
            }
            catch (Exception)
            {   
                Console.WriteLine("We cannot convert the string '{0}' to a boolean value", trueOrFalse);
            }

            Console.WriteLine();

            string number = "255";
            Console.WriteLine("Converting a string to a byte- ");
            try
            {
                
                byte b = Convert.ToByte(number);
                Console.WriteLine("We can convert the string '{0}' to a byte", number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("We cannot convert the string '{0}' to a byte", number);
            }

            //CONVERSION OF A STRING INTO AN INT
            var numberString = "1234";
            //error says it cannot convert type string to int
            //int i = (int)number;

            //use Convert.To
            int i = Convert.ToInt32(numberString);

            //EXPLICIT CONVERSION TO TELL COMPILER THAT WE ARE AWARE OF POSSIBLE DATA LOSS
            //If the int is not between 0 - 255 you will receive incorrect info due to data loss
            int anotherNumber = 1;
            //byte b = i;
            byte newByte = (byte)anotherNumber;
        }

        public static void strings()
        {   
            Console.WriteLine("strings Method:");
            string firstName = "Rose";
            string lastName  = "Smith";

            string fullName = firstName + " " + lastName;

            //String.Format
            string myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine("Using string.format- " +myFullName);

            //String.Join
            string[] names = new string[3] {"Bill", "Suzy", "Tony"};
            string formatedNames = string.Join(",", names);
            Console.WriteLine("Using string.Join- " +formatedNames);

            //Verbatim String
            //string text = "Hi Linda\nPlease see my email with the following link to paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            
            string verbatimText = @"
            Hi Linda,
            Please see my email with the following link to paths
            c:\folder1\folder2
            c:\folder3\folder4";
            
            Console.WriteLine("Using verbatim text- ");
            Console.WriteLine(verbatimText);
        }

        public static void arrays()
        {
            Console.WriteLine("arrays Method: ");
            
            int[] numbers = new int[3];

            numbers[0] = 1;

            Console.WriteLine("Initializing an array of 3 ints with only the first position given a value results in: ");
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine();
            
            bool[] flags = new bool[3];
            flags[0] = true;

            Console.WriteLine("Initializing a bool array with 3 items and giving only the first position a value of true, results in: ");
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);
            Console.WriteLine();

            //object initialization for array
            string []names = new string[3] {"John", "Lisa", "Lila"};
            string formatNames = string.Join(",", names);
            Console.WriteLine("Initialized a string with 3 names and using string.Join to print them all out: ");
            Console.WriteLine(formatNames);
        }

        public static void operators()
        {
            int a = 1;
            int b = 3;

            Console.WriteLine("operators Method: ");
            Console.WriteLine("{0} > {1} = {2}" ,a, b, a > b);
            Console.WriteLine("{0} + {1} = {2}" ,a, b, a + b);
            Console.WriteLine("{0} / {1} = {2}" ,a, b, a / b);
            Console.WriteLine("{0} / {1} = {2}" ,a, b, (float)a / (float)b);
            Console.WriteLine("{0} * {1} = {2}" ,a, b, a * b);
            Console.WriteLine("{0} - {1} = {2}" ,a, b, a - b);
            Console.WriteLine("{0} % {1} = {2}" ,a, b, a % b);
        }
    }

}
