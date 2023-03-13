using System;

namespace Calculate
{
    public class Circle : Shape
    {
        private const double PI = Math.PI;

        private double _radius;
        public Circle()
        {
            _radius = 1;
        }

        public Circle(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentException("Less or equal to zero");
            }

            _radius = r;
        }

        public double R 
        { 
            get { return _radius; } 
            set { _radius = value; } 
        }

        public override double Area() => PI * _radius * _radius;
    }
}