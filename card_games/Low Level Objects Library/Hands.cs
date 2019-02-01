using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Low_Level_Objects_Library
{
    public class Hand : IEnumerable
    {
        private List<Card> hand;


        public Hand()
        {
        }

        public Hand(List<Card> hand)
        {
            this.hand = hand;
        }

        public int GetCount()
        {
            return this.hand.Count;
        }

        public Card GetCard(int index)
        {
            return this.hand[index];
        }

        public void Add(Card card)
        {
            this.hand.Add(card);
        }

        public bool Contains(Card card)
        {
            return this.hand.Contains(card);
        }

        public bool Remove(Card card)
        {
            return this.hand.Remove(card);
        }

        public void RemoveAt(int index)
        {
            this.hand.RemoveAt(index);
        }
        public void Sort()
        {
            this.hand.Sort();
        }


        public IEnumerator GetEnumerator()
        {
            return hand.GetEnumerator();
        }
    }
}

