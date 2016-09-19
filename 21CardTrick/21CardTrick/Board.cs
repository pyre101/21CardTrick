﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardTrick
{
    class Board
    {
        //members
        public Column[] columns; 

        //constructors
        public Board()
        {
            columns = new Column[3];
            for (int i = 0; i < 3; i++)
            {
                columns[i] = new Column(i);
            }
        }

        //methods
        public void addToColumn(int id, Card card)
        {
            columns[id].addCard(card);
        }

        public Card[] pickupColumn(int colId)
        {
            return columns[colId].getCards();
        }
    }
}
