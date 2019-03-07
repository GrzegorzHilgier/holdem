using System;
using System.Collections.Generic;
using System.Text;

namespace holdem
{
    public enum TurnStage{ DISTRIBUTION, PREFLOP, FLOP, TURN, RIVER}
    public class Turn : IPlayable
    {

        public List<HoldemPlayer> Players { get; private set; }
        private CardDeck Deck { get; set; }
        public TurnStage ActualStage { get; private set; }

        IRecordable IPlayable.GameLog => throw new NotImplementedException();

        public Turn(List<HoldemPlayer> players)
        {
            Players = new List<HoldemPlayer>();
            Players.AddRange(players);
            Deck = new CardDeck();
            TurnStage ActualStage = TurnStage.DISTRIBUTION;
        }

        event EventHandler<FinishEventArgs> IPlayable.FinishEvent
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        IRecordable IPlayable.Trigger(int amount)
        {
            throw new NotImplementedException();
        }

        bool IPlayable.AddPlayer(string name, int position)
        {
            throw new NotImplementedException();
        }

        bool IPlayable.DeletePlayer(string name)
        {
            throw new NotImplementedException();
        }
    }
}
