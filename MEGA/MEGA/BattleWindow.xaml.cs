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
using ClassLibrary1;

namespace MEGA
{
    /// <summary>
    /// Interaction logic for BattleWindow.xaml
    /// </summary>
    public partial class BattleWindow : Page
    {
        GameController gControl;
        public BattleWindow(string chosenClass, string playerName)
        {
            gControl = new GameController();
            gControl.ChooseClass(chosenClass);
            gControl.player.characterName = playerName;
            InitializeComponent();

            CharacterName.Text = gControl.player.characterName;
            Hp.Text = "Hp: " + gControl.player.currentHealthPoints;
            Damage.Text = "Damage: " + gControl.player.baseDamage;
        }

        private void NormalAttackButton_Click(object sender, RoutedEventArgs e)
        {
            gControl.NormalAttack();
            Hp.Text = "Hp: " + gControl.player.currentHealthPoints;

        }
    }
}
