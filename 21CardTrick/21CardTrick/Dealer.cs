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
        public Card card1 { get; set; }//Temp

        //constructor
        public Dealer()
        {
            dealNum = 0;
            cards21 = new Card[21];
            player = new Player();
            cardBoard = new Board();
            card1 = new Card(4, 3); //Temp
        }

        //methods
        public void Deal()
        {
            
            for(int i = 0; i < 21; i++)
            //deckOf21[i] starting at 0-20
            //addToColumn(int id, Card card)  id is column
            {
                cardBoard.addToColumn(i%3, cards21[i]);
            }            
            dealNum++;
        }

        public Card revealCard()
        {
            return cards21[10]; //card [10] = 11th card
        }

        public void pickupCards(int columnNum)  
        {
            Card[] tempCol = cardBoard.pickupColumn(columnNum);
            for (int i = 7; i < 14; i++)  //0-6, 7-13, 14-20
                cards21[i] = tempCol[i - 7];

            if (columnNum == 0)
            {
                tempCol = cardBoard.pickupColumn(1);
                for (int i = 0; i < 7; i++)  //0-6
                    cards21[i] = tempCol[i];
                tempCol = cardBoard.pickupColumn(2);
                for (int i = 0; i < 7; i++)
                    cards21[i + 14] = tempCol[i];
            }
            if (columnNum == 1)
            {
                tempCol = cardBoard.pickupColumn(0);
                for (int i = 0; i < 7; i++)  //0-6
                    cards21[i] = tempCol[i];
                tempCol = cardBoard.pickupColumn(2);
                for (int i = 0; i < 7; i++)
                    cards21[i + 14] = tempCol[i];
            }
            if (columnNum == 2)
            {

                tempCol = cardBoard.pickupColumn(0);
                for (int i = 0; i < 7; i++)  //0-6
                    cards21[i] = tempCol[i];
                tempCol = cardBoard.pickupColumn(1);
                for (int i = 0; i < 7; i++)
                    cards21[i + 14] = tempCol[i];
            }
         }
    }
}
