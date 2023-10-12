namespace HiloGameConsole;

public class HiloGame
{
    public const int MAXIMUM = 10;
    private static Random random = new Random();
    private static int currenNumber = random.Next(1, MAXIMUM + 1);
    private static int pot = 10;

    public static int GetPot()
    {
        return pot;
    }

    public static void Guess(bool higher)
    {
        int nextNumber = random.Next(1, MAXIMUM + 1);
        if ((higher && nextNumber >= currenNumber) || (!higher && nextNumber <= currenNumber))
        {
            Console.WriteLine("You guessed right!");
            pot++;
        }
        else
        {
            Console.WriteLine("Bad luck, you guessed wrong.");
            pot--;
        }

        currenNumber = nextNumber;
        Console.WriteLine(($"The current number is {currenNumber}"));
    }

    public static void Hint()
    {
        int half = MAXIMUM / 2;
        if (currenNumber >= half)
        {
            Console.WriteLine($"The number is at least {half}");
        }
        else
        {
            Console.WriteLine($"The number is at most {half}");
        }

        pot--;
    }
}