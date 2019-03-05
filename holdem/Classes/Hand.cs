using System;
using System.Collections.Generic;
using System.Text;

namespace holdem.Classes
{
    class Hand<T> where T : new()
    {
        private bool isShown;
        List<T> itemList;
        ushort maxItems;

        public bool IsShown { get => isShown; internal set => isShown = value; }
        public List<T> ItemList
        {
            get
            {
                if (IsShown) return itemList;
                else
                {
                    List<T> blankList = new List<T>();
                    for (int i = 0; i < ItemList.Count; i++)
                        blankList.Add(new T());
                    return blankList;
                }
            }
            private set => itemList = value;
        }

        public ushort MaxItems { get => maxItems; private set => maxItems = value; }

        public void Fill(Func<T> func)
        {
            while (ItemList.Count < MaxItems)
                ItemList.Add(func());
        }

        public Hand(ushort maxItems)
        {
            IsShown = false;
            ItemList = new List<T>();
            MaxItems = maxItems;
        }
    }
}
