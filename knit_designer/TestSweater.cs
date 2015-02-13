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

        //[TestMethod]
        //public void TestDefaultNeckline()
        //{
        //    Sweater sweater = new MySweater();
        //    Assert.AreEqual(Neck.Crew, sweater.Neckline);
        //}

        //[TestMethod]
        //public void TestDefaultSubtype()
        //{
        //    Sweater sweater = new MySweater();
        //    Assert.AreEqual(Sub.Pullover, sweater.SubType);
        //}

        //[TestMethod]
        //public void TestDefaultShoulder()
        //{
        //    Sweater sweater = new MySweater();
        //    Assert.AreEqual(Shoulder.Drop, sweater.ShoulderType);
        //}

        //[TestMethod]
        //public void TestDefaultSleeveType()
        //{
        //    Sweater sweater = new MySweater();
        //    Assert.AreEqual(Sleeve.Long, sweater.SleeveType);
        //}

        //[TestMethod]
        //public void TestDefaultSize()
        //{
        //    Sweater sweater = new MySweater();
        //    Assert.AreEqual(Size.Small, sweater.SizeDesigned);
        //}
    }
}