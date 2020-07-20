using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game();
        }

        public static void Game()
        {
            Random test1 = new Random();
            int num = test1.Next(8)+1;

            bool isRight = false;

            while(isRight == false)
            {
                Console.WriteLine("Guess the number between 1-9:");
                string userGuess = Console.ReadLine();
                if (userGuess.Equals("Exit", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Ending game...");
                    break;
                }
                int userGuessNum = Convert.ToInt32(userGuess);

                if (userGuessNum > num)
                {
                    Console.WriteLine("Too high");
                }
                else if (userGuessNum < num)
                {
                    Console.WriteLine("Too Low");
                }
                else
                {
                    Console.WriteLine("You guessed right! The number was {0}", num);
                    isRight = true;
                }
            }

        }
    }
}
