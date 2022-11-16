using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1
{
    internal class CheaterAccount : Account
    {
        public CheaterAccount(string name) : base(name) {  }

        protected override void WinGame(Game game)
        {
            int neededRating;
            if (game.Player1 == this)
                neededRating = game.CalculateNeededRating(Players.Player1);
            else if (game.Player2 == this)
                neededRating = game.CalculateNeededRating(Players.Player2);
            else throw new ArgumentException();

            this.CurrentRating *= neededRating;
        }

        protected override void LoseGame(Game game)
        {
            int neededRating;
            if (game.Player1 == this)
                neededRating = game.CalculateNeededRating(Players.Player1);
            else if (game.Player2 == this)
                neededRating = game.CalculateNeededRating(Players.Player2);
            else throw new ArgumentException();

            this.CurrentRating -= 0;
        }

        public override string GetStats()
        {
            return base.GetStats().Replace("ЗВИЧАЙНИЙ", "ЧІТЕР (CHEATER)");
        }
    }
}
