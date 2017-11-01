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
    public class ThiefTests
    {
        [TestMethod()]
        public void GetSpecialAttackThiefSuccessTest()     
        {
            //arrange
            Thief vTest = new Thief("SneaKy", "Thief", 10, 50);

            //act
            int vResults = vTest.GetSpecialAttack();

            //assert
            Assert.AreEqual(20, vResults);
        }
                                                                                //these two tests is my solution for testing for random outcomes
        [TestMethod()]
        public void GetSpecialAttackThiefFailTest()
        {
            //arrange
            Thief vTest = new Thief("SneaKy", "Thief", 10, 50);

            //act
            int vResults = vTest.GetSpecialAttack();

            //assert
            Assert.AreEqual(5, vResults);
        }
    }
}

namespace ClassLibrary1.Units_and_Classes.Tests
{
    [TestClass()]
    public class ThiefTests
    {
        [TestMethod()]
        public void ThiefTest()
        {
            //arrange
            Thief vTest = new Thief("SneaKy", "Thief", 10, 50);

            //act

            //assert
            Assert.AreEqual("SneaKy", vTest.characterName);
            Assert.AreEqual(10, vTest.baseDamage);
            Assert.AreEqual(50, vTest.currentHealthPoints);
            Assert.AreEqual(50, vTest.maxHealthPoints);
            

        }
    }
}