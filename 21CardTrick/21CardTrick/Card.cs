using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace _21CardTrick
{
    class Card : INotifyPropertyChanged
    {
        public Card() { }

        public Card(int value, int suit)
        {
            _Value = value;

            if(suit == 0){
                Suit = CardSuit.Club;
            }
            else if (suit == 1){
                Suit = CardSuit.Diamond;
	        }
            else if (suit == 2){
                Suit = CardSuit.Heart;
            }
            else if (suit == 3){
                Suit = CardSuit.Spade;
            }
        }
        #region Properties
        /// <summary>
        /// Card Suit enumeration
        /// </summary>
        public enum CardSuit
        {
            Spade,
            Club,
            Heart,
            Diamond
        }

        /// <summary>
        /// Card Suit Property
        /// </summary>
        public CardSuit Suit { get; set; }

        /// <summary>
        /// Value Property
        /// </summary>
        private int _Value;
        public int Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
                OnPropertyChanged();
                OnPropertyChanged("FaceValue");
            }
        }

        /// <summary>
        /// FaceValue. Face values for determining Face Cards
        /// </summary>
        public string FaceValue
        {
            get
            {
                switch (Value)
                {
                    case 1:
                        return "A";
                    case 11:
                        return "J";
                    case 12:
                        return "Q";
                    case 13:
                        return "K";
                    default:
                        return Value.ToString();
                }

            }
        }

        /// <summary>
        /// _Visible Property
        /// </summary>
        private bool _Visible;
        public bool Visible
        {
            get
            {
                return _Visible;
            }
            set
            {
                _Visible = value;
                OnPropertyChanged();
            }
        }
        #endregion // Properties



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
