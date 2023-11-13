using System;

namespace Calculate
{
    public class Triangle : Shape
    {
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
        private bool CheckIsRightAngle() => Math.Pow(_sideC, 2) == Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2) ||
                                            Math.Pow(_sideA, 2) == Math.Pow(_sideC, 2) + Math.Pow(_sideB, 2) || 
                                            Math.Pow(_sideB, 2) == Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2);

        
        /// <summary>
        /// Calculate triangle's area
        /// </summary>
        public override double Area()
        {
            var semiPerimeter = 0.5 * (_sideA + _sideB + _sideC);
            return Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));
        }
    }
}