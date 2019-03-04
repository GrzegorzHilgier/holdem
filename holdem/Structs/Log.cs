using System;
using System.Collections.Generic;
using System.Text;


namespace holdem
{


    //represents typicall texas_holdem hand, 2 cards. Nullable


    internal struct Log
    {
        readonly string nick;
        readonly PlayerAction action;
        readonly int amount;
        readonly Hand hand;
        public override string ToString()
        {
            return $"{nick} {action.ToString()} " +
                $"{amount} {hand.Card1.Figure.ToString() }" +
                $"{amount} {hand.Card1.Suit.ToString() }"+
                $"{amount} {hand.Card2.Figure.ToString() }" +
                $"{amount} {hand.Card2.Suit.ToString() }";
        }
    }

}
