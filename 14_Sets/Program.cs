using System;
using System.Collections.Generic;

namespace Sets_14
{
    class Program
    {
        static void Main(string[] args)
        {
            var testList = new List<int> { 1, 1, 2, 2, 3, 4, 5, 5, 6 };

            Program test = new Program();

            var result = test.removeDuplicates(testList);
            printSet(result);

        }

        public HashSet<int> removeDuplicates (List<int> list)
        {
            HashSet<int> result = new HashSet<int>();

            foreach (var elem in list)
            {
                result.Add(elem);
            }

            return result;

        }

        public static void printSet(HashSet<int> set)
        {
            foreach(var elem in set)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
