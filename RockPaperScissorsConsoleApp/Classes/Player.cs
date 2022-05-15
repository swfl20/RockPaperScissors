using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsConsoleApp
{
    abstract class Player : PlayerInterface
    {
        public string choice;
        public int score;

        public Player()
        {
            this.score = 0;
        }

        public int getScore()
        {
            return this.score;
        }
        public void incrementScore()
        {
            this.score++;
        }

        public string getChoice()
        {
            return this.choice;
        }

        public void setChoice(int choiceNo = 0)
        {
            switch (choiceNo)
            {
                case 1:
                    this.choice = "Rock";
                break;
                
                case 2:
                    this.choice = "Paper";
                break;
                
                case 3:
                    this.choice = "Scissors";
                break;
                
                default:
                    throw new Exception("Invalid option provided");
                break;
            }
        }

        
    }
}
