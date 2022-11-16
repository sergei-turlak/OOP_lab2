using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account pl1 = new Account("Василь");
            VipAccount pl2 = new VipAccount("Остап");

            Game[] games = 
            {
                GameManager.CreateOrdinaryGame(pl1, pl2, 13, Victory.Random),
                GameManager.CreateTrainingGame(pl1, pl2, Victory.Random),
                GameManager.CreateGameForOne(pl2, pl1, 8, Victory.Random)
            };

            foreach (var game in games)
            {
                Account.Play(game);
            }

            Console.WriteLine("***\nВасиль сiв за гральний стiл!");
            Console.WriteLine("Остап приєднався до гри!");

            Console.WriteLine("\nЗіграно:\n*** Класична гра на 13 рейтингу" +
                "\n*** Тренувальна гра без рейтингу" +
                "\n*** Гра для одного, де тільки один гравець втрачає або виграє рейтинг (на 8 рейтингу)");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(pl1.GetStats());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(pl2.GetStats());


            Console.ReadLine();
        }
    }
}
