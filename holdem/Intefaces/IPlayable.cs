using System;
using System.Collections.Generic;
using System.Text;

namespace holdem
{
    interface IPlayable
    {
        void StartNewGame();
        void Trigger(int amount);
        Log GetLog();
        string GetStatus();
    }

    internal interface IHasBlankValue
    {

    }
}
