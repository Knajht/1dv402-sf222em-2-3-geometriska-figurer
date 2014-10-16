using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S02.L03A
{
    /// <summary>
    /// Enum of the possible shapes
    /// </summary>
    enum ShapeType {Ellipse, Rectangle };

    public abstract class Shape
    {
        #region Fields
        private double _length;
        private double _width; 
        #endregion

        #region Properties
        public double Length
        {
            get { return _length; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _length = value;
            }
        }
        public double Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _width = value;
            }
        }
        public abstract double Area { get; }
        public abstract double Perimeter { get; } 
        #endregion

        /// <summary>
        /// Constructor, takes length and width of intended shape
        /// </summary>
        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }

        /// <summary>
        /// Formats the shapes length, width, perimeter and area and returns it as a string.
        /// </summary>
        public override string ToString()
        {
            return String.Format("{0, -7}:{1, 12}\n{2, -7}:{3, 12}\n{4, -7}:{5, 12}\n{6, -7}:{7, 12}",
                "Längd", Length, "Bredd", Width, "Omkrets", Perimeter, "Area", Area);
        }
    }
}
