using System;
using System.Collections.Generic;
using System.Text;

namespace holdem
{
    public interface IPlayable
    {
        int StartStack { get; set; }
        void StartNewGame();
        void Trigger(int amount);
        Log GetLog();
        int AddPlayer(string nick, int position);
        bool DeletePlayer(string nick);
    }
}
