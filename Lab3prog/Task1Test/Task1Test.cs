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
            double x = 10;
            int n = 2;
            double expected = 50;

            MyMath method = new MyMath();
            double actual = method.f(n, x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            double x = 4;
            int n = 4;
            double expected = 64;

            MyMath method = new MyMath();
            double actual = method.f(n, x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string date = "17.03.2022";
            string expected = "Четверг";

            DateServise method = new DateServise();
            string actual = method.GetDay(date);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string date = "20.03.2022";
            string expected = "Воскресенье";

            DateServise method = new DateServise();
            string actual = method.GetDay(date);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string date = "20.03.2022";
            string expected = "Воскресенье";

            DateServise method = new DateServise();
            string actual = method.GetDay(date);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod6()
        {
            int day = 20;
            int month = 3;
            int year = 2022;
            int expected = 3;

            DateServise method = new DateServise();
            int actual = method.GetDaysSpan(day, month, year);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod7()
        {
            int day = 17;
            int month = 3;
            int year = 2023;
            int expected = 365;

            DateServise method = new DateServise();
            int actual = method.GetDaysSpan(day, month, year);

            Assert.AreEqual(expected, actual);
        }
    }
}
