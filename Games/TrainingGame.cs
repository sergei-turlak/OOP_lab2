using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1
{
    internal class TrainingGame : Game
    {
        public TrainingGame(Account player1, Account player2, Victory winner)
        {
            Player1 = player1;
            Player2 = player2;
            Winner = winner;
            FormalRating = 0;
        }

        public override int CalculateNeededRating(Players player)
        {
            return 0;
        }
    }
}
