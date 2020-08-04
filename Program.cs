using System;

namespace csharp
{
    interface Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;

            Console.Write("choose between rock, paper and scissors:    ");
            inputPlayer = Console.ReadLine();

            Random rnd = new Random();

            randomInt = rnd.Next(1,4);

            switch (randomInt) {
                case 1: 
                inputCPU = "rock";
                Console.WriteLine("computer chose rock");
                if (inputPlayer == "rock") {
                    Console.WriteLine("Draw"); 
                }
                else if (inputPlayer == "paper") {
                    Console.WriteLine("player wins");
                    scorePlayer++;
                }
                else if (inputPlayer == "scissors") {
                    Console.WriteLine("computer wins");
                    scoreCPU++;
                }
                break;
                case 2: 
                inputCPU = "paper";
                if (inputPlayer == "paper") {
                    Console.WriteLine("Draw"); 
                }
                else if (inputPlayer == "rock") {
                    Console.WriteLine("player wins");
                    scorePlayer++;           
                }
                else if (inputPlayer == "rock") {
                    Console.WriteLine("computer wins");
                    scoreCPU++;

                }
                break;
                case 3: 
                inputCPU = "scissors";
                if (inputPlayer == "scissors") {
                    Console.WriteLine("Draw"); 
                }
                else if (inputPlayer == "paper") {
                    Console.WriteLine("computer wins");
                    scoreCPU++;
                }
                else if (inputPlayer == "rock") {
                    Console.WriteLine("player wins");
                    scorePlayer++
                }
                break;
                default:
                Console.WriteLine("Invalid Entry")
                break;
            }
        }
    }
}
