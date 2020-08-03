using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _20_ElementSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int> { 1, 5, 3, 4, 5, 13, 7, 8, 12 };

            Program test = new Program();

            Console.WriteLine(test.elemSearch(li, 6));

        }

        public bool elemSearch(List<int> list, int num)
        {
            list.Sort();

            bool result = false;
            foreach(var elem in list)
            {
                if(elem == num)
                {
                    result = true;
                }
            }



            return result;
        }
    }
}
