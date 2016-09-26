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
    class Board : INotifyPropertyChanged
    {
//<<<<<<< HEAD
//=======
        //members
        private ObservableCollection<Column> _cols;
        public ObservableCollection<Column> Cols
        {
            get
            {
                return _cols;
            }
            set
            {
                _cols = value;
                OnPropertyChanged();
            }
        }
        

        //constructors
        public Board()
        {
            _cols = new ObservableCollection<Column>();
            for (int i = 0; i < 3; i++)
            {
                _cols.Add(new Column(i));
            }
            
            OnPropertyChanged();
        }

        //methods
        public void addToColumn(int id, Card card)
        {
            _cols[id].addCard(card);
        }

        public Card[] pickupColumn(int colId)
        {
            return _cols[colId].getCards();
        }

        public void reset()
        {
            for (int i = 0; i < 3; i++)
            {
                _cols[i].resetIndex();
            }
        }

        public void clearColumns()
        {
            for (int i = 0; i < _cols.Count; i++)
            {
                _cols[i].clearColumn();
            }
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
