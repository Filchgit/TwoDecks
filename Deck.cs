using System;
using System.Collections.Generic;
using System.Text;


namespace TwoDecksWPF
{
    using System.Collections.ObjectModel;
    class Deck : ObservableCollection<Card>
    {
        private static Random random = new Random();
        // filling this in soon

        public Deck()
        {
            Reset();
        }

        public void Reset()
        {
            Clear();
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    Add(new Card((Values)value, (Suits)suit));
                }
            }

        }
        public Card Deal(int index)
        {
            Card cardToDeal = base[index];
            base.RemoveAt(index);
            return cardToDeal;
        }

        public void Shuffle()
        {
            List<Card> cardsToShuffle = new List<Card>(this);
            Clear();
            while(cardsToShuffle.Count>0)
            {
             int indexToCopy =  random.Next(cardsToShuffle.Count);
                Card card = cardsToShuffle[indexToCopy];
                cardsToShuffle.RemoveAt(indexToCopy);
                Add(card);              
            }
        }
        public void Sort()
        {
            IComparer<Card> cardComparerByValue = new CardComparerByValue();
            List<Card> cardsToSort = new List<Card>(this);
            Clear();
            cardsToSort.Sort(cardComparerByValue);
            foreach(Card card in cardsToSort)
            {
                Add(card);
            }
        }
    }
}
