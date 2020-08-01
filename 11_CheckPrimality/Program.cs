using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckPrimality_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();

            Console.WriteLine("Enter a number to see if it's a prime or not: ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(test.isPrime(userNum));
        }

        public bool isPrime(int num)
        {
            bool isPrime = false;
            List<int> divisors = new List<int>();

            for(int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    divisors.Add(i);
                }
            }

            if ((divisors.Count <= 2) && (divisors[0] == 1))
            {
                isPrime = true;
                Console.WriteLine("{0} is a prime", num);
            }
            return isPrime;
        }
    }
}
