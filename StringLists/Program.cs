using System;

namespace StringLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            String userInput = Console.ReadLine();

            Program test = new Program();

            //Console.WriteLine(test.IsPalindrome(userInput));

            Console.WriteLine(test.solution2(userInput));

        }

        /**
         * Original solution, reversing string using for loops
         */
        public bool IsPalindrome(String s)
        {

            char[] arr = s.ToCharArray();
            char[] reversedArr = new char[s.Length];

            int ite = 0;
            for (int i = arr.Length-1; i >= 0; i--)
            {
                reversedArr[ite] = arr[i];
                ite++;
            }

            String reversedString = new string(reversedArr);

            if (reversedString.Equals(s, StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
            return false;
        }

        /**
         *  solution2 using Array.Reverse instead of reversing using for loops
         */
        public bool solution2(string s)
        {
            char[] charArr = s.ToCharArray();
            Array.Reverse(charArr);
            string reversedString = new string(charArr);

            if (s.Equals(reversedString,StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
            return false;
        }
    }
}
