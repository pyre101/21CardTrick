using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardTrick
{
    class Deck
    {
        //variables
        //constructor
        //create deck array[52]
        //add cards to deck
        //shuffle deck
        //shuffle function


        //private static Random rng = new Random();

        //public static void Shuffle<T>(this IList<T> list)
        //{
        //    int n = list.Count;
        //    while (n > 1)
        //    {
        //        n--;
        //        int k = rng.Next(n + 1);
        //        T value = list[k];
        //        list[k] = list[n];
        //        list[n] = value;
        //    }
        //}


        //Variables
        private Card[] fullDeck;
        public Card[] deckOf21;   //issue with Dealer; need access to this
        private int cardCount = 0;
        private static Random rng = new Random();

        //Constructor
        public Deck()
        {   
            //Create 52 card deck
            fullDeck = new Card[52];

            //Populate deck with cards
            for (int suit = 0; suit < 4; suit++)
            {
                for (int face = 0; face < 13; face++)
                {
                    fullDeck[cardCount++] = new Card(face, suit);
                }
            }

            //Shuffle deck
            Shuffle();

            //Return 21 cards
            Random21();
        }

        public void Shuffle()
        {
            int n = fullDeck.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = fullDeck[k];
                fullDeck[k] = fullDeck[n];
                fullDeck[n] = value;
            }
        }

        public Card[] Random21()
        {
            for (int i = 0; i < 21; i++)
            {
                deckOf21[i] = fullDeck[i];
            }

            return deckOf21;
        }
    }
}
