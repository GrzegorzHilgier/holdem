using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Collections.Generic;
using holdem;

namespace holdemTestUI.ViewModel
{
    class ViewModel :ObservableObject
    {

  
        public Tournament tournament;
        private ObservableCollection<List<string>> players = new ObservableCollection<List<string>>();
        private ObservableCollection<string> player = new ObservableCollection<string>();
        private ObservableCollection<string> history = new ObservableCollection<string>();
        private ObservableCollection<string> status = new ObservableCollection<string>();


        public ICommand StartTournamentCommand
        {
            get { return new SimpleCommand(StartTournament); }
        }
        public IEnumerable<string> History { get => history; }
        public IEnumerable<string> Status { get => status; }
        public IEnumerable<List<string>> Players { get => players; }
        public IEnumerable<string> Player { get => player; }

        public void StartTournament()
        {

            tournament = new Tournament();
            IPlayable game = tournament;
            game.AddPlayer("Grzegorz", 0);
            game.AddPlayer("Marek", 0);
            game.AddPlayer("Borys", 0);
            game.AddPlayer("Arnold", 0);
            game.AddPlayer("Grzeg", 0);
            game.AddPlayer("Mar", 0);
            game.AddPlayer("Bor", 0);
            game.AddPlayer("Arn", 0);


            IRecordable log = game.Trigger(0);
            foreach (string item in log.History)
                history.Add(item);
            foreach (string item in log.Status)
                status.Add(item);


        }


    }
}
