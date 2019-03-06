using System;
using System.Collections.Generic;
using System.Text;

namespace holdem
{
    public class Log
    {
        private List<HoldemPlayer> Players { get; set; }
        public List<List<string>> ListOfItemStrings { get; set; }
        internal Log(List<HoldemPlayer> players)
        {
            Players = players;
            ListOfItemStrings = new List<List<string>>();
            foreach (HoldemPlayer player in Players)
                ListOfItemStrings.Add(player.GetItemsString());
        }

    }
}
