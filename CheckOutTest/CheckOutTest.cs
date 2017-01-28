using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CheckOutTest
{
    [TestClass]
    public class CheckOutTest
    {
        private List<ScanTestData> SingleScanDataList;

        private List<ScanTestData> DoubleScanDataList;

        private List<ScanTestData> MultipleScanDataListWithDiscountItemsList;

        [TestInitialize]
        public void TestInitialize(){
            SingleScanDataList = new List<ScanTestData> {
                new ScanTestData("A", 50),
                new ScanTestData("B", 30),
                new ScanTestData("C", 20),
                new ScanTestData("D", 15)
            };

            DoubleScanDataList = new List<ScanTestData> {
                new ScanTestData("A,A", 100),
                new ScanTestData("A,B", 80),
                new ScanTestData("A,C", 70),
                new ScanTestData("B,C", 50),
                new ScanTestData("C,D", 35)
            };

            MultipleScanDataListWithDiscountItemsList = new List<ScanTestData> {
                new ScanTestData("A,A,A", 130),
                new ScanTestData("B,B", 45),
                new ScanTestData("A,B,B", 95),
                new ScanTestData("A,A,A,D", 145),
                new ScanTestData("A,A,A,B,B", 175)
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

        [TestMethod]
        public void DoubleScanTests()
        {
            foreach (var testCase in DoubleScanDataList)
            { 
                var checkOut = new CheckOut.CheckOut();
                string[] scans = testCase.ScanType.Split(',');
                foreach (string scan in scans)
                {
                    checkOut.Scan(scan);
                }

                Assert.AreEqual(testCase.ExpectedValue, checkOut.GetTotalPrice());

            }
        }

        [TestMethod]
        public void MultipleScanWithDiscountItemTests()
        {
            foreach (var testCase in MultipleScanDataListWithDiscountItemsList)
            {
                var checkOut = new CheckOut.CheckOut();
                string[] scans = testCase.ScanType.Split(',');
                foreach (string scan in scans)
                {
                    checkOut.Scan(scan);
                }

                Assert.AreEqual(testCase.ExpectedValue, checkOut.GetTotalPrice());

            }
        }

    }

    public class ScanTestData
    {
        
        public string ScanType;

        public int ExpectedValue;
        
        public ScanTestData(string scanType, int expectedValue){
            ScanType = scanType;
            ExpectedValue = expectedValue;

        }
    }
}
