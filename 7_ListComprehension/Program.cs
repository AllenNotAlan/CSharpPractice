using System;
using System.Collections.Generic;

namespace ListComprehension
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArr1 = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
            int[] testArr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            Program testSolution = new Program();
            //testSolution.result(testArr1, testArr2);

            printResults(testSolution.result(testArr1, testArr2));
        }

        public HashSet<int> result(int[] arr1, int[] arr2)
        {
            int arr1Length = arr1.Length;
            int arr2Length = arr2.Length;

            HashSet<int> results = new HashSet<int>();

            for (int i = 0; i < arr1Length; i++)
            {
                for (int j = 0; j < arr2Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        results.Add(arr1[i]);
                    }
                }
            }

            return results;
        }

        public static void printResults(HashSet<int> list)
        {
            foreach(var elem in list)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
