﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardTrick
{
    class Player
    {
        public bool hasCardSelected;
        private Card selectedCard;


        public Column indicateCouloumn(Column[] coloumns, int coulmnNumber)
        {
            return coloumns[coulmnNumber];
        }


        public Card selectCard(Card.CardSuit suit, int Value)
        {
            if (!hasCardSelected)
            {
                Card C = new Card();
                C.Value = Value;
                C.Suit = suit;
                hasCardSelected = true;
                selectedCard = C;
            }

            return selectedCard;
        }


        public bool isCorrectCard(Card card)
        {
            if (card.Value == selectedCard.Value && card.Suit == selectedCard.Suit)
            {
                return true;
            }

            return false;
        }
    }
}