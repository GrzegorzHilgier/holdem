using System;
using System.Collections.Generic;
using System.Text;

namespace holdem
{
    public interface IPlayable
    {
        List<HoldemPlayer> Players { get; }
        IRecordable GameLog { get;}
        IRecordable Trigger(int amount);
        event EventHandler<FinishEventArgs> FinishEvent;
        bool AddPlayer(string name, int position);
        bool DeletePlayer(string name);
        //save
        //load
    }
}
