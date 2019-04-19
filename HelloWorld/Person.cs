using System;

namespace HelloWorld
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }

        public void IncrementAge(int number)
        {
            number += 10;
            Console.WriteLine("{0}'s age incremented by 10 is {1}", FirstName, number);
        }

        //the parameter, Person, is a reference value that is the memory address in the heap for person
        public void MakeOld(Person person)
        {
            person.Age += 30;
            Console.WriteLine("{0}'s made older by 30 years is {1}", FirstName, person.Age);
        }


    }
}