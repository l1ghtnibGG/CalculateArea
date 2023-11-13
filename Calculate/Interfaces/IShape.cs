using System;

namespace Calculate.Interfaces
{
    public interface IShape
    {
        /// <summary>
        /// Calculate a shape's area
        /// </summary>
        public double GetArea();

        
        /// <summary>
        /// Calculate a shape's perimeter
        /// </summary>
        public double GetPerimeter();
    }
}


