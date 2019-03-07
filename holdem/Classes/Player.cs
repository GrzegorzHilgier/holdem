using System;
using System.Collections.Generic;

namespace holdem
{
    public class Player<T> 
    {
        List<T> itemList;
        ushort maxItems;
        private bool ItemsShown { get; set; }
        private List<T> ItemList{get => itemList;  set => itemList = value;}

        public ushort MaxItems { get => maxItems; private set => maxItems = value; }

        public void Fill(Func<T> func)
        {
            while (ItemList.Count < MaxItems)
                 ItemList.Add(func());
        }

        public Player(ushort maxItemsInHand)
        {
            ItemList = new List<T>();
            MaxItems = maxItemsInHand;
            ItemsShown = true;
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
