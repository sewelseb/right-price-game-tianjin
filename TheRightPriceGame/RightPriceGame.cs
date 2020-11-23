using System;

namespace TheRightPriceGame
{
    public class RightPriceGame : IGame
    {
        private readonly IUserInteractionsManager userInteractionsManager;

        public RightPriceGame(IUserInteractionsManager userInteractionsManager)
        {
            this.userInteractionsManager = userInteractionsManager;
        }

        public void PlayGame()
        {
            var play = true;

            do
            {
                PlayOneGame();

                play = userInteractionsManager.AskForReplay();
            } while (play == true);
        }

        private void PlayOneGame()
        {
            var mysteryNumber = GetAMysteryNumberBetween0To10();
            var isGameFinished = false;
            var counter = 0;

            while (!isGameFinished)
            {
                counter++;
                isGameFinished = LetTheUserPlayTheGame(mysteryNumber, isGameFinished);
            }

            Console.WriteLine($"Contragulation, you won after only {counter} guesses");
        }

        private int GetAMysteryNumberBetween0To10()
        {
            var random = new Random();
            var mysteryNumber = random.Next(0, 10);
            return mysteryNumber;
        }

        private bool LetTheUserPlayTheGame(int mysteryNumber, bool isGameFinished)
        {
            try
            {
                var input = GetUserInput();
                isGameFinished = ManageUserInput(mysteryNumber, input);
            }
            catch (Exception e)
            {
                Console.WriteLine("This is not a number.");
            }

            return isGameFinished;
        }

        private int GetUserInput()
        {
            Console.WriteLine("Find my mystery number");
            return userInteractionsManager.GetUsersGuess();
        }

        private bool ManageUserInput(int mysteryNumber, int input)
        {
            bool isGameFinished = false;
            if (input == mysteryNumber)
            {
                isGameFinished = true;
                Console.Write("Congratulation, you won!!!!");
            }
            else if (input > mysteryNumber)
            {
                Console.Write("Too big, try a lower number");
            }
            else
            {
                Console.Write("Too low, try a bigger number");
            }

            return isGameFinished;
        }
    }
}