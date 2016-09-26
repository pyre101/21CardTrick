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
            testReveal();
        }

        private void btnCol2_Click(object sender, RoutedEventArgs e)
        {
            ((Dealer)DataContext).pickupCards(1);
            testReveal();
        }

        private void btnCol3_Click(object sender, RoutedEventArgs e)
        {
            ((Dealer)DataContext).pickupCards(2);
            testReveal();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            
            ((Dealer)DataContext).Deal();
            grdWelcome.Visibility = System.Windows.Visibility.Hidden;
            grdTrickView.Visibility = System.Windows.Visibility.Visible;
            
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
