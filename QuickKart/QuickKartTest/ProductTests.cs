using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickKartBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuickKartBL.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void ProductTest()
        {
            Product pObjOne = new Product("P101", "Motorola G3 Turbo", 18000, 3);
            Product pObjTwo = new Product("P102", "Nike Shoes", 2500, 3);
            Assert.AreSame(pObjOne, pObjTwo);
        }
        [TestMethod()]
        public void CheckAvailabilityTest()
        {
            Product target = new Product("P101", "Motorola G3 Turbo", 18000, 3);
            int quantityPurchased = 10;
            bool actual = target.CheckAvailability(quantityPurchased);
            bool expected = false;
            Assert.AreEqual(expected, actual);
            // Test Case: 2
            target = new Product("P101", "Motorola G3 Turbo", 18000, 3);
            quantityPurchased = 2;
            actual = target.CheckAvailability(quantityPurchased);
            expected = true;
            Assert.AreEqual(expected, actual);
        }
    }
}
