using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows;

using holdem;

namespace holdemTestUI.ViewModel
{
    class ViewModel :ObservableObject
    {

        string text1;
        string text2;
        private Deck deck;

        public ICommand CreateDeckCommand
        {
            get { return new SimpleCommand(CreateDeck); }
        }
        public ICommand ShuffleCommand
        {
            get { return new SimpleCommand(Shuffle); }
        }
        public ICommand DrawCardCommand
        {
            get { return new SimpleCommand(DrawCard); }
        }

        public string Text1
        { get => text1;
            set
            {
                text1 = value;
                RaisePropertyChangedEvent("Text1");
            } 
        }
        public string Text2
        {
            get => text2;
            set
            {
                text2 = value;
                RaisePropertyChangedEvent("Text2");
            }
        }

        public void Shuffle()
        {
            deck.Shuffle();
            Text1 = deck.ToString();
        }
        
        public void DrawCard()
        {
            Text2 += deck.DrawCard().ToString();
            Text1 = deck.ToString();
        }
        public void CreateDeck()
        {
            deck = new Deck();
            Text1 = deck.ToString();
        }

    }
}
