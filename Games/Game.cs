using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1
{
    enum Victory { Player1, Player2, Random }
    enum Players { Player1, Player2 }

    internal abstract class Game
    {
        public Account Player1 { get; protected set; }
        public Account Player2 { get; protected set; }
        public int FormalRating { get; protected set; }
        public Victory Winner { get; protected set; }

        public abstract int CalculateNeededRating(Players player);
    }
}
