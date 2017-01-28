using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckOutTest
{
    [TestClass]
    public class CheckOutTest
    {
        [TestMethod]
        public void ScanA_Equals_50()
        {
            var checkOut = new CheckOut.CheckOut();
            checkOut.Scan("A");

            Assert.AreEqual(50, checkOut.GetTotalPrice());
        }

        [TestMethod]
        public void ScanB_Equals_30()
        {
            var checkOut = new CheckOut.CheckOut();
            checkOut.Scan("B");

            Assert.AreEqual(30, checkOut.GetTotalPrice());
        }
    }
}
