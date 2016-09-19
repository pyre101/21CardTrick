using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardTrick
{
    class Dealer
    {
        //members/properties
        private int dealNum;
        //private Deck cardDeck;   //may cause some issues(?) with UI 
        private Board cardBoard; 
        public Player player;
        private Card[] cards21;


        //constructor
        Dealer()
        {
            dealNum = 0;
            cards21 = new Card[21];
        }

        //methods
        public void Deal()
        {
            int columnNum = 0;
            for(int i = 0; i < 21; i++)
            //deckOf21[i] starting at 0-20
            //addToColumn(int id, Card card)  id is column
            {
                if (columnNum == 2)
                {
                    cardBoard.addToColumn(columnNum, cards21[i]);
                    columnNum = 0;
                }
               if (columnNum == 1)
                {
                    cardBoard.addToColumn(columnNum, cards21[i]);
                    columnNum++;
                }

                if (columnNum == 0)
                {
                    cardBoard.addToColumn(columnNum, cards21[i]);
                    columnNum++;
                }
            }
            dealNum++;
        }

        public Card revealCard()
        {
            return cards21[10]; //card [10] = 11th card
        }

        public void pickupCards()  //issue!!!!!!!
        {
            int chosenCol = player.indicateCouloumn();  //Dealer needs to know what column player chooses
            Column tempCol = cardBoard.columns[1];

            //switch columns so chosen column is in middle
            cardBoard.columns[1] = cardBoard.columns[chosenCol];
            cardBoard.columns[chosenCol] = tempCol;

            int indexRan = 0; //index for where deckOf21 is at
            for (int i = 0; i < 3; i++)  //loads the deck from column 1 to column 3
                for (int j = 0; j < 7; j++)
                    cardDeck.deckOf21[indexRan] = cardBoard.columns[i].cards[j];
        }
    }
}
