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
            Sleeve sleeve = new Sleeve(-1, 20);
        }

        [TestMethod]
        public void TestSleeve0Length()
        {
            Sleeve sleeve = new Sleeve(null, 0);
            Assert.AreEqual(0, sleeve.Length);
            Assert.AreEqual(null, sleeve.Width);
        }

        [TestMethod]
        public void TestSleeveScale()
        {
            Sleeve sleeve = new Sleeve(10, 20);
            sleeve.StitchCount(6);
            Assert.AreEqual(60, sleeve.Width);
            Assert.AreEqual(20, sleeve.Length);
        }
    }
}
