// See https://aka.ms/new-console-template for more information
using System;
namespace SnakeAndLadderProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome To Snake And Ladder Game========");
            SnakeAndLadder snakeAndLadder = new SnakeAndLadder();
            snakeAndLadder.StartGame();
            Console.ReadLine();
        }
    }
}
