using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CheckOutTest
{
    [TestClass]
    public class CheckOutTest
    {
        private List<SingleScanTestData> SingleScanDataList;

        [TestInitialize]
        public void TestInitialize(){
            SingleScanDataList = new List<SingleScanTestData> {
                new SingleScanTestData("A", 50),
                new SingleScanTestData("B", 30),
                new SingleScanTestData("C", 20),
                new SingleScanTestData("D", 15)
            };
        
        }

        [TestMethod]
        public void SingleScanTests()
        {
            foreach (var testCase in SingleScanDataList)
            {
                var checkOut = new CheckOut.CheckOut();
                checkOut.Scan(testCase.ScanType);

                Assert.AreEqual(testCase.ExpectedValue, checkOut.GetTotalPrice());

            }
            
        }

    }

    public class SingleScanTestData
    {
        
        public string ScanType;

        public int ExpectedValue;
        
        public SingleScanTestData(string scanType, int expectedValue){
            ScanType = scanType;
            ExpectedValue = expectedValue;

        }
    }
}
