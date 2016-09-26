using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardTrick 
{
    class Column : INotifyPropertyChanged
    {
        //members
        private int id;
        private int index;
        private ObservableCollection<Card> _cards;
        public ObservableCollection<Card> _Cards
        {
            get{
                return _cards;
            }
            set{
                _cards = value;
                OnPropertyChanged();
            }
        }
        public Card[] cards { get; set; }

        //constructors
        public Column()
        {
            id = 0;
            index = 0;
            cards = new Card[7];
            _cards = new ObservableCollection<Card>();
            OnPropertyChanged();
        }

        public Column(int id)
        {
            this.id = id;
            index = 0;
            cards = new Card[7];
            _cards = new ObservableCollection<Card>();
            OnPropertyChanged();
        }

        //methods
        public void addCard(Card card)
        {
            cards[index++] = card;
            _cards.Add(card);
        }

        public int getId()
        {
            return id;
        }

//<<<<<<< HEAD
        //Getters and setters
        public Card getCard(int i)
        {
            return _cards[i];
        }
        public void setCard(int i, Card c)
        {
            //Shallow copy?
            cards[i] = c;
        }
        

        public Card[] getCards()
        {
            return cards;
        }


        public void clearColumn()
        {
            while (_cards.Count > 0)
            {
                _cards.RemoveAt(0);
            }
        }

        public void resetIndex()
        {
            index = 0;
        }

        #region INotifyPropertyChanged Members

        /// <summary>
        /// Property Changed Event Handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
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
