using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program test = new Program();

            Console.WriteLine("How many fib numbers do you want?:");
            var num = Convert.ToInt32(Console.ReadLine());

            var list = test.fibonacci(num);
            printResult(list);
        }

        public List<int> fibonacci(int n)
        {
            List<int> result = new List<int>();
            int x = 0;
            int y = 1;

            int i = 0;
            while(i < n)
            {
                int z = x + y;
                y = x;
                x = z;
                result.Add(x);
                i++;
            }

            return result;
        }

        public static void printResult(List<int> result)
        {
            foreach (var elem in result)
            {
                Console.WriteLine(elem);
            }
        }
    }

}
