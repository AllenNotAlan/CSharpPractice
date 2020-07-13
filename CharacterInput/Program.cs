using System;
using System.Runtime.InteropServices;

namespace CharacterInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();

            test.charInput();
        }

        public void charInput()
        {
            int currentYear = DateTime.Now.Year;
            

            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Your name is {0}", userName);

            Console.WriteLine("Enter your age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is {0}", userAge);

            int turnHundred = (currentYear - userAge) + 100;
            Console.WriteLine("Hi {0}, you are {1} years old and will turn 100 years old in the year: {2}",userName,userAge, turnHundred);

        }  
    }
}
