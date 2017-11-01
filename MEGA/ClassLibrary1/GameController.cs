using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class GameController
    {
        public NonPlayerCharacter enemy { get; set; }
        public PlayerCharacter player { get; set; }

       
        public void Attack()
        {
            //not sure what to do with this, not used in the sequence diagram
            throw new Exception();
        }

        public void CheckBothPlayersHealth()    // checks if a characters health reaches 0
        {
            if (enemy.currentHealthPoints <= 0)
            {
                if (MessageBox.Show("You prevail", "Congrats!", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
            }

            else if (player.currentHealthPoints <= 0)
            {
                if (MessageBox.Show("You were slain.", "Game over!", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
            }
        }

        public int ChooseClass(string choosingClass)    // sets the player class depending on user's choice
        {
            if (choosingClass == "Mage")
            {
                player = new Mage("name", choosingClass, 10, 50);
                return 0;
            }
            else if (choosingClass == "Warrior")
            {
                player = new Warrior("name", choosingClass, 10, 50);
                return 0;
            }
            else if (choosingClass == "Thief")
            {
                player = new Thief("name", choosingClass, 10, 50);
                return 0;
            }
            else
                return 0;
        }

        public int CalculateSpecial()  //calculate and return the special damage
        {
            int specialDamage = player.GetSpecialAttack();   
            return specialDamage;
        }
        public void Miss()
        {
            enemy.currentHealthPoints = enemy.TakeDamage(0);   // enemy takes no damage
        }

        public void NormalAttack()   // executes normal attack sequence
        {
            enemy.currentHealthPoints = enemy.TakeDamage(player.GetDamage(0));

            CheckBothPlayersHealth();

            player.currentHealthPoints = player.TakeDamage(enemy.GetDamage(0));

            CheckBothPlayersHealth();

        }

        public void SpecialAttack()  //executes special attack sequence 
        {
            int damageToBeDealt = CalculateSpecial();

            if (damageToBeDealt > 10)
            {
                enemy.currentHealthPoints = enemy.TakeDamage(damageToBeDealt);
                CheckBothPlayersHealth();
            }
            else
                Miss();
            
            player.currentHealthPoints = player.TakeDamage(enemy.GetDamage(0));
            CheckBothPlayersHealth();
        }

        public void StartBattle()
        {
            //this creates a random npc
            throw new Exception();

        }


    }
}
