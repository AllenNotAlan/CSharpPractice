using System;
using System.Collections.Generic;
using System.IO;

namespace _22_ReadFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "C:\\Users\\allen\\Desktop\\CSharp\\Exercises\\22_ReadFromFile\\nameslist.txt";
            
            ReadFromFile(); //my solution
            ReadFromFileWithStreamReader(s); // solution from : https://www.c-sharpcorner.com/UploadFile/mahesh/how-to-read-a-text-file-in-C-Sharp/
        }

        /**
         * solution using ReadAllLines 
         */

        public static void ReadFromFile()
        {
            string[] lines= System.IO.File.ReadAllLines(@"C:\Users\allen\Desktop\CSharp\Exercises\22_ReadFromFile\nameslist.txt");
            int count = 0;
            foreach (string line in lines)
            {
                Console.WriteLine(line);
                count++;
            }

            Console.WriteLine(count);

        }

        /**
         * Solution using StreamReader from see above
         */
        public static void ReadFromFileWithStreamReader(String fileDir)
        {

            using(StreamReader file = new StreamReader(fileDir))
            {
                int counter = 0;
                string line;

                while((line = file.ReadLine()) != null) { //while the line is not empty, do this... if empty then break
                    Console.WriteLine(line);
                    counter++;
                }

                file.Close();
                Console.WriteLine(counter);
            }

        }

        public static void Extra(string fileDir)
        {
            using(StreamReader file = new StreamReader(fileDir))
            {
                int counter = 0;
            }
        }
    }
}
