using System;
using System.Collections.Generic;

namespace Divisors
{
    class Program
    {
        static void Main(string[] args)
        {
            Program test1 = new Program();
            var userNum = test1.askUser();

            printList(test1.divisor(userNum));
        }
        /**
         * ask the user for a number and return it
         */
        public int askUser()
        {
            Console.WriteLine("Enter a number: ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            return userNum;
        }

        /**
         * creates a new list, iterates from 1 to userNum, to divide each iteration with userNum to see which are divisors
         * if it is a divisor then it is added to the new list and the list is returned by the method
         */
        public List<int> divisor(int userNum)
        {
            List<int> divisorsList = new List<int>();

            if (userNum < 1)
            {
                Console.WriteLine("Invalid number");
            }

            for (int i = 1; i < userNum; i++)
            {
                if (userNum % i == 0)
                {
                    divisorsList.Add(i);
                }
            }
            return divisorsList;
        }

        /**
         * prints the elements of the new list created above
         */
        public static void printList(List<int> userList)
        {
            foreach (var i in userList)
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}
