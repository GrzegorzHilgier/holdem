using System;
using System.Collections.Generic;
using System.Text;

namespace holdem
{
    enum TournamentStage {INIT,DEALERDRAW,TURN,FINISH }
    public class Tournament : IPlayable
    {
        internal List<HoldemPlayer> PlayersInGame { get; private set; }
        public int StartStack { get; set; }
        private Log log;
        private TournamentStage stage;
        

        public Tournament()
        {
            PlayersInGame = new List<HoldemPlayer>();
            StartStack = 0;
            
        }

        int IPlayable.AddPlayer(string nick, int position)
        {
            PlayersInGame.Add(new HoldemPlayer(nick));
            return PlayersInGame.Count;
        }

        bool IPlayable.DeletePlayer(string nick)
        {
            throw new NotImplementedException();
        }

        Log IPlayable.GetLog()
        {
            return log;
        }

        void IPlayable.StartNewGame()
        {
            CardDeck deck = new CardDeck();
            log = new Log(PlayersInGame);
            foreach (HoldemPlayer player in PlayersInGame)
            {
                player.Fill(deck.DrawCard);
                player.ChangeStackAmount(StartStack);
            }           

        }

        void IPlayable.Trigger(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
