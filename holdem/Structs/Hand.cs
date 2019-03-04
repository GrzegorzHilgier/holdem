using System;
using System.Collections.Generic;
using System.Text;

namespace holdem
{
    public struct Hand
    {
        private bool _isShown;
        Card _card1;
        Card _card2;

        public bool IsShown { get => _isShown; private set => _isShown = value; }
        public Card Card1
        {
            get
            {
                if (IsShown) return _card1;
                else return new Card(CardFigure.BLANK, CardSuit.BLANK);
            }

            private set => _card1 = value;
        }

        public Card Card2
        {
            get
            {
                if (IsShown) return _card2;
                else return new Card(CardFigure.BLANK,CardSuit.BLANK);
            }

            private set => _card2 = value;
        }
    }
}
