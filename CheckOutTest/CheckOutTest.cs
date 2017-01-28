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

        [TestMethod]
        public void ScanC_Equals_20()
        {
            var checkOut = new CheckOut.CheckOut();
            checkOut.Scan("C");

            Assert.AreEqual(20, checkOut.GetTotalPrice());
        }

        [TestMethod]
        public void ScanD_Equals_15()
        {
            var checkOut = new CheckOut.CheckOut();
            checkOut.Scan("D");

            Assert.AreEqual(15, checkOut.GetTotalPrice());
        }
    }
}
