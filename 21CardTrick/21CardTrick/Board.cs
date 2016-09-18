using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardTrick
{
    class Board
    {
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
    }
}
