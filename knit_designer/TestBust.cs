using System;
using KnitDesigner;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestKnitDesigner
{
    [TestClass]
    public class TestBust
    {
        [TestMethod]
        public void TestBustExists()
        {
            Bust bust = new Bust(36);
            Assert.AreEqual(36, bust.Circ);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBustNotZero()
        {
            Bust bust = new Bust(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBustPositive()
        {
            Bust bust = new Bust(-1);
        }

        [TestMethod]
        public void TestBustTimesGauge()
        {
            Bust bust = new Bust(36);
            bust.Gauge(6);
            Assert.AreEqual(216, bust.Circ);
        }

    }
}
