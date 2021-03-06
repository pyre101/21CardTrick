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

        private Deck cardDeck;
        public Board cardBoard { get; set; } 
        public Player player;
        public ObservableCollection<Card> cards21 { get; set; }
        public ObservableCollection<Card> playersCard { get; set; }

        //constructor
        public Dealer()
        {
            dealNum = 0;
            cardDeck = new Deck();

            //cards21 = new Card[21];
            cards21 = new ObservableCollection<Card>();

            player = new Player();
            cardBoard = new Board();

            //Copy the 21 cards from the deck to the cards21 array
            for (int i = 0; i < 21; i++)
            {
                cards21.Add(cardDeck.getCard(i));
                cards21[i].Visible = true;
            }
            cardBoard = new Board();
            player = new Player();
            playersCard = new ObservableCollection<Card>();
            OnPropertyChanged();
        }

        //methods
        public void Deal()
        {
            cardBoard.clearColumns();
            for(int i = 0; i < 21; i++)
            //deckOf21[i] starting at 0-20
            //addToColumn(int id, Card card)  id is column
            {
                cardBoard.addToColumn(i%3, cards21[i]);
            }
            cardBoard.reset();

            dealNum++;
            if (dealNum == 4)
            {
                playersCard.Add(cards21[10]);
            }
            OnPropertyChanged();
        }

        public Card revealCard()
        {
            return cards21[10]; //card [10] = 11th card
        }

        public void pickupCards(int columnNum)  
        {
            int k = 0; //for start points of columns that weren't chosen
            for (int i = 0; i < 3; i++)
            {
                Card[] tempCol = cardBoard.pickupColumn(i);
                if (i != columnNum)
                {
                    for (int j = 0; j < 7; j++)
                        cards21[j + (k * 7)] = tempCol[j];
                    k = k + 2;
                }
                else
                {
                    for (int j = 0; j < 7; j++)
                        cards21[j + 7] = tempCol[j];
                }
                
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
