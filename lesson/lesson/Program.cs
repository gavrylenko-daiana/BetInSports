using System;
using System.Collections.Generic;

namespace lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomValue randomValue = new RandomValue();
            BetManager betManager = new BetManager();

            betManager.AddEvent(new Event("Football: Team A vs Team B", new DateTime(2023, 3, 25),
                new List<double> { randomValue.GetRandomValue(), randomValue.GetRandomValue(), randomValue.GetRandomValue() })); //от 0 дот 10.9
            betManager.AddEvent(new Event("Volleyball: Team A versus Team B", new DateTime(2023, 3, 28),
                new List<double> { randomValue.GetRandomValue(), randomValue.GetRandomValue(), randomValue.GetRandomValue() }));

            Console.WriteLine("Available events:");
            betManager.DisplayEvents();

            Console.Write("Enter the number of the event you want to bet on: ");
            int eventIndex = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Enter the outcome on which you want to bet (0 - win of team A, 1 - draw, 2 - win of team B): ");
            int outcome = int.Parse(Console.ReadLine());

            Console.Write("Enter the amount you want to bet: ");
            double amount = double.Parse(Console.ReadLine());

            Bet bet = new Bet(betManager.Events[eventIndex], outcome, amount);
            betManager.AddBet(bet);

            Console.WriteLine("\nYour bets:");
            betManager.DisplayBets();
        }
    }
}
