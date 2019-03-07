using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Collections.Generic;
using holdem;

namespace holdemTestUI.ViewModel
{
    class ViewModel :ObservableObject
    {


        private IPlayable Game { get; set; }
        private ObservableCollection<List<string>> players = new ObservableCollection<List<string>>();
        private ObservableCollection<string> player = new ObservableCollection<string>();
        private ObservableCollection<string> history = new ObservableCollection<string>();
        private ObservableCollection<string> status = new ObservableCollection<string>();



        public ICommand StartTournamentCommand
        {
            get { return new SimpleCommand(StartTournament); }
        }
        public ICommand TriggerCommand
        {
            get { return new SimpleCommand(Trigger); }
        }

        public IEnumerable<string> History { get => history; }
        public IEnumerable<string> Status { get => status; }


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
        }


    }
}
