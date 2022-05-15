using System;

namespace RockPaperScissorsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose game mode: \n 1) Human vs Computer \n 2) Computer vs Computer \n 3) quit.");
            int choice = int.Parse(Console.ReadLine());
            StartGame(choice); //pass in the choice of game mode
        }

        private static void StartGame(int choice)
        {

            if (choice != 3)
            {
                try
                {
                    GameManager gameType = new GameManager(choice); //create an instance of the game
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error(s):  \n " + e);
                }

            }

        }
    }
}
