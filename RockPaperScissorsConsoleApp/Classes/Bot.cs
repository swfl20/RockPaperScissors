using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsConsoleApp
{
    class Bot : Player
    {

        private Random rnd;
        private int intChoice;
        public Bot()
        {
            nextChoice();
        }

        public void nextChoice()
        {
            rnd = new Random();
            intChoice = rnd.Next(1, 4); // pick a random number 1-3 corresponding to rock, paper or 
            this.setChoice(intChoice);
        }

        //TODO: AI for the bot, read through a bunch of stored data to analyze patterns in the humans behaviour. Use machine learning models.
    }
}
