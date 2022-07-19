using System;

namespace Calculate
{
    public class Triangle : Shape
    {
        public double A { get; set; }

        public double B { get; set; }

        public double C { get; set; }

        public bool IsRectangle()
        {
            var max = C * C == A * A + B * B || A * A == C * C + B * B || B * B == C * C + A * A;

            return max;
        }

        public override double Area()
        {
            var p = 0.5 * (A + B + C);
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}