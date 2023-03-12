internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to HiLo.");
        Console.WriteLine($"Guess numbers between 1 and {HiLoGame.MAXIMUM}.");
        HiLoGame.Hint();
        while (HiLoGame.GetPot() > 0)
        {

        }
    }
}