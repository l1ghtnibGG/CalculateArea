using System;
using Calculate.Interfaces;

namespace Calculate.Implementations
{
    public class Triangle : IShape
    {
        private const double Accuracy = 0.001;
        
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;
        
        private readonly Lazy<bool> _isRightAngle;

        public double SideA => _sideA;
        public double SideB => _sideB;
        public double SideC => _sideC;

        public bool IsRightAngle => _isRightAngle.Value;
        
        public Triangle()
        {
            _sideA = 1;
            _sideB = 1;
            _sideC = 1;
            
            _isRightAngle = new Lazy<bool>(CheckIsRightAngle);
        }
        
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("A triangle side can't be less or equal to zero");
            
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("Error input, is not a triangle");
            
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
            
            _isRightAngle = new Lazy<bool>(CheckIsRightAngle);
        }

        /// <summary>
        /// Checking for right angle
        /// </summary>
        /// <returns></returns>
        private bool CheckIsRightAngle()
        {
            var sides = new[] { _sideA, _sideB, _sideC };
            Array.Sort(sides);
            var hypotenuse = sides[^1];

            return Math.Abs(Math.Pow(hypotenuse, 2) - Math.Pow(sides[0], 2) - Math.Pow(sides[1], 2)) < Accuracy;
        }
        
        /// <summary>
        /// Calculate triangle's area
        /// </summary>
        public double GetArea()
        {
            var semiPerimeter = 0.5 * GetPerimeter();
            
            return Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));
        }

        
        /// <summary>
        /// Calculate triangle's perimeter
        /// </summary>
        public double GetPerimeter() => _sideA + _sideB + _sideC;
    }
}