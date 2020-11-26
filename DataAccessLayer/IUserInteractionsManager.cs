namespace TheRightPriceGame.DataAccessLayer
{
    public interface IUserInteractionsManager
    {
        int GetUsersGuess();
        bool AskForReplay();
    }
}