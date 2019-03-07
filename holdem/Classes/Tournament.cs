using System;
using System.Collections.Generic;
using System.Text;

namespace holdem
{
    enum TournamentStage {INIT, DEALERDRAW, TURN, FINISH }

    public class Tournament : IPlayable
    {
        internal TournamentStage ActualStage { get; private set; }
        private int TurnCounter { get; set; }
        public List<HoldemPlayer> Players { get; private set; }
        public int StartStack { get; set; }

        public IRecordable GameLog { get; private set; }
        public Turn ActualTurn { get; private set; }

        public event EventHandler<FinishEventArgs> FinishEvent;

        public Tournament()
        {
            Players = new List<HoldemPlayer>();
            StartStack = 1500;
            ActualStage = TournamentStage.INIT;
            GameLog = new Log();
            TurnCounter = 0;
        }

        bool IPlayable.AddPlayer(string nick, int position)
        {
            Players.Add(new HoldemPlayer(nick));
            return true;
        }

        bool IPlayable.DeletePlayer(string nick)
        {
            throw new NotImplementedException();
        }

        IRecordable IPlayable.Trigger(int amount)
        {
            switch (ActualStage)
            {
                case TournamentStage.INIT:
                    GameLog.History.Add("Tournament Started");
                    GameLog.History.Add($"Players  joined : {Players.Count}");
                    GameLog.Status.Add($"turn nr: {TurnCounter} will start shortly");
                    break;
                case TournamentStage.DEALERDRAW:
                    break;
                case TournamentStage.TURN:
                    break;
                case TournamentStage.FINISH:
                    break;
            }
            return GameLog;
        }
    }
}
