﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace _21CardTrick
{
    class Dealer : INotifyPropertyChanged
    {
        //members/properties
        private int dealNum;
        
        //Accessor for the deal num. Temporary measure
        public int DealNum
        {
            get
            {
                return dealNum;
            }
        }

        private Deck cardDeck;   //may cause some issues(?) with UI 
        public Board cardBoard { get; set; } 
        public Player player;
        //public Card[] cards21 { get; set; }
        public ObservableCollection<Card> cards21 { get; set; }
        public Card card1 { get; set; } //Temp. Only exists for testing purposes 

        //constructor
        public Dealer()
        {
            dealNum = 0;
            cardDeck = new Deck();

            //cards21 = new Card[21];
            cards21 = new ObservableCollection<Card>();

            player = new Player();
            cardBoard = new Board();
            card1 = new Card(4, 3); //Temp

            //Copy the 21 cards from the deck to the cards21 array
            for (int i = 0; i < 21; i++)
            {
                cards21.Add(cardDeck.getCard(i));
                //cards21[i] = cardDeck.getCard(i);
                cards21[i].Visible = true;
            }
            
                OnPropertyChanged(); //Pretty sure this isn't needed
            
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
            cardBoard.reset();
            dealNum++;
            OnPropertyChanged("card1");
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

            Deal();
         }

        #region INotifyPropertyChanged Members

        /// <summary>
        /// Property Changed Event Handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Property Changed Event Handler
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            try
            {

                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
            catch (Exception ex)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name + "() -> " + ex.Message);
            }
        }
        #endregion
    }
}
