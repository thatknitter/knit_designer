using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnitDesigner
{
    abstract public class Sweater
     {
        public string Neck {
            get { return ("Crew"); }
        }

        public string Sub {
            get { return ("Pullover"); }
        }

        public string Shoulder {
            get { return ("Drop"); } 
        }

        public string Sleeve {
            get { return ("Long"); }
        }

        public string Size {
            get { return ("Small"); }
        }

        abstract public decimal Waist { get; }

        abstract public decimal Length { get; }

        abstract public decimal Bust { get; }

        abstract public decimal Base { get; }

        abstract public decimal ShoulderWidth { get; }

        abstract public decimal SleeveLength { get; }

        abstract public decimal SleeveWidth { get; }

        

    }
}
