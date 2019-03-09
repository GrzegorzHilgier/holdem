using System;
using System.Collections.Generic;
using System.Text;

namespace holdem
{
    public enum TournamentStage {INIT, DEALERDRAW, TURN, FINISH }

    public class Tournament : IPlayable
    {
        public TournamentStage ActualStage { get; private set; }
        public TournamentStage NextStage { get; private set; }
        private int TurnCounter { get; set; }
        public List<HoldemPlayer> Players { get; private set; }
        public int StartStack { get; set; }

        public IRecordable GameLog { get; private set; }
        public IPlayable ActualTurn { get; private set; }

        public event EventHandler<FinishEventArgs> FinishEvent;
        private delegate IRecordable ChildTrigger(int amount);

        public Tournament()
        {
            Players = new List<HoldemPlayer>();
            StartStack = 1500;
            ActualStage = NextStage = TournamentStage.INIT;
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
            ActualStage = NextStage;
            GameLog.Status.Add($"{ActualStage.ToString()}");
            switch (ActualStage)
            {
                case TournamentStage.INIT:
                    GameLog.History.Add("Tournament Started");
                    GameLog.History.Add($"Players  joined : {Players.Count}");
                    foreach (HoldemPlayer p in Players) p.ChangeStackAmount(StartStack);
                    NextStage = TournamentStage.TURN;
                    break;

                case TournamentStage.DEALERDRAW:
                    break;

                case TournamentStage.TURN:

                    if (Players.Count == 1)
                    {
                        GameLog.History.Add("Tournament finished");
                        GameLog.History.Add($"Player { Players[0]} won!");
                        NextStage = TournamentStage.FINISH;
                        break;
                    }
                    else
                    {
                        if (ActualTurn == null)
                        {
                            TurnCounter++;
                            GameLog.History.Add($"Turn nr: {TurnCounter} started");
                            ActualTurn = new Turn(Players);
                            break;
                        }
                        else
                        {
                            GameLog.Add(ActualTurn.Trigger(amount));
                            break;
                        }
                    }

                case TournamentStage.FINISH:
                    break;
            }
            return GameLog;
        }
    }
}
