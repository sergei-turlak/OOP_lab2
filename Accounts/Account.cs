using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1
{

    internal class Account
    {
        public string UserName { get; set; }
        public int GamesCount => stats.Count;

        private List<GameNotice> stats;
        private int currentRating;
        public int CurrentRating
        {
            get => currentRating;
            set
            {
                if (value < 1)
                    throw new ArgumentException("Ви намагаєтесь зробити рейтинг менше нуля");
                currentRating = value;
            }
        }

        public Account(string name)
        {
            UserName = name;
            currentRating = 50;
            stats = new List<GameNotice>();
        }

        public static void Play(Game game)
        {
            Players winner = new Players();
            switch (game.Winner)
            {
                case Victory.Player1:
                    game.Player1.WinGame(game);
                    game.Player2.LoseGame(game);
                    winner = Players.Player1;
                    break;

                case Victory.Player2:
                    game.Player2.WinGame(game);
                    game.Player1.LoseGame(game);
                    winner = Players.Player2;
                    break;

                case Victory.Random:
                    if (new Random().Next(2) == 0)
                        goto case Victory.Player1;
                    else
                        goto case Victory.Player2;
            }
            GameNotice notice = new GameNotice(game.Player1, game.Player2, winner, game.FormalRating);
            game.Player1.stats.Add(notice);
            game.Player2.stats.Add(notice);
        }

        protected virtual void WinGame(Game game)
        {
            int neededRating;
            if (game.Player1 == this)
                neededRating = game.CalculateNeededRating(Players.Player1);
            else if (game.Player2 == this)
                neededRating = game.CalculateNeededRating(Players.Player2);
            else throw new ArgumentException();

            this.CurrentRating += neededRating;
        }

        protected virtual void LoseGame(Game game)
        {
            int neededRating;
            if (game.Player1 == this)
                neededRating = game.CalculateNeededRating(Players.Player1);
            else if (game.Player2 == this)
                neededRating = game.CalculateNeededRating(Players.Player2);
            else throw new ArgumentException();

            this.CurrentRating -= neededRating;
        }

        public virtual string GetStats()
        {
            string stat = $"\n************************************************************\n" +
                $"Остаточний рейтинг гравця {this.UserName} з типом акаунту ЗВИЧАЙНИЙ: {this.CurrentRating}\n" +
                $"Усього ігор: {GamesCount}\n";
            foreach (var game in stats)
            {
                stat += $"***\n" +
                    $"Гра з індексом {game.Index}\n" +
                    $"Гра відбулась між {game.Player1.UserName} та {game.Player2.UserName}\n";
                if ((game.Player1 == this && game.Winner == Players.Player1)
                    || game.Player2 == this && game.Winner == Players.Player2)
                    stat += "Гра завершилась перемогою!!!\n";
                else
                    stat += "Гра завершилась поразкою :((\n";
                stat += $"Рейтинг, на який була гра: {game.FormalRating}\n";

            }

            stat += "************************************************************\n";
            return stat;
        }
    }
}
