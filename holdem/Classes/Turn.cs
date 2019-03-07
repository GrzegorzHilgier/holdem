using System;
using System.Collections.Generic;
using System.Text;

namespace holdem.Classes
{
    class Turn
    {
        internal List<HoldemPlayer> PlayersInTurn { get; private set; }
        private CardDeck Deck { get; set; }

    }
}
