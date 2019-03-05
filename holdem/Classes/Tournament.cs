using System;
using System.Collections.Generic;
using System.Text;

namespace holdem
{
    class Tournament : IPlayable
    {
        public Tournament(TournamentInitData initData)
        {

        }

        Log IPlayable.GetLog()
        {
            throw new NotImplementedException();
        }

        string IPlayable.GetStatus()
        {
            throw new NotImplementedException();
        }

        void IPlayable.StartNewGame()
        {
            throw new NotImplementedException();
        }

        void IPlayable.Trigger(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
