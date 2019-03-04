using System;
using System.Collections.Generic;
using System.Text;

namespace holdem
{
    public class Deck
    {
        private List<Card> _cards;
        public List<Card> Cards { get => _cards; private set => _cards = value; }

        public Deck()
        {
            _cards = new List<Card>();
            for (int i = (int)CardFigure.TWO; i <= (int)CardFigure.ACE; i++)
                for (int j = (int)CardSuit.SPADES; j <= (int)CardSuit.CLUBS; j++)
                    Cards.Add(new Card((CardFigure)i, (CardSuit)j));
        }
        public Card? DrawCard()
        {
            if (Cards.Count > 0)
            {
                var buf = Cards[0];
                Cards.RemoveAt(0);
                return buf;
            }
            else
                return null;
        }
        public void Shuffle()
        {
            Cards.Shuffle();
        }
        public override string ToString()
        {
            string result = string.Empty;
            result += $"Total cards : { Cards.Count.ToString()};  ";
            foreach (Card card in Cards)
            {
                result += card.ToString() + ";   ";
            }
            return result;

        }
    }
}
