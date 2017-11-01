using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1.Units_and_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Units_and_Classes.Tests
{
    [TestClass()]
    public class PlayerCharacterTests
    {
        [TestMethod()]
        public void PlayerCharacterTest()
        {
            // Arrange
            PlayerCharacter vTest = new PlayerCharacter("Ky", "Developer", 10, 50);

            //Act

            //Assert
            Assert.AreEqual("Ky", vTest.characterName);
            Assert.AreEqual(10, vTest.baseDamage);
            Assert.AreEqual(50, vTest.currentHealthPoints);
            Assert.AreEqual(50, vTest.maxHealthPoints);
        }

        [TestMethod()]
        public void PlayerGetSpecialAttackTest()
        {
            //Arrange
            PlayerCharacter vTest = new PlayerCharacter("Kristian", "Mage", 10, 50);

            //act
            try
            {
                vTest.GetSpecialAttack(); 
                Assert.Fail();
            }
            catch (Exception)
            {
                //Assert
            }
        }
    }
}