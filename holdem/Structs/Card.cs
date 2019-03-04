using System;
using System.Collections.Generic;
using System.Text;

namespace holdem
{
    //represents single card instance
    public struct Card
    {
        private CardFigure _figure;
        private CardSuit _suit;

        public CardFigure Figure { get => _figure; private set => _figure = value; }
        public CardSuit Suit { get => _suit; private set => _suit = value; }
        public Card(CardFigure figure, CardSuit suit)
        {           
            _suit = suit;
            _figure = figure;
        }
    };
}
