using System;
using System.Collections.Generic;

namespace holdem
{
    public class Player<T> 
    {
        public string Name { get; private set; }
        public int Stack { get; private set; }
        private bool ItemsShown { get; set; }
        private List<T> ItemList{ get; set; }
        public ushort MaxItems { get; private set; }

        public void Fill(Func<T> func)
        {
            while (ItemList.Count < MaxItems)
                 ItemList.Add(func());
        }

        public Player(string name, ushort maxItemsInHand)
        {
            ItemList = new List<T>();
            MaxItems = maxItemsInHand;
            ItemsShown = true;
            Stack = 0;
        }

        internal int ChangeStackAmount(int amount)
        {
            Stack += amount;
            return Stack;
        }

        public virtual bool GetItems(out List<T> list)
        {
            list = new List<T>();
            if (ItemsShown)
            {               
                foreach (T item in ItemList)
                    list.Add(item);
                return true;
            }
            else return false;
        }

        public virtual bool  GetItemsString(out List<string> result)
        {
            result = new List<string>();
            if (ItemsShown)
            {
                foreach (T item in ItemList)
                    result.Add(item.ToString());
                return true;
            }
            else return false;
        }

        public override string ToString()
        {
            string result = string.Empty;
            foreach (T item in ItemList)
                result += item.ToString();
            return result;
        }
    }
}
