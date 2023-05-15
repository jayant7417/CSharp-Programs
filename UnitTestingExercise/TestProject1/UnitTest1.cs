using Exercise02;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Test Case 1
            Purchase target = new Purchase("1001", 3, "dcfdev", new DateTime(2016, 04, 01), "Card");
            double actual = target.CalculateBillAmount(2690.0, 3, target.quantityOrdered);
            double expected = 7827.9;
            Assert.AreEqual(actual, expected);

            //Test Case 2
            target = new Purchase("1001", 4, "dcfdev", new DateTime(2016, 04, 01), "Card");
            actual = target.CalculateBillAmount(-2690.0, 3, target.quantityOrdered);
            expected = -10437.2;
            Assert.AreEqual(actual, expected);

            //Test Case 3
            target = new Purchase("1001", 3, "dcfdev", new DateTime(2016, 04, 01), "Card");
            actual = target.CalculateBillAmount(0, 0, target.quantityOrdered);
            expected = 0;
            Assert.AreEqual(actual, expected);
        }
    }
}
