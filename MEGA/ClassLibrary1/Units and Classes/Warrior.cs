using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Warrior : PlayerCharacter
    {
        public Warrior(string cName, string pClass, int bDamage, int maxHp) : base(cName, pClass, bDamage, maxHp)
        {
            characterName = cName;
            baseDamage = bDamage;
            currentHealthPoints = maxHp;
            maxHealthPoints = maxHp;

            normalAttack = new NormalAttack();
            specialAttack = new Berserk();
        }

        public override int GetSpecialAttack()
        {
            var vRandom = new Random();

            if (vRandom.Next(0, 3) == 2)
            {
                return baseDamage * 3;
            }
            else
                return 0;
        }
    }
}
