using System;
using System.Collections.Generic;

namespace ListOverlap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list1 = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 100, 203, 594 };
            int[] list2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 34, 12, 13 };

            List<int> a = new List<int>();
            List<int> b = new List<int>();

            for (int i = 0; i < list1.Length; i++)
            {
                a.Add(list1[i]);
            }

            for (int j = 0; j < list2.Length; j++)
            {
                b.Add(list2[j]);
            }

            Program test1 = new Program();
            //test1.ListOverlap(list1, list2);

            test1.ListOverlapList(a, b);

        }
        /**
         * Method solution that takes in two arrays as parameters
         */
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
         /**
         * Method solution that takes in two Lists<int> as parameters
         */
        public HashSet<int> ListOverlapList(List<int> a, List<int> b)
        {
            HashSet<int> result = new HashSet<int>();

            int listALength = a.Count;
            int listBLength = b.Count;

            foreach(int i in a)
            {
                foreach(int j in b)
                {
                    if(i == j)
                    {
                        result.Add(i);
                    }
                }
            }

            foreach (int val in result)
            {
                Console.WriteLine(val);
            }

            return result;

        }
    }
}
