using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Collections.Generic;
using holdem;

namespace holdemTestUI.ViewModel
{
    class ViewModel :ObservableObject
    {
        private IPlayable Game { get; set; }
        private ObservableCollection<string> player = new ObservableCollection<string>();
        private ObservableCollection<string> history = new ObservableCollection<string>();
        private ObservableCollection<string> status = new ObservableCollection<string>();
        private ObservableCollection<ObservableCollection<string>> PlayersToShow = new ObservableCollection<ObservableCollection<string>>();


        public ICommand StartTournamentCommand
        {
            get { return new SimpleCommand(StartTournament); }
        }
        public ICommand TriggerCommand
        {
            get { return new SimpleCommand(Trigger); }
        }

        public ViewModel()
        {
            for (int i = 0; i < 10; i++)
                PlayersToShow.Add(new ObservableCollection<string>());
            StartTournament();
          

        }
        public IEnumerable<string> History { get => history; }
        public IEnumerable<string> Status { get => status; }
        public IEnumerable<string> Player1 { get => PlayersToShow[0]; }
        public IEnumerable<string> Player2 { get => PlayersToShow[1]; }
        public IEnumerable<string> Player3 { get => PlayersToShow[2]; }
        public IEnumerable<string> Player4 { get => PlayersToShow[3]; }
        public IEnumerable<string> Player5 { get => PlayersToShow[4]; }
        public IEnumerable<string> Player6 { get => PlayersToShow[5]; }
        public IEnumerable<string> Player7 { get => PlayersToShow[6]; }
        public IEnumerable<string> Player8 { get => PlayersToShow[7]; }
        public IEnumerable<string> Player9 { get => PlayersToShow[8]; }
        public IEnumerable<string> Player10 { get => PlayersToShow[9]; }
        public void StartTournament()
        {

            Game = new Tournament();
            Game.AddPlayer("Grzegorz", 0);
            Game.AddPlayer("Marek", 0);
            Game.AddPlayer("Borys", 0);
            Game.AddPlayer("Arnold", 0);
            Game.AddPlayer("Grzeg", 0);
            Game.AddPlayer("Mar", 0);
            Game.AddPlayer("Bor", 0);
            Game.AddPlayer("Arn", 0);
            Game.AddPlayer("Grzeg", 0);
            Game.AddPlayer("Mar", 0);

            Trigger();
        }

        public void Trigger()
        {
            IRecordable log = Game.Trigger(0);
            history.Clear();
            foreach (string item in log.History)
                history.Add(item);
            status.Clear();
            foreach (string item in log.Status)
                status.Add(item);
            player.Clear();
            for(int i =0; i<Game.Players.Count;i++)
            {
                PlayersToShow[i].Clear();
                PlayersToShow[i].Add(Game.Players[i].Name);
                List<string> items;
                Game.Players[i].GetItemsString(out items);
                foreach(string item in items)
                    PlayersToShow[i].Add(item);
                PlayersToShow[i].Add(Game.Players[i].Stack.ToString());

            }
        }


    }
}
