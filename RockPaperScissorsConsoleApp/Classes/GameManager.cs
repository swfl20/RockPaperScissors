using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsConsoleApp
{
    class GameManager
    {
        private int draw;
        private Bot bot2;

        public GameManager(int mode)
        {
            draw = 0;

            bot2 = new Bot(); //game will always have at least 1 bot

            if (mode == 1)
            {
                humanGame(bot2); // this will be a human vs computer game
            }
            else
            {
                botGame(bot2); // this will be a computer vs computer game
            }

        }
        public void humanGame(Bot bot2)
        {
            try
            {
                Console.WriteLine("------\n Welcome to human vs computer game. Please start by making your first throw: \n 1) Rock \n 2) Paper \n 3) Scissors  \n 4) quit");

                int decision = int.Parse(Console.ReadLine()); //detect key press to either continue application or quit
                Human human = new Human(decision); //declare human instance and pass the choice in

                while (decision != 4)
                { 
                    compareResult(human, bot2);
                    Console.WriteLine("continue by making your next throw or 4 to exit: \n 1) Rock \n 2) Paper \n 3) Scissors \n 4) quit");
                    decision = int.Parse(Console.ReadLine());

                    human.setChoice(decision);
                    bot2.nextChoice();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error(s):  \n " + e);
            }
        }
        public void botGame(Bot bot2)
        {
            try
            {
                Bot bot1 = new Bot(); 
                Console.WriteLine("Welcome to computer vs computer game. Sit back and watch the bots play");
            
                int decision = 1; //detect key press to either continue application or quit

                while (decision == 1)
                { 
                    compareResult(bot1, bot2);
                    Console.WriteLine("press 1 to continue, or any key to quit");
                    decision = int.Parse(Console.ReadLine());

                    bot1.nextChoice();
                    bot2.nextChoice();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error(s):  \n " + e);
            }
        }

        //function to check which player won the round
        public void compareResult(Player player1, Player player2)
        {
            Console.WriteLine("------\n player1 throws " + player1.getChoice() + " ------\n player2 throws " + player2.getChoice() + " ------\n");

            //logic to check which player won, or whether it's a draw
            if ((player1.getChoice() == "Rock" && player2.getChoice() == "Scissors") ||
                (player1.getChoice() == "Paper" && player2.getChoice() == "Rock") ||
                (player1.getChoice() == "Scissors" && player2.getChoice() == "Paper"))
            {
                Console.WriteLine("player1 wins!");
                player1.score += 1; //increment score
            }
            else if ((player1.getChoice() == "Rock" && player2.getChoice() == "Paper") ||
                (player1.getChoice() == "Paper" && player2.getChoice() == "Scissors") ||
                (player1.getChoice() == "Scissors" && player2.getChoice() == "Rock"))
            {
                Console.WriteLine("player2 wins!");
                player2.score += 1; //increment score
            }
            else
            {
                Console.WriteLine("It's a draw!");
                draw++;
            }

            Console.WriteLine("-----\n Current Stats:  \n player1 - " + player1.getScore() + ", player2 - " + player2.getScore() + ", draws - " + this.draw + "\n ------ ");
        }
    }
}
