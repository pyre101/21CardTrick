using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardTrick
{
    class Column
    {
        //members
        private int id;
        private int index;
        private Card[] cards;

        //constructors
        public Column()
        {
            id = 0;
            index = 0;
            cards = new Card[7];
        }

        public Column(int id)
        {
            this.id = id;
            index = 0;
            cards = new Card[7];
        }

        //methods
        public void addCard(Card card)
        {
            cards[index++] = card;
        }
    }
}
