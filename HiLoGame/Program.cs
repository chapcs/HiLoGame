using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to HiLo.");
        Console.WriteLine($"Guess numbers between 1 and {HiLoGame.MAXIMUM}.");
        HiLoGame.Hint(true);
        while (HiLoGame.GetPot() > 0)
        {
            Console.WriteLine("Press 1 for higher, 0 for lower, ? to buy a hint,");
            Console.WriteLine($"or any other key to quit with {HiLoGame.GetPot()}.");
            char key = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (key == '1') HiLoGame.Guess(true);
            else if (key == '0') HiLoGame.Guess(false);
            else if (key == '?') HiLoGame.Hint(false);
            else return;
        }
        Console.WriteLine("The pot is empty and you are poor, bye . . .");
    }
}

static class HiLoGame
{
    public const int MAXIMUM = 10; // all constants are static
    static Random random = new Random();
    public static int currentNumber = random.Next(1, MAXIMUM + 1);
    private static int pot = 10; //equals number of bucks in the pot, must be private

    public static int GetPot()
    {
        return pot;
    }
    public static void Guess(bool higher)
    {
        int nextNumber = random.Next(1, MAXIMUM + 1);
        if ((higher && nextNumber >= currentNumber) || (!higher && nextNumber <= currentNumber))
        {
            Console.WriteLine("You guessed right!");
            pot++;
        }
        else
        {
            Console.WriteLine("Bad luck, you guessed wrong.");
            pot--;
        }
        currentNumber = nextNumber;
        Console.WriteLine($"\nThe current number is {currentNumber}");
    }

    public static void Hint(bool tick)
    {
        int half = MAXIMUM / 2;
        if (!tick)
        {
            Console.WriteLine();
            pot--;
        }
        if (currentNumber >= half)
            Console.WriteLine($"The number is at least {half}");
        else Console.WriteLine($"The number is at most {half}");
    }
}