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
                cards[i] = new Card(((i % 13) + 1), ((i / 13) + 1));
            }
            top = 0;
        }
        public Card Peek() { return null; }
        public void Shuffle() 
        {
            for (int i = top;  i < cards.Length; i++)
            {
                Random rnd = new Random();
                int j = rnd.Next(i,cards.Length);
                Swap(i,j);
            }
        }
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
