using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace knit_designer
{
    [TestClass]
    public class GaugeTest
    {
        [TestMethod]
        public void TestGaugeEntered()
        {
            Gauge gauge = new Gauge(8);
            Assert.AreEqual(8, gauge.PerInch);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGaugeValid()
        {
            Gauge gauge = new Gauge(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGaugeValidNegative()
        {
            Gauge gauge = new Gauge(-1);
        }


    }
}
