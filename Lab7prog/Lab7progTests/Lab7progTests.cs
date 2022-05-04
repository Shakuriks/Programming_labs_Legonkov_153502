using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab7prog;

namespace Lab7progTests
{
    [TestClass]
    public class Lab7progTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Vector vector1 = new Vector(3, 3, 3);
            Vector vector2 = new Vector(1, 1, 1);
            Vector vector3 = new Vector(4, 4, 4);
            Vector sumv1v2 = vector1 + vector2;

            bool expected = true;
            bool actual = vector3 == sumv1v2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Vector vector1 = new Vector(3, 3, 3);
            Vector vector2 = new Vector(2, 2, 2);
            Vector vector3 = new Vector(4, 4, 4);
            Vector sumv1v2 = vector1 - vector2;

            bool expected = false;
            bool actual = vector3 == sumv1v2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Vector vector1 = new Vector(3, 3, 3);
            Vector vector2 = new Vector(2, 2, 2);
            Vector vector3 = new Vector(4, 4, 4);
            Vector sumv1v2 = vector1 - vector2;

            bool expected = true;
            bool actual = vector3 != sumv1v2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Vector vector1 = new Vector(3, 3, 3);
            Vector vector2 = new Vector(1, 1, 1);
            Vector vector3 = new Vector(4, 4, 4);
            Vector sumv1v2 = vector1 + vector2;

            bool expected = false;
            bool actual = vector3 != sumv1v2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Vector vector1 = new Vector(2, 2, 2);
            Vector vector2 = new Vector(1, 1, 1);
            vector2++;

            bool expected = true;
            bool actual = vector1 == vector2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Vector vector1 = new Vector(2, 2, 2);
            Vector vector2 = new Vector(1, 1, 1);
            vector1--;

            bool expected = true;
            bool actual = vector1 == vector2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod7()
        {
            Vector vector1 = new Vector(3, 3, 3);
            Vector vector2 = new Vector(2, 2, 2);
            Vector vector3 = new Vector(6, 6, 6);
            Vector prodv1v2 = vector1 * vector2;

            bool expected = true;
            bool actual = vector3 == prodv1v2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod8()
        {
            Vector vector1 = new Vector(3, 3, 3);
            Vector vector2 = new Vector(2, 2, 2);
            Vector vector3 = new Vector(4, 4, 4);
            Vector prodv1v2 = vector1 - vector2;

            bool expected = false;
            bool actual = vector3 == prodv1v2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod9()
        {
            Vector vector1 = new Vector(3, 3, 3);
            Vector vector3 = new Vector(6, 6, 6);
            Vector prodv1v2 = vector1 * 2;

            bool expected = true;
            bool actual = vector3 == prodv1v2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod10()
        {
            Vector vector1 = new Vector(3, 3, 3);
            Vector vector3 = new Vector(6, 6, 6);
            Vector prodv1v2 = vector1 * 3;

            bool expected = false;
            bool actual = vector3 == prodv1v2;

            Assert.AreEqual(expected, actual);
        }

        public void TestMethod11()
        {
            Vector vector1 = new Vector(3, 3, 3);
            Vector vector3 = new Vector(6, 6, 6);
            Vector prodv1v2 = vector3 / 2;

            bool expected = true;
            bool actual = vector3 == prodv1v2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod12()
        {
            Vector vector1 = new Vector(3, 3, 3);
            Vector vector3 = new Vector(6, 6, 6);
            Vector prodv1v2 = vector1 / 3;

            bool expected = false;
            bool actual = vector3 == prodv1v2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod13()
        {
            Vector vector1 = new Vector(3, 3, 3);

            bool actual;

            if (vector1)
                actual = true;
            else
                actual = false;

            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod14()
        {
            Vector vector1 = new Vector(0, 0, 0);

            bool actual;

            if (vector1)
                actual = true;
            else
                actual = false;

            bool expected = false;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod15()
        {
            Vector vector1 = new Vector(3, 3, 3);

            double expected = Math.Sqrt(27);
            double actual = ((double)vector1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod16()
        {
            Vector vector1 = new Vector(3, 3, 3);

            string expected = "a = 3, b = 3, c = 3";
            string actual = vector1.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
