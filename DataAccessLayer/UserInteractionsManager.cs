using System;

namespace TheRightPriceGame.DataAccessLayer
{
    public class UserInteractionsManager : IUserInteractionsManager
    {
        public int GetUsersGuess()
        {
            var input = Int32.Parse(Console.ReadLine());
            return input;
        }

        public bool AskForReplay()
        {
            Console.WriteLine("Do you want to replay? (Y/N)");
            var input = Console.ReadLine();
            if (input.ToUpper() == "Y")
            {
                return true;
            }

            return false;
        }
    }
}