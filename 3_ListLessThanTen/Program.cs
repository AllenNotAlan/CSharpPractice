using System;
using System.Collections.Generic;

namespace ListLessThanTen
{
    class Program
    {
        static void Main(string[] args)
        {
            //a = [1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89]

            int[] a = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89};

            List<int> aList = new List<int>();

            //add array elements into list

            for(int i = 0; i < a.Length; i++)
            {
                aList.Add(a[i]);
            }


            Program solution = new Program();
            var xres = solution.AddOnlyLessFive(a);

            Console.WriteLine("Enter the largest num you want in the list: ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            List<int> removeLess = solution.removeElemFromList(aList, userNum);

            solution.printElems(removeLess);



        }

        public List<int> AddOnlyLessFive(int[] arr)
        {

            List<int> result = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 5)
                {
                    result.Add(arr[i]);
                }
            }
            return result;
        }

        /**
         * Answer to challenge
         *
         */
        public List<int> RemoveElementsLessFive(List<int> list, int num)
        {
            for(int i = list.Count - 1; i >= 0; i--)
            {
                if(list[i] > num)
                {
                    list.RemoveAt(i);
                }
            }
            return list;
        }

        /**
         * using LINQ to remove items from a list
         * (i => i < 5); -> remove all items from list less than 5. similar to list comprehension from python
         */
        public List<int> removeElemFromList(List<int> list, int num)
        {
            list.RemoveAll(i => i > num);
            return list;
        }

        /**
         * method to print a list.
         */
        public void printElems(List<int> list)
        {
            foreach(int x in list)
            {
                Console.WriteLine("{0}", x);
            }
        }
    }
}
