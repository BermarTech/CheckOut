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
            var checkOut = new CheckOut.CheckOut;
            checkOut.Scan("A");

            Assert.AreEqual(50, checkOut.GetTotal);

        }
    }
}
