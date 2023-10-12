using EnumConsole;

namespace CardConsole;

public class Card
{
    public  Suits Suits { get; private set; }
    public Values Values { get; private set; }

    public string Name
    {
        get
        {
            return $"{Values} of {Suits}";
        }
    }

    public Card(Suits suit, Values value)
    {
        Suits = suit;
        Values = value;
    }

}