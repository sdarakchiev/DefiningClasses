using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Display
    {
        private double size;
        private int numberOfColors;

        public Display (double size, int numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Size should be bigger than zero");
                }
                this.size = value;
            }
        }
        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (numberOfColors <= 0)
                {
                    throw new ArgumentException("Number of colors should be more than zero");
                }
                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Size: {0}, Number of colors: {1}", size, numberOfColors);
        }
    }
}
