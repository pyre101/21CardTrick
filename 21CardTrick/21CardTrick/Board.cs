using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardTrick
{
    class Board
    {
<<<<<<< HEAD
        #region TempCode
        /*Temp code to test the GUI with*/
        Board()
        {
            c1 = new Card();
            c1.Suit = Card.CardSuit.Club;
            c1.Value = 5;
        }
        private Card c1;
        public Card Card1
        {
            get
            {
                return c1;
            }
            set
            {
                c1 = value;
            }
        }
        #endregion
=======
        //members
        private Column[] columns;

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
>>>>>>> refs/remotes/origin/master
    }
}
