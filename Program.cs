using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            bool playAgain = true;

            while (playAgain) {
                int scorePlayer = 0;
                int scoreCPU = 0;
                while (scorePlayer < 3 && scoreCPU < 3)

                {

                    Console.Write("choose between rock, paper and scissors:    ");
                    inputPlayer = Console.ReadLine();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "rock";
                            Console.WriteLine("computer chose rock");
                            if (inputPlayer == "rock")
                            {
                                Console.WriteLine("draw");
                            }
                            else if (inputPlayer == "paper")
                            {
                                Console.WriteLine("player wins");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "scissors")
                            {
                                Console.WriteLine("computer wins");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "paper";
                            if (inputPlayer == "paper")
                            {
                                Console.WriteLine("Draw");
                            }
                            else if (inputPlayer == "rock")
                            {
                                Console.WriteLine("player wins");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "rock")
                            {
                                Console.WriteLine("computer wins");
                                scoreCPU++;

                            }
                            break;
                        case 3:
                            inputCPU = "scissors";
                            if (inputPlayer == "scissors")
                            {
                                Console.WriteLine("draw");
                            }
                            else if (inputPlayer == "paper")
                            {
                                Console.WriteLine("computer wins");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "rock")
                            {
                                Console.WriteLine("player wins");
                                scorePlayer++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Entry");
                            break;
                    }
                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player has won");
                }

                else if (scoreCPU == 3)
                {
                    Console.WriteLine("Player has won");
                }
                else
                {

                }
                Console.WriteLine("Do you want to play again(y/n)?");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
            }
        }
    }
}
