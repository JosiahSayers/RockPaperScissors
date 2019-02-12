using System;

namespace RockPaperScissors.Classes
{
    public static class UI
    {

        public static void DisplayMenu()
        {
            int computerTally = 0;
            int playerTally = 0;
            int gamesPlayed = 0;
            int tieTally = 0;
            string userMoveName = "";
            string compMoveNAme = "";
            int userMove = 0;
            int compMove = 0;
            string winner = "";


            while (true)
            {
                Console.WriteLine("Rock-Paper-Scissors\n----------------------------------");

                if (gamesPlayed > 0)
                {
                    Console.WriteLine($"Previous Game: You Chose {GameLogic.GetName(userMove)}, Computer chose {GameLogic.GetName(compMove)}. {winner.Substring(0, winner.IndexOf(" "))} won!");
                    Console.WriteLine($"Your Score: {playerTally}     Computer Score: {computerTally}     Ties: {tieTally}\n");
                }

                Console.WriteLine("1. Rock\n2. Paper\n3. Scissors");
                Console.Write("\nChoose your move:");
                userMove = int.Parse(Console.ReadLine());

                Random rand = new Random();
                compMove = rand.Next(1, 4);

                winner = GameLogic.WhoWins(userMove, compMove);
                Console.WriteLine(winner);

                if (winner == "Computer Wins!")
                {
                    computerTally++;
                }
                else if (winner == "Player Wins!")
                {
                    playerTally++;
                }
                else
                {
                    tieTally++;
                }
                Console.Clear();
                gamesPlayed++;
            }
        }


    }
}
