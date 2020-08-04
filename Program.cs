using System;

namespace csharp
{
    interface Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;

            Console.Write("choose between rock, paper and scissors");
            inputPlayer = Console.ReadLine();

            Random rnd = new Random();

            randomInt = rnd.Next(1,4);

            switch (randomInt) {
                case 1: 
                inputCPU = "rock";
                break;
                case 2: 
                inputCPU = "paper";
                break;
                case 3: 
                inputCPU = "scissors";
                break;
                default:
                break;
            }
        }
    }
}
