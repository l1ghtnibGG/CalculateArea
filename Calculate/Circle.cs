using System;

namespace Calculate
{
    public class Circle : Shape
    {
        private readonly double _radius;
        public double Radius => _radius;
        
        public Circle()
        {
            _radius = 1;
        }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius can't be less or equal to zero");

            _radius = radius;
        }

        /// <summary>
        /// Calculate circle's area
        /// </summary>
        public override double Area() => Math.PI * Math.Pow(_radius, 2d);
    }
}