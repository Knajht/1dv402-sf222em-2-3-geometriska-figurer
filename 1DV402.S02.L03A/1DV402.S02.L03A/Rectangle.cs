using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S02.L03A
{
    class Rectangle : Shape
    {
        //Properties that calculates area and perimeter for a rectangle.
        public override double Area
        {
            get
            {
                return Length * Width;
            }
        }
        public override double Perimeter
        {
            get
            {
                return 2 * Length + 2 * Width;
            }
        }

        /// <summary>
        /// Constructor, calls base (Shape)
        /// </summary>
        public Rectangle(double length, double width)
            :base(length, width)
        {
        }
    }
}
