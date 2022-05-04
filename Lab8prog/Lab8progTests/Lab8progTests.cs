using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab8prog;

namespace Lab8progTests
{
    [TestClass]
    public class Lab8progTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            HRD company = new HRD();

            company.AddNoPremiumJob("work1", 10);
            company.AddNoPremiumJob("work3", 30);

            double expected = 40;
            double actual = company.GetTotalSalary();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            HRD company = new HRD();

            company.AddPremiumJob("work1", 10, 10);
            company.AddPremiumJob("work3", 30, 10);

            double expected = 44;
            double actual = company.GetTotalSalary();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            HRD company = new HRD();

            company.AddNoPremiumJob("work1", 10);
            company.AddPremiumJob("work3", 30, 50);

            double expected = 55;
            double actual = company.GetTotalSalary();

            Assert.AreEqual(expected, actual);
        }
    }
}
