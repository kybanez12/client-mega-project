using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class MageTests
    {
        [TestMethod()]
        public void MageGetSpecialAttackFailTest()  
        {
            //arrange
            Mage vTest = new Mage("ThinKy", "Mage", 10, 50);

            //act
            int vResults = vTest.GetSpecialAttack();                                //these two tests is my solution for testing for random outcomes

            //assert
            Assert.AreEqual(40, vTest.currentHealthPoints);
            Assert.AreEqual(0, vResults);
        }

        [TestMethod()]
        public void MageGetSpecialAttackSuccessTest()
        {
            //arrange
            Mage vTest = new Mage("ThinKy", "Mage", 10, 50);

            //act
            int vResults = vTest.GetSpecialAttack();

            //assert
            Assert.AreEqual(50, vTest.currentHealthPoints);
            Assert.AreEqual(30, vResults);
        }
    }
}

namespace ClassLibrary1.Units_and_Classes.Tests
{
    [TestClass()]
    public class MageTests
    {
        [TestMethod()]
        public void MageTest()
        {
            //arrange
            Mage vTest = new Mage("ThinKy", "Mage", 10, 50);

            //act

            //assert
            Assert.AreEqual("ThinKy", vTest.characterName);
            Assert.AreEqual(10, vTest.baseDamage);
            Assert.AreEqual(50, vTest.currentHealthPoints);
            Assert.AreEqual(50, vTest.maxHealthPoints);
        }
    }
}