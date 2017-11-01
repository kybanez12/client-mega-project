using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1.Units_and_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class WarriorTests
    {
        [TestMethod()]
        public void WarriorGetSpecialAttackSuccessTest()
        {
            //arrange
            Warrior vTest = new Warrior("TanKy", "Warrior", 10, 50);  

            //act
            int vResults = vTest.GetSpecialAttack();

            //assert
            Assert.AreEqual(30, vResults);

        }
                                                                //these two tests is my solution for testing for random outcomes
        [TestMethod()]
        public void WarriorGetSpecialAttackFailTest()
        {
            //arrange
            Warrior vTest = new Warrior("TanKy", "Warrior", 10, 50);  

            //act
            int vResults = vTest.GetSpecialAttack();

            //assert
            Assert.AreEqual(0, vResults);
        }
    }
}

namespace ClassLibrary1.Units_and_Classes.Tests
{
    [TestClass()]
    public class WarriorTests
    {
        [TestMethod()]
        public void WarriorTest()
        {
            //arrange
            Warrior vTest = new Warrior("TanKy", "Warrior", 10, 50);

            //act

            //assert
            Assert.AreEqual("TanKy", vTest.characterName);
            Assert.AreEqual(10, vTest.baseDamage);
            Assert.AreEqual(50, vTest.currentHealthPoints);
            Assert.AreEqual(50, vTest.maxHealthPoints);
        }
    }
}