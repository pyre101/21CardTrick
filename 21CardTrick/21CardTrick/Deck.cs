using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardTrick
{
    class Deck
    {
        //Variables
        private Card[] fullDeck;
        private Card[] deckOf21;
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
                for (int face = 1; face < 14; face++)
                {
                    fullDeck[cardCount++] = new Card(face, suit);
                }
            }

            //Shuffle deck
            Shuffle();

            //Create 21 card deck
            Random21();
        }

        private void Shuffle()
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

        private void Random21()
        {
            deckOf21 = new Card[21];

            for (int i = 0; i < 21; i++)
            {
                deckOf21[i] = fullDeck[i];
            }
        }

        public Card getCard(int i){
            return fullDeck[i];
        }
    }
}
