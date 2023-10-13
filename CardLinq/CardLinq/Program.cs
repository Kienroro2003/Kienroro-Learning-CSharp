using System;
using CardLinq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck().Shuffle().Take(16);
            var grouped = OrderedEnumerable(deck);
            foreach (var group in grouped)
            {
                Console.WriteLine(@$"Group: {group.Key}
                Count: {group.Count()}
                Minimum: {group.Min()}
                Maximum: {group.Max()}");
            }
        }

        private static IOrderedEnumerable<IGrouping<Suits, Card>> OrderedEnumerable(IEnumerable<Card> deck)
        {
            var grouped =
                from card in deck
                group card by card.Suits
                into suitGroup
                orderby suitGroup.Key descending
                select suitGroup;
            return grouped;
        }
    }
}