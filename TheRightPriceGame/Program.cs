using Microsoft.Extensions.DependencyInjection;
using TheRightPriceGame.BusinessLayer;
using TheRightPriceGame.DataAccessLayer;

namespace TheRightPriceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = BuildTheServiceProvider();

            var game = serviceProvider.GetService<IGame>();
            game.PlayGame();
        }

        private static ServiceProvider BuildTheServiceProvider()
        {
            return new ServiceCollection()
                .AddSingleton<IGame, RightPriceGame>()
                .AddSingleton<IUserInteractionsManager, UserInteractionsManager>()
                .BuildServiceProvider();
        }
    }
}
