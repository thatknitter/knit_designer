using System;
using KnitDesigner;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestKnitDesigner
{
    [TestClass]
    public class TestSweater
    {
        public class MySweater : Sweater
        {
            public override decimal Waist
            {
                get { throw new NotImplementedException(); }
            }

            public override decimal Length
            {
                get { throw new NotImplementedException(); }
            }

            public override decimal Bust
            {
                get { throw new NotImplementedException(); }
            }

            public override decimal Base
            {
                get { throw new NotImplementedException(); }
            }

            public override decimal ShoulderWidth
            {
                get { throw new NotImplementedException(); }
            }

            public override decimal SleeveLength
            {
                get { throw new NotImplementedException(); }
            }

            public override decimal SleeveWidth
            {
                get { throw new NotImplementedException(); }
            }

        }

        [TestMethod]
        public void TestDefaultNeckline()
        {
            Sweater sweater = new MySweater();
            Assert.AreEqual("Crew", sweater.Neck);
        }

        [TestMethod]
        public void TestDefaultSubtype()
        {
            Sweater sweater = new MySweater();
            Assert.AreEqual("Pullover", sweater.Sub);
        }

        [TestMethod]
        public void TestDefaultShoulder()
        {
            Sweater sweater = new MySweater();
            Assert.AreEqual("Drop", sweater.Shoulder);
        }

        [TestMethod]
        public void TestDefaultSleeveType()
        {
            Sweater sweater = new MySweater();
            Assert.AreEqual("Long", sweater.Sleeve);
        }

        [TestMethod]
        public void TestDefaultSize()
        {
            Sweater sweater = new MySweater();
            Assert.AreEqual("Small", sweater.Size);
        }
    }
}