using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            game();
        }

        public static void userInputPrompt()
        {
            Console.WriteLine("Rock, Paper, Scissors");
        }

        static void game()
        {
            bool isWinner = false;
            while (isWinner == false)
            {
                userInputPrompt();
                Console.WriteLine("Player one:");
                string userOneInput = Console.ReadLine();
                Console.WriteLine("Player two:");
                string userTwoInput = Console.ReadLine();

                if (userOneInput == "rock" && userTwoInput == "scissors")
                {
                    Console.WriteLine("Player 1 wins");
                }
                else if (userOneInput == "rock" && userTwoInput == "paper")
                {
                    Console.WriteLine("Player 2 wins");
                }
                else if (userOneInput == "scissors" && userTwoInput == "rock")
                {
                    Console.WriteLine("Player 2 wins");
                }
                else if (userOneInput == "scissors" && userTwoInput == "paper")
                {
                    Console.WriteLine("Player 1 wins");
                }
                else if (userOneInput == "paper" && userTwoInput == "rock")
                {
                    Console.WriteLine("Player 1 wins");
                }
                else if (userOneInput == "paper" && userTwoInput == "scissors")
                {
                    Console.WriteLine("Player 2 wins");
                }
                else
                {
                    Console.WriteLine("Draw. Play again.");
                }

                Console.WriteLine("Play again? Enter Y or N: ");
                string rematch = Console.ReadLine();
                if (rematch != "N")
                {
                    continue;
                }
                else
                {
                    break;
                }

            }
        }
    }
}
