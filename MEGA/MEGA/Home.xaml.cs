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
using ClassLibrary1;

namespace MEGA
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        
        public Home()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BattleWindow battle = new BattleWindow("Warrior", characterName.Text);
            this.NavigationService.Navigate(battle);
            
        }

        private void Thief_Click(object sender, RoutedEventArgs e)
        {
            BattleWindow battle = new BattleWindow("Thief", characterName.Text);
            this.NavigationService.Navigate(battle);
        }

        private void Mage_Click(object sender, RoutedEventArgs e)
        {
            BattleWindow battle = new BattleWindow("Mage", characterName.Text);
            this.NavigationService.Navigate(battle);
        }
    }
}
