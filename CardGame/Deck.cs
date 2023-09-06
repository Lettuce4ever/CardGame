using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Deck
    {
        private Card[] cards;
        private int top;

        public Deck() 
        { 
        cards = new Card[52];
            int val = 0;
            for (int i=0; i<52; i++)
            {
                cards[i] = new Card(((val % 13) + 1), ((val / 13) + 1));
                    val++;
            }
            top = 0;
        }
        public Card Peek() { return null; }
        public void Shuffle() { }
        public Card Deal() 
        {
            Card newcard = cards[top];
            top++;
            return newcard;
        }

        public void Reset() 
        {
            top= 0;
        }
    }
}
