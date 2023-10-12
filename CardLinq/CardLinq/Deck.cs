using System.Collections.ObjectModel;

namespace CardLinq;

public class Deck : ObservableCollection<Card>
{
    private static Random random = new Random();

    public Deck()
    {
        Reset();
    }

    public Card Deal(int index)
    {
        Card cardToDeal = base[index];
        RemoveAt(index);
        return cardToDeal;
    }

    public void Reset()
    {
        Clear();
        for (int suit = 0; suit <= 3; suit++)
        for (int value = 1; value <= 13; value++)
            Add(new Card( (Suits)suit,(Values)value));
    }

    // public void Shuffle()
    // {
    //     List<Card> copy = new List<Card>(this);
    //     Clear();
    //     while (copy.Count > 0)
    //     {
    //         int index = random.Next(copy.Count);
    //         Card card = copy[index];
    //         copy.RemoveAt(index);
    //         Add(card);
    //     }
    // }
    
    public Deck Shuffle()
    {
// The rest of the class stays the same
        List<Card> copy = new List<Card>(this);
        Clear();
        while (copy.Count > 0)
        {
            int index = random.Next(copy.Count);
            Card card = copy[index];
            copy.RemoveAt(index);
            Add(card);
        }
        return this;
    }

    public void Sort()
    {
        List<Card> sortedCards = new List<Card>(this);
        sortedCards.Sort(new CardComparerByValue());
        Clear();
        foreach (Card card in sortedCards)
        {
            Add(card);
        }
    }
}