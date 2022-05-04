using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab6prog;

namespace Lab6progTests
{
    [TestClass]
    public class Lab6progTetsts
    {
        [TestMethod]
        public void TestMethod1()
        {
            Unit first = new Archer(2, 7, 8);
            Unit second = new Swordman(2, 10, 1);
            first.ToAttack(second);

            int expected = 8;
            int actual = second.Health;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Unit first = new Archer(2, 7, 8);
            Unit second = new Swordman(2, 10, 1);
            second.ToAttack(first);

            int expected = 7;
            int actual = first.Health;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Unit first = new Archer(2, 7, 8);
            Unit second = new Rider(2, 10, 3);
            second.ToAttack(first);

            int expected = 5;
            int actual = first.Health;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Unit first = new Archer(2, 7, 8);
            Unit second = new Rider(2, 10, 3);
            second.ToAttack(first);

            int expected = 9;
            int actual = first.Position;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Unit first = new Archer(2, 7, 8);
            first.Move(1);
            int expected = 9;
            int actual = first.Position;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Unit first = new Archer(2, 7, 8);
            first.Move(-1);
            int expected = 7;
            int actual = first.Position;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod7()
        {
            Unit first = new Rider(3, 10, 8);
            first.Move(-1);
            int expected = 6;
            int actual = first.Position;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod8()
        {
            Unit first = new Rider(3, 10, 8);
            first.Move(1);
            int expected = 10;
            int actual = first.Position;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod9()
        {
            Unit first = new Rider(3, 10, 8);
            string expected = "10";
            string actual = first.ShowHealth();

            Assert.AreEqual(expected, actual);
        }
    }
}
