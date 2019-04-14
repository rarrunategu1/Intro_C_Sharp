//namespace in .NET framework, where we have basic utility classes and primitive typster
using System;

namespace HelloWorld
{
    class Program
    {   
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the speed limit:  ");
            string speedLimitInput = Console.ReadLine();
            byte speedLimit = Convert.ToByte(speedLimitInput);

            Console.WriteLine("Please enter the speed of the car:  ");
            string carSpeedInput = Console.ReadLine();
            byte carSpeed = Convert.ToByte(carSpeedInput);

            byte speedExcessDemeritAssigner = 5;

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("OK");
            }
            else if ((carSpeed - speedLimit) >= 5)
            {
                int demeritPoints = (int)((carSpeed - speedLimit) / speedExcessDemeritAssigner);

                Console.WriteLine("You have incurred {0} demerit points.", demeritPoints);

                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
            }
            Console.ReadLine();
        }
    }
}
