using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsConsoleApp
{
    interface PlayerInterface
    {
        void setChoice(int choice);
        string getChoice();
        int getScore();
    }
}
