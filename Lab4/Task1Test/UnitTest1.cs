using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task;
using System;

namespace Task1Test
{

    [TestClass]
    public class UnitTest1
    {
        HRD company = HRD.GetInstance();

        [TestMethod]
        public void TestMethod1()
        {
            company.HoursPerMonth = 20;
            ProdRate[] workers = new ProdRate[5];
            for (int i = 0; i < workers.Length; i++)
            {
                ProdRate prodRate = new ProdRate();
                workers[i] = prodRate;
                workers[i].PayPerHour = 2;
            }
            double expected = 96;

            double actual = HRD.GetGeneralTax(workers);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            company.HoursPerMonth = 10;
            ProdRate[] workers = new ProdRate[5];
            for (int i = 0; i < workers.Length; i++)
            {
                ProdRate prodRate = new ProdRate();
                workers[i] = prodRate;
                workers[i].PayPerHour = 2;
            }
            double expected = 48;

            double actual = HRD.GetGeneralTax(workers);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            company.HoursPerMonth = 5;
            ProdRate[] workers = new ProdRate[5];
            for (int i = 0; i < workers.Length; i++)
            {
                ProdRate prodRate = new ProdRate();
                workers[i] = prodRate;
                workers[i].PayPerHour = 2;
            }
            double expected = 24;

            double actual = HRD.GetGeneralTax(workers);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            company.HoursPerMonth = 40;
            ProdRate[] workers = new ProdRate[5];
            for (int i = 0; i < workers.Length; i++)
            {
                ProdRate prodRate = new ProdRate();
                workers[i] = prodRate;
                workers[i].PayPerHour = 4;
            }
            double expected = 384;

            double actual = HRD.GetGeneralTax(workers);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            company.HoursPerMonth = 100;
            ProdRate[] workers = new ProdRate[5];
            for (int i = 0; i < workers.Length; i++)
            {
                ProdRate prodRate = new ProdRate();
                workers[i] = prodRate;
                workers[i].PayPerHour = 4;
            }
            double expected = 960;

            double actual = HRD.GetGeneralTax(workers);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod6()
        {
            company.HoursPerMonth = 50;
            ProdRate[] workers = new ProdRate[5];
            for (int i = 0; i < workers.Length; i++)
            {
                ProdRate prodRate = new ProdRate();
                workers[i] = prodRate;
                workers[i].PayPerHour = 4;
            }
            double expected = 480;

            double actual = HRD.GetGeneralTax(workers);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestMethod7()
        {
            company.HoursPerMonth = 1;
            ProdRate[] workers = new ProdRate[5];
            for (int i = 0; i < workers.Length; i++)
            {
                ProdRate prodRate = new ProdRate();
                workers[i] = prodRate;
                workers[i].PayPerHour = 4;
            }
            double expected = 9.6;

            double actual = HRD.GetGeneralTax(workers);

            Assert.AreEqual(expected, actual);
        }
    }
}
