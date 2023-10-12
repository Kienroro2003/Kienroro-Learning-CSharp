namespace JewelThief;

public class JewelThiefClass : Locksmith
{
    private string stolenJewels;

    public void ReturnContents(string safeContents, SafeOwner owner)
    {
        stolenJewels = safeContents;
        Console.WriteLine($"I'm stealing the jewels! I stole: {stolenJewels}");
    }
}