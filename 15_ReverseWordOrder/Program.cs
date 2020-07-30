using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _15_ReverseWordOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Enter a sentence to be reversed:");
            string s = Console.ReadLine();

            Program test = new Program();
            Console.WriteLine(test.reverseSentence(s));

        }

        public string reverseSentence(string s)
        {

            string pattern = " ";
            string input = s;

            string[] StringArray = Regex.Split(input, pattern);
            StringBuilder builder = new StringBuilder();
            
            for (int i = StringArray.Length - 1; i >= 0; i--)
            {
                builder.Append(StringArray[i]);
                builder.Append(" ");
            }

            return builder.ToString();

        }

    }
}
