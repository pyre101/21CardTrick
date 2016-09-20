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
        public Card[] cards;

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

        public int getId()
        {
            return id;
        }

//<<<<<<< HEAD
        //Getters and setters
        Card getCard(int i)
        {
            return cards[i];
        }
        void setCard(int i, Card c)
        {
            //Shallow copy?
            cards[i] = c;
        }
        
//=======
        public Card[] getCards()
        {
            return cards;
        }
//>>>>>>> refs/remotes/origin/master
    }
}
