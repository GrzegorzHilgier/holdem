using System;
using System.Collections.Generic;
using System.Text;

namespace holdem
{
    public class Tournament : IPlayable
    {
        internal List<HoldemPlayer> PlayersInGame { get; set; }
        private Log log;
        public Tournament()
        {
            PlayersInGame = new List<HoldemPlayer>();
            StartStack = 0;
        }

        public int StartStack { get; set; }


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

            foreach (HoldemPlayer player in PlayersInGame)
            {
                player.Fill(deck.DrawCard);
                player.ChangeStackAmount(StartStack);
            }

            log = new Log(PlayersInGame);

        }

        void IPlayable.Trigger(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
