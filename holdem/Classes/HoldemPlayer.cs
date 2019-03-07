using System;
using System.Collections.Generic;
using System.Text;

namespace holdem
{
    public class HoldemPlayer : Player<Card>
    {

        public string Name { get; private set; }
        public int Stack { get; private set; }
        public PlayerType Type { get; private set; }

        public HoldemPlayer(string name, PlayerType playerType = PlayerType.HUMAN, ushort maxItemsInHand = 2) : base(maxItemsInHand)
        {
            Name = name;
            Stack = 0;
            Type = playerType;
        }

        public int ChangeStackAmount(int amount)
        {
            Stack += amount;
            return Stack;
        }
        public override bool GetItemsString(out List<string> result)
        {

            if (base.GetItemsString(out result))
            {
                result.Insert(0, Name);
                result.Add(Stack.ToString());
                return true;
            }
            else
            {
                result.Insert(0, Name);
                result.Add(Stack.ToString());
                return false;
            }

        }
        public override string ToString()
        {
            return $"{Name}, {base.ToString()}, {Stack}";
        }
    }
}
