using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace CardReadAndWriteConsole
{
    public class Deck : ObservableCollection<Card>
    {
        private static Random random = new Random();

        public Deck()
        {
            Reset();
        }

        public Deck(string filename)
        {
            using (var sd = new StreamReader(filename))
            {
                while (!sd.EndOfStream)
                {
                    var nextCard = sd.ReadLine();
                    var cardParts = nextCard.ToString().Split(new char[] {' '});
                    var suit = cardParts[2] switch
                    {
                        "Diamonds" => Suits.Diamonds,
                        "Clubs" => Suits.Clubs,
                        "Hearts" => Suits.Hearts,
                        "Spades" => Suits.Spades,
                        _ => throw new InvalidDataException($"Unrecognized card suit: {cardParts[2]}")
                    };
                    var value = cardParts[0] switch
                    {
                        "Ace" => Values.Ace,
                        "Two" => Values.Two,
                        "Three" => Values.Three,
                        "Four" => Values.Four,
                        "Five" => Values.Five,
                        "Six" => Values.Six,
                        "Seven" => Values.Seven,
                        "Eight" => Values.Eight,
                        "Nine" => Values.Nine,
                        "Ten" => Values.Ten,
                        "Jack" => Values.Jack,
                        "Queen" => Values.Queen,
                        "King" => Values.King,
                        _ => throw new InvalidDataException($"Unrecognized card value: {cardParts[0]}")
                    };
                    Add(new Card(value, suit));
                }
            }
// Create a new StreamReader to read the file.
// For each line in the file, do the following four things:
// Use the String.Split method: var cardParts = nextCard.Split(new char[] { ' ' });
// Use a switch expression to get each card's suit: var suit = cardParts[2] switch {
// Use a switch expression to get each card's value: var value = cardParts[0] switch {
// Add the card to the deck.
        }

        public void WriteCards(string filename)
        {
            using (var writer = new StreamWriter(filename))
            {
                for (int i = 0; i < Count; i++)
                {
                    writer.WriteLine(this[i].Name);
                }
            }
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
            for (int value = 1; value <= 13; value++)
            for (int suit = 0; suit <= 3; suit++)
                Add(new Card((Values) value, (Suits) suit));
        }

        public void Shuffle()
        {
            List<Card> copy = new List<Card>(this);
            Clear();
            while (copy.Count > 0)
            {
                int index = random.Next(copy.Count);
                Card card = copy[index];
                copy.RemoveAt(index);
                Add(card);
            }
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
}