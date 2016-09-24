using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _21CardTrick
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCol1_Click(object sender, RoutedEventArgs e)
        {
            ((Dealer)DataContext).pickupCards(0);
            //((Dealer)DataContext).player.indicateCouloumn(0);
            updateGUIBoard();
            testReveal();
        }

        private void btnCol2_Click(object sender, RoutedEventArgs e)
        {
            ((Dealer)DataContext).pickupCards(1);
            //((Dealer)DataContext).player.indicateCouloumn(1);
            updateGUIBoard();
            testReveal();
        }

        private void btnCol3_Click(object sender, RoutedEventArgs e)
        {
            ((Dealer)DataContext).pickupCards(2);
            //((Dealer)DataContext).player.indicateCouloumn(2);
            updateGUIBoard();
            testReveal();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            
            ((Dealer)DataContext).Deal();
            updateGUIBoard();
            grdWelcome.Visibility = System.Windows.Visibility.Hidden;
            grdTrickView.Visibility = System.Windows.Visibility.Visible;
            
        }
        private void updateGUIBoard()
        {
            //Column 1
            tbcolumn1Card1.Text = ((Dealer)DataContext).cardBoard.columns[0].getCard(0).ToStringAlt();
            tbcolumn1Card2.Text = ((Dealer)DataContext).cardBoard.columns[0].getCard(1).ToStringAlt();
            tbcolumn1Card3.Text = ((Dealer)DataContext).cardBoard.columns[0].getCard(2).ToStringAlt();
            tbcolumn1Card4.Text = ((Dealer)DataContext).cardBoard.columns[0].getCard(3).ToStringAlt();
            tbcolumn1Card5.Text = ((Dealer)DataContext).cardBoard.columns[0].getCard(4).ToStringAlt();
            tbcolumn1Card6.Text = ((Dealer)DataContext).cardBoard.columns[0].getCard(5).ToStringAlt();
            tbcolumn1Card7.Text = ((Dealer)DataContext).cardBoard.columns[0].getCard(6).ToStringAlt();
            
            //Column 2
            tbcolumn2Card1.Text = ((Dealer)DataContext).cardBoard.columns[1].getCard(0).ToStringAlt();
            tbcolumn2Card2.Text = ((Dealer)DataContext).cardBoard.columns[1].getCard(1).ToStringAlt();
            tbcolumn2Card3.Text = ((Dealer)DataContext).cardBoard.columns[1].getCard(2).ToStringAlt();
            tbcolumn2Card4.Text = ((Dealer)DataContext).cardBoard.columns[1].getCard(3).ToStringAlt();
            tbcolumn2Card5.Text = ((Dealer)DataContext).cardBoard.columns[1].getCard(4).ToStringAlt();
            tbcolumn2Card6.Text = ((Dealer)DataContext).cardBoard.columns[1].getCard(5).ToStringAlt();
            tbcolumn2Card7.Text = ((Dealer)DataContext).cardBoard.columns[1].getCard(6).ToStringAlt();

            //Column 1
            tbcolumn3Card1.Text = ((Dealer)DataContext).cardBoard.columns[2].getCard(0).ToStringAlt();
            tbcolumn3Card2.Text = ((Dealer)DataContext).cardBoard.columns[2].getCard(1).ToStringAlt();
            tbcolumn3Card3.Text = ((Dealer)DataContext).cardBoard.columns[2].getCard(2).ToStringAlt();
            tbcolumn3Card4.Text = ((Dealer)DataContext).cardBoard.columns[2].getCard(3).ToStringAlt();
            tbcolumn3Card5.Text = ((Dealer)DataContext).cardBoard.columns[2].getCard(4).ToStringAlt();
            tbcolumn3Card6.Text = ((Dealer)DataContext).cardBoard.columns[2].getCard(5).ToStringAlt();
            tbcolumn3Card7.Text = ((Dealer)DataContext).cardBoard.columns[2].getCard(6).ToStringAlt();
        }

        //Tests to see if the conditions to reveal the card have been met
        private void testReveal()
        {
            if (((Dealer)DataContext).DealNum == 4)
            {
                revealScreen();
            }
        }
        
        private void revealScreen()
        {
            grdTrickView.Visibility = System.Windows.Visibility.Hidden;
            grdReveal.Visibility = System.Windows.Visibility.Visible;

            tbRevealedCard.Text = ((Dealer)DataContext).revealCard().ToStringAlt();
        }
    }
}
