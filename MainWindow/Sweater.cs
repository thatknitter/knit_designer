using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnitDesigner
{
    abstract public class Sweater
     {
        public string Neck { get; set; }

        public string Sub { get; set; }

        public string Shoulder { get; set; }

        public string Sleeve { get; set; }

        public string Size { get; set; }

        abstract public decimal Waist { get; }

        abstract public decimal Length { get; }

        abstract public decimal Bust { get; }

        abstract public decimal Base { get; }

        abstract public decimal ShoulderWidth { get; }

        abstract public decimal SleeveLength { get; }

        abstract public decimal SleeveWidth { get; }



    }
}
