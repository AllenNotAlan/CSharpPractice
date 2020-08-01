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
            while (true)
            {
                userInputPrompt();
                Console.WriteLine("Player one:");
                string userOneInput = Console.ReadLine().ToLowerInvariant();
                Console.WriteLine("Player two:");
                string userTwoInput = Console.ReadLine().ToLowerInvariant();

                if (userOneInput == "rock" && userTwoInput == "scissors")
                {
                    Console.WriteLine("Player 1 wins");
                    isWinner = true;
                }
                else if (userOneInput == "rock" && userTwoInput == "paper")
                {
                    Console.WriteLine("Player 2 wins");
                    isWinner = true;
                }
                else if (userOneInput == "scissors" && userTwoInput == "rock")
                {
                    Console.WriteLine("Player 2 wins");
                    isWinner = true;
                }
                else if (userOneInput == "scissors" && userTwoInput == "paper")
                {
                    Console.WriteLine("Player 1 wins");
                    isWinner = true;
                }
                else if (userOneInput == "paper" && userTwoInput == "rock")
                {
                    Console.WriteLine("Player 1 wins");
                    isWinner = true;
                }
                else if (userOneInput == "paper" && userTwoInput == "scissors")
                {
                    Console.WriteLine("Player 2 wins");
                    isWinner = true;
                }
                else
                {
                    Console.WriteLine("Draw. Play again.");
                }

                if (isWinner != false)
                {
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
}
