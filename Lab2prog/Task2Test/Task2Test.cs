using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task2;

namespace Task2Test
{
    [TestClass]
    public class Task2Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 1;
            double expected = 1;

            Task2cl method = new Task2cl();
            double actual = method.mod(x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            double x = -1;
            double expected = 1;

            Task2cl method = new Task2cl();
            double actual = method.mod(x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            double x = 0;
            double expected = 0;

            Task2cl method = new Task2cl();
            double actual = method.mod(x);

            Assert.AreEqual(expected, actual);
        }
    }
}
