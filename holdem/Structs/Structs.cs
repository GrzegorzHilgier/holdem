using System;
using System.Collections.Generic;
using System.Text;


namespace holdem
{
    //represents single card instance
    public struct Card
    {
        private short _figure;
        private CardSuit _suit;

        public short Figure { get => _figure; private set => _figure = value; }
        public CardSuit Suit { get => _suit; private set => _suit = value; }
    };

    //represents typicall texas_holdem hand, 2 cards. Nullable
    public struct Hand
    {
        private bool _isShown;
        Card? _card1;
        Card? _card2;

        public bool IsShown { get => _isShown; private set => _isShown = value; }
        public Card? Card1
        {
            get
            {
                if (IsShown) return _card1;
                else return null;
            }

            private set => _card1 = value;
        }

        public Card? Card2      
        {
            get
            {
                if (IsShown) return _card2;
                else return null;
            }

            private set => _card2 = value;
        }
    }

    internal struct Log
    {
        readonly string nick;
        readonly PlayerAction action;
        readonly int amount;
        readonly Hand hand;
        public override string ToString()
        {
            return $"{nick} {action.ToString()} " +
                $"{amount} {hand.Card1.Value.Figure }" +
                $"{amount} {hand.Card1.Value.Suit }"+
                $"{amount} {hand.Card2.Value.Figure }" +
                $"{amount} {hand.Card2.Value.Suit }";
        }
    }
    public struct Status
    {

    }

}
