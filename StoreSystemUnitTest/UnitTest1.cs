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
        [TestInitialize]
        public void TestInitialize()
        {
            IList<Product> Products = new List<Product>();
            Products.Add(new Product("A", 50, new Discount("CODE-3", 3, 130)));
            Products.Add(new Product("B", 30, new Discount("CODE-2", 2, 45)));
            Products.Add(new Product("C", 20, null));
            Products.Add(new Product("D", 15, null));
            _checkout = new CheckOut();
            _checkout.ProductItems = Products;
        }
        [TestMethod]
        public void ReturnZeroWhenNoItemScanned()
        {
           Assert.AreEqual (_checkout.GetTotalPrice(), 0);
        }
        [TestMethod]
        public void TestIndividualProducts_A()
        {
            _checkout.Scan("A");
            Assert.AreEqual(_checkout.GetTotalPrice(),50);
        }
        public void TestIndividualProducts_B()
        {
            _checkout.Scan("B");
            Assert.AreEqual(_checkout.GetTotalPrice(), 30);
        }
        public void TestIndividualProducts_C()
        {
            _checkout.Scan("C");
            Assert.AreEqual(_checkout.GetTotalPrice(), 20);
        }
        public void TestIndividualProducts_D()
        {
            _checkout = new CheckOut();
            _checkout.Scan("D");
            Assert.AreEqual(_checkout.GetTotalPrice(), 15);
        }
            public void TestAllProductsOneEach()
            {
                _checkout = new CheckOut();
                _checkout.Scan("A");
                _checkout.Scan("B");
                _checkout.Scan("C");
                _checkout.Scan("D");
            Assert.AreEqual(_checkout.GetTotalPrice(), 115);
            }
            public void TestRule1Single()
            {
                _checkout = new CheckOut();
                _checkout.Scan("A");
                _checkout.Scan("A");
                _checkout.Scan("A");
                Assert.AreEqual(_checkout.GetTotalPrice(), 130);
            }
            public void TestRule1MultipleButEqualSets()
            {
                _checkout = new CheckOut();
                _checkout.Scan("A");
                _checkout.Scan("A");
                _checkout.Scan("A");
                _checkout.Scan("A");
                _checkout.Scan("A");
                _checkout.Scan("A");
                _checkout.Scan("A");
                _checkout.Scan("A");
                _checkout.Scan("A");
            Assert.AreEqual(_checkout.GetTotalPrice(), 390);
            }
        public void TestRule1MixAndMatch()
        {
            _checkout = new CheckOut();
            _checkout.Scan("A");
            _checkout.Scan("A");
            _checkout.Scan("A");
            _checkout.Scan("A");
            _checkout.Scan("A");
            Assert.AreEqual(_checkout.GetTotalPrice(), 230);
        }
        public void TestRule2Single()
        {
            _checkout = new CheckOut();
            _checkout.Scan("B");
            _checkout.Scan("B");
            Assert.AreEqual(_checkout.GetTotalPrice(), 45);
        }
        public void TestRule2MultipleButEqualSets()
        {
            _checkout = new CheckOut();
            _checkout.Scan("B");
            _checkout.Scan("B");
            _checkout.Scan("B");
            _checkout.Scan("B");
            Assert.AreEqual(_checkout.GetTotalPrice(), 180);
        }
        public void TestRule2MixAndMatch()
        {
            _checkout = new CheckOut();
            _checkout.Scan("B");
            _checkout.Scan("B");
            _checkout.Scan("B");
            Assert.AreEqual(_checkout.GetTotalPrice(), 75);
        }


    }
}
