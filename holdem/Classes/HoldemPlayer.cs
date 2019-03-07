using System;
using System.Collections.Generic;
using System.Text;

namespace holdem
{
    public class HoldemPlayer : Player<Card>
    {
        public PlayerType Type { get; private set; }

        public HoldemPlayer(string name, PlayerType playerType = PlayerType.HUMAN, ushort maxItemsInHand = 2) : base(name, maxItemsInHand)
        {
            Type = playerType;
        }
    }
}
