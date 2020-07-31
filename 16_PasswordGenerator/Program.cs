using System;
using System.Runtime.InteropServices;
using System.Text;

namespace _16_PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Random random = new Random();

            //letters = 65-126
            //we don't want 57 - 65
            //numbers = 48 - 57

            Program test = new Program();

            Console.WriteLine("How long do you want your password to be?");
            var num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(test.passwordGenerator(num));
            

        }

        public String passwordGenerator(int n)
        {
            //n is the length of the password they want.
            Random random = new Random();
            StringBuilder sb = new StringBuilder();

            char[] charArray = new char[n];

            int i = 0;
            while (i < n)
            {
                int randomAscii = random.Next(48, 126);
                char c = (char)randomAscii;
                charArray[i] = c;
                i++;
            }

            foreach(var elem in charArray)
            {
                sb.Append(elem);
            }

            return sb.ToString();
        }

    }
}
