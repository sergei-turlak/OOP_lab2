using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1
{
    internal class GameManager
    {
        public static Game CreateOrdinaryGame(Account player1, Account player2, int formalRating, Victory winner)
        {
            return new OrdinaryGame(player1, player2, formalRating, winner);
        }

        public static Game CreateTrainingGame(Account player1, Account player2,Victory winner)
        {
            return new TrainingGame(player1, player2, winner);
        }

        public static Game CreateGameForOne(Account ratingPlayer, Account noRatingPlayer, int formalRating, Victory winner)
        {
            return new GameForOne(ratingPlayer, noRatingPlayer, formalRating, winner);
        }
    }
}
