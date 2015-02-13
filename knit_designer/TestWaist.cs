using System;
using KnitDesigner;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestKnitDesigner
{
    [TestClass]
    public class TestWaist
    {
        [TestMethod]
        public void TestWaistExists()
        {
            Waist waist = new Waist(25);
            Assert.AreEqual(25, waist.Circ);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestWaistNotZero()
        {
            Waist waist = new Waist(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestWaistPositive()
        {
            Waist waist = new Waist(-1);
        }

        [TestMethod]
        public void TestWaistScale()
        {
            Waist waist = new Waist(25);
            waist.Gauge(6);
            Assert.AreEqual(150, waist.Circ);
        }
    }
}
