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


        public ICommand StartTournamentCommand
        {
            get { return new SimpleCommand(StartTournament); }
        }

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
            game.AddPlayer("gorz", 0);
            game.AddPlayer("rek", 0);
            game.StartStack = 1500;
            game.StartNewGame();
            Log log = game.GetLog();
            List<List<string>> buf = log.ListOfItemStrings;
            //players.Add(new List<string>());
            //for (int i = 0; i < buf[0].Count; i++)
            //    players[0].Add(buf[0][i]);

            for (int i = 0; i < buf.Count; i++)
            {
                players.Add(new List<string>());
                for (int j = 0; j < buf[i].Count; j++)
                {

                    players[i].Add(buf[i][j]);
                }
            }
                   

        }


    }
}
