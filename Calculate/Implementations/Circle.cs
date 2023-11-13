using System;
using Calculate.Interfaces;

namespace Calculate.Implementations
{
    public class Circle : IShape
    {
        private readonly double _radius;
        public double Radius => _radius;

        public Circle() => _radius = 1;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius can't be less or equal to zero");

            _radius = radius;
        }

        /// <summary>
        /// Calculate circle's area
        /// </summary>
        public double GetArea() => Math.PI * Math.Pow(_radius, 2);


        /// <summary>
        /// Calculate circle's perimeter
        /// </summary>
        public double GetPerimeter() => 2 * Math.PI * _radius;
    }
}