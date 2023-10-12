// See https://aka.ms/new-console-template for more information

using CardConsole;
using EnumConsole;

Random random = new Random();
List<Card> cards = new List<Card>();
CardComparerByValue valueComparer = new CardComparerByValue();
Console.Write("Enter number of cards: ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    cards.Add(new Card((Suits) random.Next(0, 3), (Values) random.Next(1, 14)));
}

foreach (Card card in cards)
{
    Console.WriteLine(card.Name);
}
Console.WriteLine("\n.. sorting the cards ...\n");
cards.Sort(valueComparer);
foreach (Card card in cards)
{
    Console.WriteLine(card.Name);
}