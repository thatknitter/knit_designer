using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnitDesigner
{
    public class Shoulder
    {
        private decimal width;
        public decimal Width
        {
            get { return this.width; }
        }

        public Shoulder(int width)
        {
            if (width <= 0)
            {
                throw new ArgumentException("Please enter a valid shoulder measurement.");
            }
            this.width = width;
        }

        public decimal StitchCount(decimal perInch)
        {
            if (perInch <= 0)
            {
                throw new ArgumentException("Please make sure your gauge is a positve number.");
            }
            this.width = width * perInch;
            return this.width;
        }
    }
}
