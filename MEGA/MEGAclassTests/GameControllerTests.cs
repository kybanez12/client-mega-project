using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class GameControllerTests
    {
        [TestMethod()]
        public void CalculateSpecialSuccessTest()  
        {
            //arrange
            GameController gControl = new GameController();
            gControl.ChooseClass("Warrior");


            //act
            var vResults = gControl.CalculateSpecial();

            //assert
            Assert.AreEqual(30, vResults);
        }
                                                                        //having two tests is my solution for testing for random outcomes
        [TestMethod()]
        public void CalculateSpecialFailTest()
        {
            //arrange
            GameController gControl = new GameController();
            gControl.ChooseClass("Warrior");


            //act
            var vResults = gControl.CalculateSpecial();

            //assert
            Assert.AreEqual(0, vResults);
        }

        [TestMethod()]
        public void AttackTest()
        {
            Assert.Fail();
        }

        

        [TestMethod()]
        public void ChooseClassTest()
        {
            //Arrange
            GameController vTest = new GameController();

            //act
            vTest.ChooseClass("Mage");

            //assert
            Assert.AreEqual("name", vTest.player.characterName);
            Assert.AreEqual(10, vTest.player.baseDamage);
            Assert.AreEqual(50, vTest.player.currentHealthPoints);
            Assert.AreEqual(50, vTest.player.maxHealthPoints);
        }

        [TestMethod()]
        public void MissTest()
        {
            //arrange
            GameController gControl = new GameController();
            gControl.ChooseClass("Thief");
            gControl.enemy = new NonPlayerCharacter();
            gControl.enemy.currentHealthPoints = 30;

            //act
            gControl.Miss();

            //assert
            Assert.AreEqual(30, gControl.enemy.currentHealthPoints);
        }

        [TestMethod()]
        public void NormalAttackTest()
        {
            //arrange
            GameController vControl = new GameController();
            vControl.ChooseClass("Mage");
            vControl.enemy = new NonPlayerCharacter();
            vControl.enemy.baseDamage = 15;
            vControl.enemy.currentHealthPoints = 30;

            //act
            vControl.NormalAttack();

            //assert
            Assert.AreEqual(20, vControl.enemy.currentHealthPoints);
            Assert.AreEqual(35, vControl.player.currentHealthPoints);

        }

        [TestMethod()]
        public void SpecialAttackTest()
        {
            GameController vControl = new GameController();
            vControl.ChooseClass("Warrior");
            vControl.enemy = new NonPlayerCharacter();
            vControl.enemy.baseDamage = 15;
            vControl.enemy.currentHealthPoints = 30;

            //act
            vControl.SpecialAttack();

            //assert
            Assert.AreEqual(30, vControl.enemy.currentHealthPoints);
        }

        [TestMethod()]
        public void StartBattleTest()
        {
            Assert.Fail();
        }
    }
}