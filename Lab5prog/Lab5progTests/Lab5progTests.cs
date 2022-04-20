using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab5prog;

namespace Lab5progTests
{
    [TestClass]
    public class Lab5progTests
    {
        HRD company = HRD.GetInstance();
        [TestMethod]
        public void TestMethod1()
        {
            company.AddWorker("Anton");

            int expected = 0;
            int actual = company.SearchForPayment("Anton");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod2()
        {
            company.AddJobForWorker("Anton", "job", 10);

            int expected = 10;
            int actual = company.SearchForPayment("Anton");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod3()
        {
            company.AddWorker("Kirill");
            company.AddJobForWorker("Kirill", "wash", 100);
            company.AddJobForWorker("Kirill", "cleaning", 999);

            int expected = 1099;
            int actual = company.SearchForPayment("Kirill");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod4()
        {
            company.AddWorker("Vadim");
            company.AddJobForWorker("Vadim", "play", 1);
            company.AddJobForWorker("Vadim", "fight", 1);

            int expected = 2;
            int actual = company.SearchForPayment("Vadim");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod5()
        {
            string expected = "play fight ";
            string actual = company.SearchForTitles("Vadim");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod6()
        {
            string expected = "wash cleaning ";
            string actual = company.SearchForTitles("Kirill");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod7()
        {
            int expected = 1111;
            int actual = company.TotalPayment();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod8()
        {
            company.AddJobForWorker("Vadim", "secretary", 5);

            int expected = 1116;
            int actual = company.TotalPayment();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod9()
        {
            string expected = "job wash cleaning play fight secretary ";
            string actual = company.TotalTitles();

            Assert.AreEqual(expected, actual);
        }
    }
}
