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

        public Bust(decimal circ)
        {
            if (circ <= 0)
            {
                throw new ArgumentException("Please enter a valid bust measurement.");
            }
            this.circ = circ;
        }

        public decimal StitchCount(decimal perInch) 
        {
            if (perInch <= 0)
            {
                throw new ArgumentException("Please make sure your gauge is a positve number.");
            }
            this.circ = circ * perInch;
            return this.circ;
        }
    }
}
