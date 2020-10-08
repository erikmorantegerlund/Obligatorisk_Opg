using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model_Klasse_Opg1;

namespace UnitTest_Opg1
{
    [TestClass]
    public class UnitTest1
    {
        private FanOutPut _fanOutput;

        [TestInitialize]
        public void BeforeTest()
        {
            _fanOutput = new FanOutPut(1, "Erik", 25, 30);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestNameIsInvalid()
        {
            _fanOutput.Name = "1";

        }

        [TestMethod]
        public void TestNameIsValid()
        {

            Assert.AreEqual("Erik", _fanOutput.Name);
            _fanOutput.Name = "Gerlund";
            Assert.AreEqual("Gerlund", _fanOutput.Name);

        }

        [TestMethod]
        public void TestTempIsValid()
        {
            _fanOutput.Temp = 15;
            Assert.AreEqual(15, _fanOutput.Temp);
            _fanOutput.Temp = 25;
            Assert.AreEqual(25, _fanOutput.Temp);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestTempIsInvalidLessThan()
        {
            _fanOutput.Temp = 5;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestTempIsInvalidMoreThan()
        {
            _fanOutput.Temp = 30;
        }

        [TestMethod]
        public void TestMoistIsValid()
        {
            _fanOutput.Moist = 30;
            Assert.AreEqual(30, _fanOutput.Moist);
            _fanOutput.Moist = 80;
            Assert.AreEqual(80, _fanOutput.Moist);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMoistIsInvalidLessThan()
        {
            _fanOutput.Moist = 25;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMoistIsInvalidMoreThan()
        {
            _fanOutput.Moist = 85;
        }
    }
}
