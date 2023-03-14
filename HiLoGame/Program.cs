internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to HiLo.");
        Console.WriteLine($"Guess numbers between 1 and {HiLoGame.MAXIMUM}.");
        HiLoGame.Hint();
        while (HiLoGame.GetPot() > 0)
        {
            Console.WriteLine("Press h for higher, 1 for lower, ? to buy a hint,");
            Console.WriteLine($"or any other key to quit with {HiLoGame.GetPot()}.");
            char key = Console.ReadKey(true).KeyChar;
            if (key == 'h') HiLoGame.Guess(true);
            else if (key == '1') HiLoGame.Guess(false);
            else if (key == '2') HiLoGame.Hint();
            else return;
        }
        Console.WriteLine("The pot is empty and you are poor, bye . . .");
    }
}

static class HiLoGame
{
    public const int MAXIMUM = 10;
    static Random random = new Random();

}