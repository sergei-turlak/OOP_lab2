using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1
{
    internal class GameForOne : Game
    {
        public GameForOne(Account ratingPlayer, Account noRatingPlayer, int formalRating, Victory winner)
        {
            Player1 = ratingPlayer;
            Player2 = noRatingPlayer;
            FormalRating = formalRating;
            Winner = winner;
        }

        public override int CalculateNeededRating(Players player)
        {
            if (player == Players.Player1)
            {
                return FormalRating;
            }
            else if (player == Players.Player2)
            {
                return 0;
            }
            throw new ArgumentException();
        }
    }
}
