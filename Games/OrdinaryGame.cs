using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1
{
    internal class OrdinaryGame : Game
    {
        public OrdinaryGame(Account player1, Account player2, int formalRating, Victory winner)
        {
            Player1 = player1;
            Player2 = player2;
            FormalRating = formalRating;
            Winner = winner;
        }

        public override int CalculateNeededRating(Players player)
        {
            return FormalRating;
        }
    }
}
