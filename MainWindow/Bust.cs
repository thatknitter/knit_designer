using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnitDesigner
{
    public class Bust
    {
        private decimal circ;
        public decimal Circ
        {
            get { return this.circ; }
        }

        public Bust(int circ)
        {
            if (circ <= 0)
            {
                throw new ArgumentException("Please enter a valid bust measurement.");
            }
            this.circ = circ;
        }

        public decimal Gauge(int circ) 
        {
            throw new NotImplementedException();
        }
    }
}
