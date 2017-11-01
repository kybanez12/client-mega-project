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
    public class CharacterTests
    {
        [TestMethod()]
        public void GetDamageTest()
        {
            // Arrange
            Character vTest = new Character();
            vTest.baseDamage = 15;

            //Act
            int vResults = vTest.GetDamage(0);

            //Assert
            Assert.AreEqual(15, vTest.baseDamage);
            
        }

        [TestMethod()]
        public void TakeDamageTest()
        {
            //arrange
            Character vTest = new Character();
            Character cTest = new Character();

            //act
            vTest.currentHealthPoints = 50;
            vTest.currentHealthPoints = vTest.TakeDamage(15);

            //Assert
            Assert.AreEqual(35, vTest.currentHealthPoints);


        }
    }
}