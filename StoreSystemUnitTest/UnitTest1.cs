using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreSystem;
using StoreSystem.Interfaces;
using StoreSystem.Classes;
using System.Collections.Generic;

namespace StoreSystemUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private ICheckOut _checkout;

        [TestMethod]
        public void ReturnZeroWhenNoItemScanned()
        {
            _checkout = new CheckOut();
           Assert.AreEqual (_checkout.GetTotalPrice(), 0);
        }
        [TestMethod]
        public void TestIndividualProducts()
        {
            // Setup Products
            IList<Product> products = new List<Product>();
            products.Add(new Product("A", 50));

            _checkout = new CheckOut();
            _checkout.ProductItems = products;
            _checkout.Scan("A");
            Assert.AreEqual(_checkout.GetTotalPrice(),50);
        }


    }
}
