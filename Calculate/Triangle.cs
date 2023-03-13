using System;

namespace Calculate
{
    public class Triangle : Shape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle()
        {
            _sideA = 1;
            _sideB = 1;
            _sideC = 1;
        }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Less or equal to zero");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Error input, is not a triangle");
            }

            _sideA = a;
            _sideB = b;
            _sideC = c;
        }

        public double A 
        { 
            get { return _sideA; } 
            set { _sideA = value; }
        }

        public double B
        {
            get { return _sideB; }
            set { _sideB = value; }
        }

        public double C
        {
            get { return _sideC; }
            set { _sideC = value; }
        }

        public bool IsRectangle() => _sideC * _sideC == _sideA * _sideA + _sideB * _sideB || _sideA * _sideA == _sideC * _sideC + _sideB * _sideB || _sideB * _sideB == _sideC * _sideC + _sideA * _sideA;

        public override double Area()
        {
            var p = 0.5 * (_sideA + _sideB + _sideC);
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }
    }
}