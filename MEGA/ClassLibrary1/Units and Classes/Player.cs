using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class PlayerCharacter : Character 
    {
        public string characterName { get; set; } 
        public NormalAttack normalAttack { get; set; }
        public SpecialAttack specialAttack { get; set; }

        public PlayerCharacter(string cName, string pClass, int bDamage, int maxHp)
        {
            characterName = cName;
            baseDamage = bDamage;
            currentHealthPoints = maxHp;
            maxHealthPoints = maxHp;
        }

        public virtual int GetSpecialAttack()
        {
            throw new NotImplementedException();
        }
    }
}
