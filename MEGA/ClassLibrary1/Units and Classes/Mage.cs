using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClassLibrary1
{
    public class Mage : PlayerCharacter
    {
        public Mage(string cName, string pClass, int bDamage, int maxHp) : base(cName, pClass, bDamage, maxHp)
        {
            characterName = cName;
            baseDamage = bDamage;
            currentHealthPoints = maxHp;
            maxHealthPoints = maxHp;

            normalAttack = new NormalAttack();
            specialAttack = new Fireball();
        }

        public override int GetSpecialAttack()
        {
            

            var vRandom = new Random();

            if (vRandom.Next(0, 2) == 1)
            {
                return baseDamage * 4;
            }
            else
                currentHealthPoints -= baseDamage;
                return 0;
            
        
        }

    }
}