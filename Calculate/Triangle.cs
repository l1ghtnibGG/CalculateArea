using System;

namespace Calculate
{
    public class Triangle : Shape
    {
        private readonly Lazy<bool> _isRightAngle;
        
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public bool IsRightAngle => _isRightAngle.Value;
        
        public Triangle()
        {
            SideA = 1;
            SideB = 1;
            SideC = 1;

            _isRightAngle = new Lazy<bool>(CheckIsRightAngle);
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("A triangle side can't be less or equal to zero");
            
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("Error input, is not a triangle");
            
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            
            _isRightAngle = new Lazy<bool>(CheckIsRightAngle);
        }

        
        /// <summary>
        /// Checking for right angle
        /// </summary>
        /// <returns></returns>
        private bool CheckIsRightAngle() => Math.Pow(SideC, 2) == Math.Pow(SideA, 2) + Math.Pow(SideB, 2) ||
                                            Math.Pow(SideA, 2) == Math.Pow(SideC, 2) + Math.Pow(SideB, 2) || 
                                            Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2);

        
        /// <summary>
        /// Calculate triangle's area
        /// </summary>
        public override double Area()
        {
            var semiPerimeter = 0.5 * (SideA + SideB + SideC);
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }
    }
}