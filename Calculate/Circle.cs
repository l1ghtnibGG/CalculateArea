using System;

namespace Calculate
{
    public class Circle : Shape
    {
        public double Radius { get; }
        
        public Circle()
        {
            Radius = 1;
        }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius can't be less or equal to zero");

            Radius = radius;
        }

        /// <summary>
        /// Calculate circle's area
        /// </summary>
        public override double Area() => Math.PI * Math.Pow(Radius, 2d);
    }
}