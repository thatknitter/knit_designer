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
    }
}
