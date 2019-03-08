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
        public IRecordable TurnLog { get; private set; }
        public TurnStage ActualStage { get; private set; }

        IRecordable IPlayable.GameLog => throw new NotImplementedException();

        public Turn(List<HoldemPlayer> players)
        {
            Players = players;
            Deck = new CardDeck();
            TurnLog = new Log();
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

            switch(ActualStage)
            {
                case TurnStage.DISTRIBUTION:
                    foreach (HoldemPlayer p in Players) p.Fill(Deck.DrawCard);
                    TurnLog.History.Add("Cards distributed");
                    break;
            }
            return TurnLog;
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
