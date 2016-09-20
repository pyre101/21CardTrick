﻿using System;
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
            ((Dealer)DataContext).Deal();
        }

        private void btnCol1_Click(object sender, RoutedEventArgs e)
        {
            ((Dealer)DataContext).player.indicateCouloumn(0);
            System.Windows.MessageBox.Show(((Dealer)DataContext).card1.ToStringAlt());
        }

        private void btnCol2_Click(object sender, RoutedEventArgs e)
        {
            ((Dealer)DataContext).player.indicateCouloumn(1);
        }

        private void btnCol3_Click(object sender, RoutedEventArgs e)
        {
            ((Dealer)DataContext).player.indicateCouloumn(2);
        }
    }
}
