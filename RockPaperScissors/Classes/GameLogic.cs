using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Classes
{
    public static class GameLogic
    {

        public static string GetName(int move)
        {
            if(move == 1)
            {
                return "Rock";
            }
            else if(move == 2)
            {
                return "Paper";
            }
            else if(move == 3)
            {
                return "Scissors";
            }

            return null;
        }

        public static string WhoWins(int player, int comp)
        {
            string output = "nobody won :(";

            if(player == 1)
            {
                if(comp == 2)
                {
                    output = "Computer Wins!";
                }
                else if(comp == 3)
                {
                    output = "Player Wins!";
                }
            }
            else if(player == 2)
            {
                if(comp == 1)
                {
                    output = "Player Wins!";
                }
                else if(comp == 3)
                {
                    output = "Computer Wins!";
                }
            }
            else if(player == 3)
            {
                if(comp == 1)
                {
                    output = "Computer Wins!";
                }
                else if(comp == 2)
                {
                    output = "Player Wins!";
                }
            }
            return output;
        }
    }
}
