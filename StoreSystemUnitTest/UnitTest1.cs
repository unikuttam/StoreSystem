using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreSystem;
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
    }
}
