using System;
using System.Collections.Generic;

namespace holdem
{
    class Hand<T> 
    {
        List<T> itemList;
        ushort maxItems;
        private bool IsShown { get; set; }
        public List<T> ItemList{get => itemList; private set => itemList = value;}

        public ushort MaxItems { get => maxItems; private set => maxItems = value; }

        public void Fill(Func<T> func)
        {
            while (ItemList.Count < MaxItems)
                 ItemList.Add(func());
        }

        public Hand(ushort maxItemsInHand)
        {
            ItemList = new List<T>();
            MaxItems = maxItemsInHand;
            IsShown = true;
        }

        public virtual List<string> GetItemsString()
        {
            List<string> result = new List<string>();
            foreach (T item in ItemList)
                result.Add(item.ToString());
            return result;
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
