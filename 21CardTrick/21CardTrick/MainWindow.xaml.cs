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
            ((Dealer)DataContext).player.indicateCouloumn(0);
            updateGUIBoard();
            //System.Windows.MessageBox.Show(((Dealer)DataContext).card1.ToStringAlt());
        }

        private void btnCol2_Click(object sender, RoutedEventArgs e)
        {
            ((Dealer)DataContext).player.indicateCouloumn(1);
            updateGUIBoard();
        }

        private void btnCol3_Click(object sender, RoutedEventArgs e)
        {
            ((Dealer)DataContext).player.indicateCouloumn(2);
            updateGUIBoard();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            ((Dealer)DataContext).Deal();
            updateGUIBoard();
            
            
        }
        private void updateGUIBoard()
        {
            //Column 1
            tbcolumn1Card1.Text = ((Dealer)DataContext).cards21.ElementAt(0).ToStringAlt();
            tbcolumn1Card2.Text = ((Dealer)DataContext).cards21.ElementAt(3).ToStringAlt();
            tbcolumn1Card3.Text = ((Dealer)DataContext).cards21.ElementAt(6).ToStringAlt();
            tbcolumn1Card4.Text = ((Dealer)DataContext).cards21.ElementAt(9).ToStringAlt();
            tbcolumn1Card5.Text = ((Dealer)DataContext).cards21.ElementAt(12).ToStringAlt();
            tbcolumn1Card6.Text = ((Dealer)DataContext).cards21.ElementAt(15).ToStringAlt();
            tbcolumn1Card7.Text = ((Dealer)DataContext).cards21.ElementAt(18).ToStringAlt();

            //Column 2
            tbcolumn2Card1.Text = ((Dealer)DataContext).cards21.ElementAt(1).ToStringAlt();
            tbcolumn2Card2.Text = ((Dealer)DataContext).cards21.ElementAt(4).ToStringAlt();
            tbcolumn2Card3.Text = ((Dealer)DataContext).cards21.ElementAt(7).ToStringAlt();
            tbcolumn2Card4.Text = ((Dealer)DataContext).cards21.ElementAt(10).ToStringAlt();
            tbcolumn2Card5.Text = ((Dealer)DataContext).cards21.ElementAt(13).ToStringAlt();
            tbcolumn2Card6.Text = ((Dealer)DataContext).cards21.ElementAt(16).ToStringAlt();
            tbcolumn2Card7.Text = ((Dealer)DataContext).cards21.ElementAt(19).ToStringAlt();

            //Column 1
            tbcolumn3Card1.Text = ((Dealer)DataContext).cards21.ElementAt(2).ToStringAlt();
            tbcolumn3Card2.Text = ((Dealer)DataContext).cards21.ElementAt(5).ToStringAlt();
            tbcolumn3Card3.Text = ((Dealer)DataContext).cards21.ElementAt(8).ToStringAlt();
            tbcolumn3Card4.Text = ((Dealer)DataContext).cards21.ElementAt(11).ToStringAlt();
            tbcolumn3Card5.Text = ((Dealer)DataContext).cards21.ElementAt(14).ToStringAlt();
            tbcolumn3Card6.Text = ((Dealer)DataContext).cards21.ElementAt(17).ToStringAlt();
            tbcolumn3Card7.Text = ((Dealer)DataContext).cards21.ElementAt(20).ToStringAlt();
        }
    }
}
