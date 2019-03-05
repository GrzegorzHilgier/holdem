using System;
using System.Collections.Generic;
using System.Text;

namespace holdem
{
    struct Hand<T>
    {
        private bool _isShown;
        List<T> _list;        
        ushort _maxItems;

        public bool IsShown { get => _isShown; internal set => _isShown = value; }
        public List<T> ItemList
        {
            get
            {
                if (IsShown) return _list;
                else return null;
            }
            private set => _list = value;
        }

        public ushort MaxItems { get => _maxItems; private set => _maxItems = value; }
        public void Fill(Func<T> func)
        {
            while (ItemList.Count < MaxItems)
                ItemList.Add(func());
        }

        public Hand(ushort maxItems)
        {
            _isShown = false;
            _list = new List<T>();
            _maxItems = maxItems;
        }
    }
}
