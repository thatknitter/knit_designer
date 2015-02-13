using System;
using KnitDesigner;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestKnitDesigner
{
    [TestClass]
    public class TestShoulderMeasure
    {
        [TestMethod]
        public void TestShoulderWidthExists()
        {
            Shoulder shoulder = new Shoulder(20);
            Assert.AreEqual(20, shoulder.Width);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestShoulderNotZero()
        {
            Shoulder shoulder = new Shoulder(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestShoulderPositive()
        {
            Shoulder shoulder = new Shoulder(-1);
        }

        [TestMethod]
        public void TestShoulderScale()
        {
            Shoulder shoulder = new Shoulder(20);
            shoulder.Gauge(6);
            Assert.AreEqual(120, shoulder.Width);
        }
    }
}
