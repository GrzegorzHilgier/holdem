using System;
using System.Collections.Generic;
using System.Text;

namespace holdem
{
    class HoldemPlayer : Hand<Card>
    {
        string _name;
        int _stack;
        public HoldemPlayer(string name, ushort maxItemsInHand = 2) : base(maxItemsInHand)
        {
            Name = name;
            Stack = 0;
        }

        public string Name { get => _name; set => _name = value; }
        public int Stack { get => _stack; private set =>_stack = value; }
        public int ChangeStackAmount(int amount)
        {
            Stack += amount;
            return Stack;
        }
        public override List<string> GetItemsString()
        {
            List<string> result = base.GetItemsString();
            result.Insert(0, Name);
            result.Add(Stack.ToString());
            return result;
        }
        public override string ToString()
        {
            return $"{Name} {base.ToString()} {Stack}";
        }
    }
}
