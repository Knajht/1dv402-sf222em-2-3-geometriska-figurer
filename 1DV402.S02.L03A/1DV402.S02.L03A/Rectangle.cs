using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S02.L03A
{
    class Rectangle : Shape
    {
        public double Area { get; }
        public double Width { get; }

        public Rectangle(double length, double width)
            :base(length, width)
        {

        }
    }
}
