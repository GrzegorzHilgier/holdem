using System.Collections.Generic;

namespace holdem
{
    public class CardDeck
    {
        private List<Card> _cards;
        public List<Card> Cards { get => _cards; private set => _cards = value; }

        private void DeckFill()
        {
            for (int i = (int)CardFigure.TWO; i <= (int)CardFigure.ACE; i++)
                for (int j = (int)CardSuit.SPADES; j <= (int)CardSuit.CLUBS; j++)
                    Cards.Add(new Card((CardFigure)i, (CardSuit)j));
        }
    
        public CardDeck()
        {
            _cards = new List<Card>();
            Shuffle();
        }

        public Card DrawCard()
        {
            Card buf;
            if (Cards.Count == 0)
                Shuffle();
            buf = Cards[0];
            Cards.RemoveAt(0);
                return buf;
        }

        public void Shuffle()
        {
            Cards.RemoveAll(x=>true);
            DeckFill();
            Cards.Shuffle();
        }
        
        public override string ToString()
        {
            string result = string.Empty;
            result += $"Total cards : { Cards.Count.ToString()};  ";
            foreach (Card card in Cards)
            {
                result += card.ToString() + ";   ";
            }
            return result;

        }
    }
}
