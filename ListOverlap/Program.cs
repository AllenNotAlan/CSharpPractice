using System;
using System.Collections.Generic;

namespace ListOverlap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list1 = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
            int[] list2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            Program test1 = new Program();
            test1.ListOverlap(list1, list2);
        }

        public HashSet<int> ListOverlap(int[] list1, int[] list2)
        {
            HashSet<int> result = new HashSet<int>();

            int list1Length = list1.Length;
            int list2Length = list2.Length;

            for(int i = 0; i < list1Length; i++)
            {
                for(int j =  0; j < list2Length; j++)
                {
                    if (list1[i] == list2[j])
                    {
                        result.Add(list1[i]);
                    }
                }
            }

            foreach(int val in result)
            {
                Console.WriteLine(val);
            }

            return result;
        }
    }
}
