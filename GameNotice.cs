using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1
{
    internal class GameNotice
    {
        private static int indexer = new Random(Guid.NewGuid().GetHashCode()).Next();
        public int Index { get; }
        public Account Player1 { get; }
        public Account Player2 { get; }
        public Players Winner { get; }

        private int formalRating;
        public int FormalRating
        {
            get => formalRating;
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Рейтинг, на який грають гравці, не може бути від'ємним");
                formalRating = value;
            }
        }

        public GameNotice(Account player1, Account player2, Players winner, int formalRating)
        {
            Index = indexer++;
            Player1 = player1;
            Player2 = player2;
            Winner = winner;
            FormalRating = formalRating;
        }
    }
}
