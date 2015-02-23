using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnitDesigner
{
    public class Sleeve
    {
        private Nullable<decimal> width;
        public Nullable<decimal> Width
        {
            get { return this.width; }
        }

        private decimal length;
        public decimal Length
        {
            get { return this.length; }
        }

        public Sleeve(decimal? width, decimal length)
        {
            if (width <= 0 && length > 0)
            {
                throw new ArgumentException("Please enter a valid number.");
            }
            if (length <= 0)
            {
                this.width = null;
            }
            this.width = width;
            this.length = length;
        }

        public decimal StitchCount(decimal perInch)
        {
            if (perInch <= 0)
            {
                throw new ArgumentException("Please make sure your gauge is a positve number.");
            }
            this.width = width * perInch;
            return (decimal)this.width;
        }

    }
}