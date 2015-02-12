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
            public override int Waist
            {
                get { throw new NotImplementedException(); }
            }

            public override int Length
            {
                get { throw new NotImplementedException(); }
            }

            public override int Bust
            {
                get { throw new NotImplementedException(); }
            }

            public override int Base
            {
                get { throw new NotImplementedException(); }
            }

            public override int Shoulder
            {
                get { throw new NotImplementedException(); }
            }

            public override int SleeveLength
            {
                get { throw new NotImplementedException(); }
            }

            public override int SleeveWidth
            {
                get { throw new NotImplementedException(); }
            }    

        }

        [TestMethod]
        public void TestDefaultNeckline()
        {
            Sweater sweater = new MySweater();
            Assert.AreEqual(Neck.Crew, sweater.Neckline);
        }

        [TestMethod]
        public void TestDefaultSubtype()
        {
            Sweater sweater = new MySweater();
            Assert.AreEqual(Sub.Pullover, sweater.Subtype);
        }

        [TestMethod]
        public void TestDefaultShoulder()
        {
            Sweater sweater = new MySweater();
            Assert.AreEqual(Shoulder.Drop, sweater.ShoulderType);
        }

        [TestMethod]
        public void TestDefaultSleeveType()
        {
            Sweater sweater = new MySweater();
            Assert.AreEqual(Sleeve.Long, sweater.SleeveType);
        }

        [TestMethod]
        public void TestDefaultSize()
        {
            Sweater sweater = new MySweater();
            Assert.AreEqual(Size.Small, sweater.RegSize);
        }
    }
}
