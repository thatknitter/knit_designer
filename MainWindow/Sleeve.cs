using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnitDesigner
{
    public class Sleeve
    {
        private decimal width;
        public decimal Width
        {
            get { return this.width; }
        }

        private decimal length;
        public decimal Length
        {
            get { return this.length; }
        }

        public Sleeve(int width, int length)
        {
            if (width < 0 || length < 0)
            {
                throw new ArgumentException("Please enter a valid number.");
            }
            this.width = width;
            this.length = length;
        }


    }
}
