using System;
using System.Collections.Generic;


namespace holdem
{
    //class InitData
    //{
    //    private Dictionary<string, PlayerType> players;

    //    public Dictionary<string, PlayerType> Players { get => players; private set => players = value; }

    //    public InitData()
    //    {
    //        Players = new Dictionary<string, PlayerType>();
    //    }
    //    public virtual bool AddPlayer(string name, PlayerType type)
    //    {
    //        Players.Add(name, type);
    //        return true;
    //    }
    //}

    //class TournamentInitData : InitData
    //{
    //    int startStack;
    //    static readonly int minPlayersAmount = 2;
    //    static readonly int maxPlayersAmount = 10;
    //    static readonly int minStartStack = 500;
    //    static readonly int maxStartStack = 10000;

    //    public TournamentInitData()
    //    {
    //        StartStack = 1500;
    //    }

    //    public int StartStack
    //    {
    //        get => startStack;
    //        set
    //        {
    //            if(value >= minStartStack && value <= maxStartStack)
    //                startStack = value;
    //        }
    //    }

    //    public override bool AddPlayer(string name, PlayerType type)
    //    {
    //        if (Players.Count <= maxPlayersAmount)
    //            return base.AddPlayer(name, type);
    //        else return false;
    //    }
    //}
}
