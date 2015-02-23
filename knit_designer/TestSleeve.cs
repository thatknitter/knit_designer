using System;
using KnitDesigner;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestKnitDesigner
{
    [TestClass]
    public class TestSleeve
    {
        [TestMethod]
        public void TestSleeveDimensions()
        {
            Sleeve sleeve = new Sleeve(10, 20);
            Assert.AreEqual(20, sleeve.Length);
            Assert.AreEqual(10, sleeve.Width);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSleeveWidthNotNegative()
        {
            Sleeve sleeve = new Sleeve(-1, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSleeveLengthNotNegative()
        {
            Sleeve sleeve = new Sleeve(20, -1);
        }

    }
}
