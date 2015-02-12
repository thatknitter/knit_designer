using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnitDesigner
{
    public class Gauge
    {

        private decimal PerInch;
        public decimal perInch
        {
            get { return this.PerInch; }
        }

        public Gauge(int PerInch)
        {
            if (PerInch <= 0)
            {
                throw new ArgumentException("Please enter a valid number.");
            }
            this.PerInch = PerInch;
        }

        


    }
}
