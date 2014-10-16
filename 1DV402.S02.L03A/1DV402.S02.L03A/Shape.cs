using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S02.L03A
{
    enum ShapeType {Ellipse, Rectangle };
    public abstract class Shape
    {
        private double _length;
        private double _width;

        public double Length
        {
            get { return _length; }
            set { 
                if(value <= 0)
                {
                    throw new ArgumentException();
                }
                _length = value;
            }
        }
        public double Width
        {
            get { return _width; }
            set { 
                if(value <= 0)
                {
                    throw new ArgumentException();
                }
                _width = value; }
        }
        public abstract double Area;
        public abstract double Perimeter;

        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }



    }
}
