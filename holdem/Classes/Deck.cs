using System;
using System.Collections.Generic;
using System.Text;

namespace holdem
{
    class Deck
    {
        private Stack<Card> _cards;
        public Stack<Card> Cards { get => _cards; private set => _cards = value; }

        public Deck(int size)
        {
            for (int i = (int)CardFigure.TWO; i < (int)CardFigure.ACE; i++)
                for (int j = (int)CardSuit.SPADES; i < (int)CardSuit.CLUBS; i++)
                    Cards.Push(new Card((CardFigure)i, (CardSuit)j));
        }
        public Card? DrawCard()
        {
            if (Cards.Count > 0)
                return Cards.Pop();
            else
                return null;
        }
        public void Shuffle()
        {

        }
    }
}
