using System;
using System.Collections.Generic;
using System.Text;

namespace holdem
{
    public class Log : IRecordable
    {
        private List<string> History { get; set; }
        List<string> IRecordable.History { get => History;}
        private List<string> Status { get; set; }
        List<string> IRecordable.Status { get => Status; }
        public Log()
        {
            History = new List<string>();
            Status = new List<string>();
        }

        void IRecordable.Add(IRecordable log)
        {
            History.AddRange(log.History);
            Status.AddRange(log.Status);
        }

        //private List<HoldemPlayer> Players { get; set; }
        //public List<List<string>> ListOfItemStrings { get; set; }
        //internal Log(List<HoldemPlayer> players)
        //{
        //    Players = players;
        //    ListOfItemStrings = new List<List<string>>();
        //    foreach (HoldemPlayer player in Players)
        //    {
        //        List<string> buf = new List<string>();
        //        player.GetItemsString(out buf);
        //        ListOfItemStrings.Add(buf);
        //    }
        //}
    }
}
