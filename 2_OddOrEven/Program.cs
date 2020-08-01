using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World! This is an odd or even program:");

            Program test = new Program();

            Console.WriteLine(test.OddOrEven(1));

        }

        public String OddOrEven(int x)
        {
            string s = "";

            if(x == 0)
            {
                s = "Invalid value";
            }

            if(x % 2 == 0)
            {
                s = "Even";
            }
            s = "Odd";

            return s;
        }
    }
}
