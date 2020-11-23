using System;
using Microsoft.Extensions.DependencyInjection;

namespace TheRightPriceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IGame, RightPriceGame>()
                .AddSingleton<IUserInteractionsManager, UserInteractionsManager>()
                .BuildServiceProvider();

            var game = serviceProvider.GetService<IGame>();
            game.PlayGame();
        }

       
    }
}
