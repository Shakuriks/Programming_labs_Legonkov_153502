using Lab1Prog.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab1progTests
{
    [TestClass]
    public class Lab1progTests
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
            company.AddJob("job", 10);
            company.AddJobForWorker("Anton", "job");

            int expected = 10;
            int actual = company.SearchForPayment("Anton");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod3()
        {
            company.AddWorker("Kirill");
            company.AddJob("wash", 100);
            company.AddJob("cleaning", 10999);
            company.AddJobForWorker("Kirill", "wash");
            company.AddJobForWorker("Kirill", "cleaning");

            int expected = 11099;
            int actual = company.SearchForPayment("Kirill");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod4()
        {
            company.AddWorker("Vadim");
            company.AddJob("play", 1);
            company.AddJob("fight", 1);
            company.AddJobForWorker("Vadim", "play");
            company.AddJobForWorker("Vadim", "fight");

            int expected = 2;
            int actual = company.SearchForPayment("Vadim");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod5()
        {
            string expected = "fight; play; ";
            string actual = company.SearchForTitles("Vadim");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod6()
        {
            string expected = "cleaning; wash; ";
            string actual = company.SearchForTitles("Kirill");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod7()
        {
            string expected = "Kirill";
            string actual = company.MaxPaymentWorker();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod8()
        {
            int expected = 11111;
            int actual = company.TotalPayment();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod9()
        {
            int expected = 1;
            int actual = company.PaymentMore(11000);

            Assert.AreEqual(expected, actual);
        }
    }
}
