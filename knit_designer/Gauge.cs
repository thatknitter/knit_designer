using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace knit_designer
{
    class Gauge
    {
        private decimal 

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
