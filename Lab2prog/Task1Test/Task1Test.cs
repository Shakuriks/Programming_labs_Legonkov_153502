using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task1;

namespace Task1Test
{
    [TestClass]
    public class Task1Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 10;
            double b = 10;
            double c = 10;
            bool expected = true;

            Task1cl method = new Task1cl();
            bool actual = method.isEquilateral(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            double a = 10;
            double b = 10;
            double c = 20;
            bool expected = false;

            Task1cl method = new Task1cl();
            bool actual = method.isEquilateral(a, b, c);

            Assert.AreEqual(expected, actual);
        }
    }
}
