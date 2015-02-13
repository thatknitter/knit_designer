using System;
using KnitDesigner;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestKnitDesigner
{
    [TestClass]
    public class TestHem
    {
        [TestMethod]
        public void TestHemExists()
        {
            Hem hem = new Hem(36);
            Assert.AreEqual(36, hem.Circ);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestHemNotZero()
        {
            Hem hem = new Hem(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestHemPositive()
        {
            Hem hem = new Hem(-1);
        }

        [TestMethod]
        public void TestHemScale()
        {
            Hem hem = new Hem(36);
            hem.Gauge(6);
            Assert.AreEqual(216, hem.Circ);
        }
    }
}
