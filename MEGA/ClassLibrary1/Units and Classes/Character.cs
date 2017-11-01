using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Character
    {
        public int baseDamage { get; set; }
        public int currentHealthPoints { get; set; }
        public int maxHealthPoints { get; set; }



        public int GetDamage(int bDamage)
        {
            return baseDamage;
        }


        public int TakeDamage(int damage)
        {
            int newHp = currentHealthPoints - damage;
            return newHp;
        }

    }
}
