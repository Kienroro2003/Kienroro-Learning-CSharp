namespace CardConsole;

public class CardComparerByValue : IComparer<Card>
{
    public int Compare(Card? x, Card? y)
    {
        if (x.Values > y.Values) return 1;
        else if (x.Values < y.Values) return -1;
        else return 0;
    }
}