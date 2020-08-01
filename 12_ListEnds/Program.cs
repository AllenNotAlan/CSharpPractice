using System;
using System.Collections.Generic;

namespace ListEnds_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();

            var testList = new List<int>() { 5, 10, 15, 20, 25 };

            var testResult = test.ListEnds(testList);

            printResult(testResult);
        }

        public List<int> ListEnds(List<int> list1)
        {
            List<int> result = new List<int>();

            int listSize = list1.Count;

            for (int i = 0; i < listSize; i++)
            {
                if ((i == 0) || (i == listSize - 1))
                {
                    result.Add(list1[i]);
                }
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
