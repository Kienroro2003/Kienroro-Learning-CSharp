

namespace CardLinq;

public class Card : IComparable<Card>
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

    public int CompareTo(Card? other)
    {
        return new CardComparerByValue().Compare(this, other);
    }

    public override string ToString()
    {
        return Name;
    }
}